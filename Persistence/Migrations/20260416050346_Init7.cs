using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_M_OPERATION_OperationCode_OperationName",
                table: "M_OPERATION");

            migrationBuilder.AddColumn<string>(
                name: "ManagementNumber",
                table: "M_OPERATION",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_OperationCode_OperationName_ManagementNumber",
                table: "M_OPERATION",
                columns: new[] { "OperationCode", "OperationName", "ManagementNumber" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_M_OPERATION_OperationCode_OperationName_ManagementNumber",
                table: "M_OPERATION");

            migrationBuilder.DropColumn(
                name: "ManagementNumber",
                table: "M_OPERATION");

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_OperationCode_OperationName",
                table: "M_OPERATION",
                columns: new[] { "OperationCode", "OperationName" },
                unique: true);
        }
    }
}
