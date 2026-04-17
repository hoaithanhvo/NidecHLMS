using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId1",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentStepId1",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropColumn(
                name: "TrainingContentStepId1",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentFlowId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.AddColumn<int>(
                name: "TrainingContentStepId1",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentStepId1",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId1");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId1",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId1",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
