using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_table_M_M_TRAINING_CONTENTS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatus",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "OperationDetailCode",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "OpertionStatus",
                table: "M_TRAINING_CONTENT",
                newName: "OpertionStatus_Id");

            migrationBuilder.RenameColumn(
                name: "OperationId",
                table: "M_TRAINING_CONTENT",
                newName: "Operation_Id");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_OpertionStatus",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_OpertionStatus_Id");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_OperationId",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_Operation_Id");

            migrationBuilder.AlterColumn<string>(
                name: "TrainingContent",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperationDetailNumber",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_Operation_Id",
                table: "M_TRAINING_CONTENT",
                column: "Operation_Id",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatus_Id",
                table: "M_TRAINING_CONTENT",
                column: "OpertionStatus_Id",
                principalTable: "M_OPERATION_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_Operation_Id",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatus_Id",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "OperationDetailNumber",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "OpertionStatus_Id",
                table: "M_TRAINING_CONTENT",
                newName: "OpertionStatus");

            migrationBuilder.RenameColumn(
                name: "Operation_Id",
                table: "M_TRAINING_CONTENT",
                newName: "OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_OpertionStatus_Id",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_OpertionStatus");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_Operation_Id",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_OperationId");

            migrationBuilder.AlterColumn<string>(
                name: "TrainingContent",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "OperationDetailCode",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatus",
                table: "M_TRAINING_CONTENT",
                column: "OpertionStatus",
                principalTable: "M_OPERATION_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
