using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEP_CurrentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_ParticipantId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "ParticipantId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.RenameColumn(
                name: "TrainingContentId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "UserTrainingEnrollmentId");

            migrationBuilder.RenameColumn(
                name: "CurrentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "TrainingContentFlowId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_CurrentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentFlowId");

            migrationBuilder.AddColumn<string>(
                name: "EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                name: "IX_T_USER_TRAINING_PROGRESS_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserTrainingEnrollmentId");

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
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "T_TrainingParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropColumn(
                name: "EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropColumn(
                name: "M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropColumn(
                name: "T_TrainingParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.RenameColumn(
                name: "UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "TrainingContentId");

            migrationBuilder.RenameColumn(
                name: "TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "CurrentFlowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_CurrentFlowStepId");

            migrationBuilder.AddColumn<int>(
                name: "ParticipantId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_ParticipantId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "ParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEP_CurrentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "CurrentFlowStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "ParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
