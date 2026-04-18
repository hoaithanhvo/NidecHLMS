using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_USER_M_USERId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_M_USERId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "M_USERId",
                table: "T_USER_TRAINING_PROGRESS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "M_USERId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_M_USERId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "M_USERId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_USER_M_USERId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "M_USERId",
                principalTable: "M_USER",
                principalColumn: "Id");
        }
    }
}
