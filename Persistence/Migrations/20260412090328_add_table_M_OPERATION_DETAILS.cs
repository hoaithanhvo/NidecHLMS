using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_table_M_OPERATION_DETAILS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSkillRequired",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropColumn(
                name: "TestCode",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropColumn(
                name: "TrainingDocumentCode",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropColumn(
                name: "JobCode",
                table: "M_OPERATION");

            migrationBuilder.RenameColumn(
                name: "RetrainingFrequency",
                table: "OPERATION_DETAIL",
                newName: "OpertionStatus");

            migrationBuilder.RenameColumn(
                name: "TargetObject",
                table: "M_OPERATION",
                newName: "OperationName");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "M_OPERATION",
                newName: "OperationCode");

            migrationBuilder.AddColumn<int>(
                name: "OperationId",
                table: "OPERATION_DETAIL",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "M_OPERATION_STATUS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OPERATION_STATUS", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OPERATION_DETAIL_OperationId",
                table: "OPERATION_DETAIL",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OPERATION_DETAIL_OpertionStatus",
                table: "OPERATION_DETAIL",
                column: "OpertionStatus");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_OperationId",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_STATUS_OpertionStatus",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropTable(
                name: "M_OPERATION_STATUS");

            migrationBuilder.DropIndex(
                name: "IX_OPERATION_DETAIL_OperationId",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropIndex(
                name: "IX_OPERATION_DETAIL_OpertionStatus",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "OPERATION_DETAIL");

            migrationBuilder.RenameColumn(
                name: "OpertionStatus",
                table: "OPERATION_DETAIL",
                newName: "RetrainingFrequency");

            migrationBuilder.RenameColumn(
                name: "OperationName",
                table: "M_OPERATION",
                newName: "TargetObject");

            migrationBuilder.RenameColumn(
                name: "OperationCode",
                table: "M_OPERATION",
                newName: "Note");

            migrationBuilder.AddColumn<bool>(
                name: "IsSkillRequired",
                table: "OPERATION_DETAIL",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "OPERATION_DETAIL",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestCode",
                table: "OPERATION_DETAIL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainingDocumentCode",
                table: "OPERATION_DETAIL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "M_OPERATION",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JobCode",
                table: "M_OPERATION",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
