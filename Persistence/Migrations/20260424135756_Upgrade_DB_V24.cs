using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.RenameColumn(
                name: "TrainingContentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "TrainingContentStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.RenameColumn(
                name: "TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "TrainingContentFlowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentFlowStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentFlowStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
