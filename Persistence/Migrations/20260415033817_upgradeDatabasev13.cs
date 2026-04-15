using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LEARNING_REPORT_M_OPERATION_OperationId",
                table: "LEARNING_REPORT");

            migrationBuilder.DropTable(
                name: "M_OPERATION_LIFECYCLE");

            migrationBuilder.RenameColumn(
                name: "OperationId",
                table: "LEARNING_REPORT",
                newName: "TrainingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_LEARNING_REPORT_OperationId",
                table: "LEARNING_REPORT",
                newName: "IX_LEARNING_REPORT_TrainingDocumentId");

            migrationBuilder.AddColumn<int>(
                name: "M_TRAINING_CONTENT_LIFECYCLEId",
                table: "M_TRAINING_CONTENT",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "M_TRAINING_CONTENT_LIFECYCLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRenew = table.Column<bool>(type: "bit", nullable: false),
                    RetrainingFrequency = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_CONTENT_LIFECYCLE", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLEId",
                table: "M_TRAINING_CONTENT",
                column: "M_TRAINING_CONTENT_LIFECYCLEId");

            migrationBuilder.AddForeignKey(
                name: "FK_LEARNING_REPORT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "LEARNING_REPORT",
                column: "TrainingDocumentId",
                principalTable: "M_TRAINING_DOCUMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_M_TRAINING_CONTENT_LIFECYCLEId",
                table: "M_TRAINING_CONTENT",
                column: "M_TRAINING_CONTENT_LIFECYCLEId",
                principalTable: "M_TRAINING_CONTENT_LIFECYCLE",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LEARNING_REPORT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "LEARNING_REPORT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_M_TRAINING_CONTENT_LIFECYCLEId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropTable(
                name: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLEId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "M_TRAINING_CONTENT_LIFECYCLEId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "TrainingDocumentId",
                table: "LEARNING_REPORT",
                newName: "OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_LEARNING_REPORT_TrainingDocumentId",
                table: "LEARNING_REPORT",
                newName: "IX_LEARNING_REPORT_OperationId");

            migrationBuilder.CreateTable(
                name: "M_OPERATION_LIFECYCLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmRecurringOperation = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetrainingFrequency = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OPERATION_LIFECYCLE", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LEARNING_REPORT_M_OPERATION_OperationId",
                table: "LEARNING_REPORT",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
