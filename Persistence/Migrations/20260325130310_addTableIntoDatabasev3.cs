using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addTableIntoDatabasev3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "M_USER");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "M_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_M_USER_StatusId",
                table: "M_USER",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_USER_M_STATUS_StatusId",
                table: "M_USER",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_M_STATUS_StatusId",
                table: "M_USER");

            migrationBuilder.DropIndex(
                name: "IX_M_USER_StatusId",
                table: "M_USER");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "M_USER");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "M_USER",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
