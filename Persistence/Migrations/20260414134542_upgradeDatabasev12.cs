using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_OperationTypeId",
                table: "M_OPERATION");

            migrationBuilder.RenameColumn(
                name: "OperationTypeId",
                table: "M_OPERATION",
                newName: "ObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_M_OPERATION_OperationTypeId",
                table: "M_OPERATION",
                newName: "IX_M_OPERATION_ObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                table: "M_OPERATION",
                column: "ObjectId",
                principalTable: "M_OBJECT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                table: "M_OPERATION");

            migrationBuilder.RenameColumn(
                name: "ObjectId",
                table: "M_OPERATION",
                newName: "OperationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_M_OPERATION_ObjectId",
                table: "M_OPERATION",
                newName: "IX_M_OPERATION_OperationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_OperationTypeId",
                table: "M_OPERATION",
                column: "OperationTypeId",
                principalTable: "M_OBJECT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
