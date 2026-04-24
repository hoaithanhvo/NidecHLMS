using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.RenameColumn(
                name: "TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "TrainingContentStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "IX_T_USER_TRAINING_PROGRESS_TrainingContentStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.RenameColumn(
                name: "TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "TrainingContentFlowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "IX_T_USER_TRAINING_PROGRESS_TrainingContentFlowStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentFlowStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
