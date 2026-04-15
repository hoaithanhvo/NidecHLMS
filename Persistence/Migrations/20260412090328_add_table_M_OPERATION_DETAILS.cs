using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_table_M_M_TRAINING_CONTENTS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSkillRequired",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "TestCode",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "TrainingDocumentCode",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropColumn(
                name: "JobCode",
                table: "M_OPERATION");

            migrationBuilder.RenameColumn(
                name: "RetrainingFrequency",
                table: "M_TRAINING_CONTENT",
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
                table: "M_TRAINING_CONTENT",
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
                name: "IX_M_TRAINING_CONTENT_OperationId",
                table: "M_TRAINING_CONTENT",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_OpertionStatus",
                table: "M_TRAINING_CONTENT",
                column: "OpertionStatus");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatus",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropTable(
                name: "M_OPERATION_STATUS");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_OpertionStatus",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "OpertionStatus",
                table: "M_TRAINING_CONTENT",
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
                table: "M_TRAINING_CONTENT",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestCode",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainingDocumentCode",
                table: "M_TRAINING_CONTENT",
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
