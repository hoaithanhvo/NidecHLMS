using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropColumn(
                name: "M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropColumn(
                name: "T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "ParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "ParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.AddColumn<int>(
                name: "M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "M_TRAINING_CONTENT_FLOW_STEPId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "T_TrainingParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "M_TRAINING_CONTENT_FLOW_STEPId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "T_TrainingParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
