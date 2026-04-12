using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_table_M_OPERATION_DETAILS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_OperationId",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_STATUS_OpertionStatus",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropColumn(
                name: "OperationDetailCode",
                table: "OPERATION_DETAIL");

            migrationBuilder.RenameColumn(
                name: "OpertionStatus",
                table: "OPERATION_DETAIL",
                newName: "OpertionStatus_Id");

            migrationBuilder.RenameColumn(
                name: "OperationId",
                table: "OPERATION_DETAIL",
                newName: "Operation_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAIL_OpertionStatus",
                table: "OPERATION_DETAIL",
                newName: "IX_OPERATION_DETAIL_OpertionStatus_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAIL_OperationId",
                table: "OPERATION_DETAIL",
                newName: "IX_OPERATION_DETAIL_Operation_Id");

            migrationBuilder.AlterColumn<string>(
                name: "TrainingContent",
                table: "OPERATION_DETAIL",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperationDetailNumber",
                table: "OPERATION_DETAIL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_Operation_Id",
                table: "OPERATION_DETAIL",
                column: "Operation_Id",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_STATUS_OpertionStatus_Id",
                table: "OPERATION_DETAIL",
                column: "OpertionStatus_Id",
                principalTable: "M_OPERATION_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_Operation_Id",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_STATUS_OpertionStatus_Id",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropColumn(
                name: "OperationDetailNumber",
                table: "OPERATION_DETAIL");

            migrationBuilder.RenameColumn(
                name: "OpertionStatus_Id",
                table: "OPERATION_DETAIL",
                newName: "OpertionStatus");

            migrationBuilder.RenameColumn(
                name: "Operation_Id",
                table: "OPERATION_DETAIL",
                newName: "OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAIL_OpertionStatus_Id",
                table: "OPERATION_DETAIL",
                newName: "IX_OPERATION_DETAIL_OpertionStatus");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAIL_Operation_Id",
                table: "OPERATION_DETAIL",
                newName: "IX_OPERATION_DETAIL_OperationId");

            migrationBuilder.AlterColumn<string>(
                name: "TrainingContent",
                table: "OPERATION_DETAIL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "OperationDetailCode",
                table: "OPERATION_DETAIL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_OperationId",
                table: "OPERATION_DETAIL",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_STATUS_OpertionStatus",
                table: "OPERATION_DETAIL",
                column: "OpertionStatus",
                principalTable: "M_OPERATION_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
