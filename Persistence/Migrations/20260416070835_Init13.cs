using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
