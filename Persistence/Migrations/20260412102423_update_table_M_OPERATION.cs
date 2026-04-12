using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_table_M_OPERATION : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperationName",
                table: "M_OPERATION",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OperationCode",
                table: "M_OPERATION",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "M_OPERATION",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OperationTypeId",
                table: "M_OPERATION",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_DepartmentId",
                table: "M_OPERATION",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_OperationTypeId",
                table: "M_OPERATION",
                column: "OperationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION",
                column: "DepartmentId",
                principalTable: "M_DEPARTMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_OPERATION_TYPE_OperationTypeId",
                table: "M_OPERATION",
                column: "OperationTypeId",
                principalTable: "OPERATION_TYPE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_OPERATION_TYPE_OperationTypeId",
                table: "M_OPERATION");

            migrationBuilder.DropIndex(
                name: "IX_M_OPERATION_DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropIndex(
                name: "IX_M_OPERATION_OperationTypeId",
                table: "M_OPERATION");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropColumn(
                name: "OperationTypeId",
                table: "M_OPERATION");

            migrationBuilder.AlterColumn<string>(
                name: "OperationName",
                table: "M_OPERATION",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "OperationCode",
                table: "M_OPERATION",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }
    }
}
