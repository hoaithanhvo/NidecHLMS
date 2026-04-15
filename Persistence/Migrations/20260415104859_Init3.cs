using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_RESULT_StatusId",
                table: "T_TRAINING_RESULT",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_STATUS_StatusId",
                table: "T_TRAINING_RESULT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_STATUS_StatusId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropIndex(
                name: "IX_T_TRAINING_RESULT_StatusId",
                table: "T_TRAINING_RESULT");
        }
    }
}
