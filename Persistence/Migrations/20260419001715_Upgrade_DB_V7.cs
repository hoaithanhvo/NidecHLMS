using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowId_TrainingContentStepId_OrderNo",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                columns: new[] { "TrainingContentFlowId", "TrainingContentStepId", "OrderNo" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowId_TrainingContentStepId_OrderNo",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentFlowId");
        }
    }
}
