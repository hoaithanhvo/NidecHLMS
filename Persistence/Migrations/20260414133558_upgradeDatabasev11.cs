using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_LEVEL_M_TRAINING_CONTENT_OperationDetailId",
                table: "M_SKILLMAP_LEVEL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatusId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropTable(
                name: "M_OPERATION_STATUS");

         

            migrationBuilder.DropIndex(
                name: "IX_M_SKILLMAP_LEVEL_OperationDetailId",
                table: "M_SKILLMAP_LEVEL");


            migrationBuilder.DropColumn(
                name: "OperationDetailNumber",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "TrainingContent",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "OpertionStatusId",
                table: "M_TRAINING_CONTENT",
                newName: "TrainingContentStepId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_OpertionStatusId",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_TrainingContentStepId");

            migrationBuilder.AddColumn<string>(
                name: "ManagementNumber",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainingContentName",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "M_TRAINING_CONTENT_STEP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_CONTENT_STEP", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropTable(
                name: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.DropColumn(
                name: "ManagementNumber",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "TrainingContentName",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                newName: "OpertionStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_OpertionStatusId");


            migrationBuilder.AddColumn<string>(
                name: "OperationDetailNumber",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainingContent",
                table: "M_TRAINING_CONTENT",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "M_OPERATION_STATUS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OPERATION_STATUS", x => x.Id);
                });

         

            migrationBuilder.CreateIndex(
                name: "IX_M_SKILLMAP_LEVEL_OperationDetailId",
                table: "M_SKILLMAP_LEVEL",
                column: "OperationDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_LEVEL_M_TRAINING_CONTENT_OperationDetailId",
                table: "M_SKILLMAP_LEVEL",
                column: "OperationDetailId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatusId",
                table: "M_TRAINING_CONTENT",
                column: "OpertionStatusId",
                principalTable: "M_OPERATION_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

          
        }
    }
}
