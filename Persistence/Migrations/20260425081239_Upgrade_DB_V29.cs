using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V29 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "T_USER_TRAINING_PROGRESS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
