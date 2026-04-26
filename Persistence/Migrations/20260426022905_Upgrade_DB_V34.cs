using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_STEP_StatusId",
                table: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_STEP_TRANSITION_StatusId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_STEP_TRANSITION_StatusId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "M_TRAINING_CONTENT_STEP",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_STEP_StatusId",
                table: "M_TRAINING_CONTENT_STEP",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
