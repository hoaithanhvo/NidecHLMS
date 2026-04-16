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
            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_M_DEPARTMENT_DepartmentId",
                table: "M_USER");

            migrationBuilder.DropIndex(
                name: "IX_M_USER_DepartmentId",
                table: "M_USER");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "M_USER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "M_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_M_USER_DepartmentId",
                table: "M_USER",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_USER_M_DEPARTMENT_DepartmentId",
                table: "M_USER",
                column: "DepartmentId",
                principalTable: "M_DEPARTMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
