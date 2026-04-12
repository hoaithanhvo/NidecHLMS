using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_table_M_OPERATION2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_OPERATION_TYPE_OperationTypeId",
                table: "M_OPERATION");

            migrationBuilder.RenameColumn(
                name: "OperationTypeId",
                table: "M_OPERATION",
                newName: "OperationType_Id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "M_OPERATION",
                newName: "Department_Id");

            migrationBuilder.RenameIndex(
                name: "IX_M_OPERATION_OperationTypeId",
                table: "M_OPERATION",
                newName: "IX_M_OPERATION_OperationType_Id");

            migrationBuilder.RenameIndex(
                name: "IX_M_OPERATION_DepartmentId",
                table: "M_OPERATION",
                newName: "IX_M_OPERATION_Department_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_Department_Id",
                table: "M_OPERATION",
                column: "Department_Id",
                principalTable: "M_DEPARTMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_OPERATION_TYPE_OperationType_Id",
                table: "M_OPERATION",
                column: "OperationType_Id",
                principalTable: "OPERATION_TYPE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_Department_Id",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_OPERATION_TYPE_OperationType_Id",
                table: "M_OPERATION");

            migrationBuilder.RenameColumn(
                name: "OperationType_Id",
                table: "M_OPERATION",
                newName: "OperationTypeId");

            migrationBuilder.RenameColumn(
                name: "Department_Id",
                table: "M_OPERATION",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_M_OPERATION_OperationType_Id",
                table: "M_OPERATION",
                newName: "IX_M_OPERATION_OperationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_M_OPERATION_Department_Id",
                table: "M_OPERATION",
                newName: "IX_M_OPERATION_DepartmentId");

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
    }
}
