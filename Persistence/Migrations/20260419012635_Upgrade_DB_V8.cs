using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP_CurrentStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_CurrentStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropColumn(
                name: "CurrentStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.RenameColumn(
                name: "CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "TrainingContentFlowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "IX_T_USER_TRAINING_PROGRESS_TrainingContentFlowStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentFlowStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.RenameColumn(
                name: "TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "CurrentStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "IX_T_USER_TRAINING_PROGRESS_CurrentStepId");

            migrationBuilder.AddColumn<int>(
                name: "CurrentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_CurrentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "CurrentStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP_CurrentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "CurrentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "CurrentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
