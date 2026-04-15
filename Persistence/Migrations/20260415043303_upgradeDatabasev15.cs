using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_OperationId",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_OPERATION_DETAIL_LIFECYCLE_OPERATION_DETAIL_LIFECYCLEId",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAIL_OPERATION_DETAIL_STEP_TrainingContentStepId",
                table: "OPERATION_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_SKILLMAP_OPERATION_DETAIL_OPERATION_DETAILId",
                table: "M_USER_SKILLMAP");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_OPERATION_DETAIL_OperationId",
                table: "TRAINING_ATTENDEE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OPERATION_DETAIL",
                table: "OPERATION_DETAIL");

            migrationBuilder.RenameTable(
                name: "OPERATION_DETAIL",
                newName: "OPERATION_DETAILS");

            migrationBuilder.RenameColumn(
                name: "OperationId",
                table: "OPERATION_DETAILS",
                newName: "TrainingContentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAIL_TrainingContentStepId",
                table: "OPERATION_DETAILS",
                newName: "IX_OPERATION_DETAILS_TrainingContentStepId");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAIL_OperationId",
                table: "OPERATION_DETAILS",
                newName: "IX_OPERATION_DETAILS_TrainingContentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAIL_OPERATION_DETAIL_LIFECYCLEId",
                table: "OPERATION_DETAILS",
                newName: "IX_OPERATION_DETAILS_OPERATION_DETAIL_LIFECYCLEId");

            migrationBuilder.AddColumn<int>(
                name: "M_TrainingContentId",
                table: "M_TRAINING_DOCUMENT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingContentId",
                table: "M_TRAINING_DOCUMENT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "M_OPERATIONId",
                table: "OPERATION_DETAILS",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OPERATION_DETAILS",
                table: "OPERATION_DETAILS",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OPERATION_DETAIL_TYPE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentTypeNameVI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContentTypeNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPERATION_DETAIL_TYPE", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_DOCUMENT_M_TrainingContentId",
                table: "M_TRAINING_DOCUMENT",
                column: "M_TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_OPERATION_DETAILS_M_OPERATIONId",
                table: "OPERATION_DETAILS",
                column: "M_OPERATIONId");

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAILS_M_OPERATION_M_OPERATIONId",
                table: "OPERATION_DETAILS",
                column: "M_OPERATIONId",
                principalTable: "M_OPERATION",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAILS_OPERATION_DETAIL_LIFECYCLE_OPERATION_DETAIL_LIFECYCLEId",
                table: "OPERATION_DETAILS",
                column: "OPERATION_DETAIL_LIFECYCLEId",
                principalTable: "OPERATION_DETAIL_LIFECYCLE",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAILS_OPERATION_DETAIL_STEP_TrainingContentStepId",
                table: "OPERATION_DETAILS",
                column: "TrainingContentStepId",
                principalTable: "OPERATION_DETAIL_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAILS_OPERATION_DETAIL_TYPE_TrainingContentTypeId",
                table: "OPERATION_DETAILS",
                column: "TrainingContentTypeId",
                principalTable: "OPERATION_DETAIL_TYPE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_DOCUMENT_OPERATION_DETAILS_M_TrainingContentId",
                table: "M_TRAINING_DOCUMENT",
                column: "M_TrainingContentId",
                principalTable: "OPERATION_DETAILS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_USER_SKILLMAP_OPERATION_DETAILS_OPERATION_DETAILId",
                table: "M_USER_SKILLMAP",
                column: "OPERATION_DETAILId",
                principalTable: "OPERATION_DETAILS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_OPERATION_DETAILS_OperationId",
                table: "TRAINING_ATTENDEE",
                column: "OperationId",
                principalTable: "OPERATION_DETAILS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAILS_M_OPERATION_M_OPERATIONId",
                table: "OPERATION_DETAILS");

            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAILS_OPERATION_DETAIL_LIFECYCLE_OPERATION_DETAIL_LIFECYCLEId",
                table: "OPERATION_DETAILS");

            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAILS_OPERATION_DETAIL_STEP_TrainingContentStepId",
                table: "OPERATION_DETAILS");

            migrationBuilder.DropForeignKey(
                name: "FK_OPERATION_DETAILS_OPERATION_DETAIL_TYPE_TrainingContentTypeId",
                table: "OPERATION_DETAILS");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_DOCUMENT_OPERATION_DETAILS_M_TrainingContentId",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_SKILLMAP_OPERATION_DETAILS_OPERATION_DETAILId",
                table: "M_USER_SKILLMAP");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_OPERATION_DETAILS_OperationId",
                table: "TRAINING_ATTENDEE");

            migrationBuilder.DropTable(
                name: "OPERATION_DETAIL_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_DOCUMENT_M_TrainingContentId",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OPERATION_DETAILS",
                table: "OPERATION_DETAILS");

            migrationBuilder.DropIndex(
                name: "IX_OPERATION_DETAILS_M_OPERATIONId",
                table: "OPERATION_DETAILS");

            migrationBuilder.DropColumn(
                name: "M_TrainingContentId",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropColumn(
                name: "TrainingContentId",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropColumn(
                name: "M_OPERATIONId",
                table: "OPERATION_DETAILS");

            migrationBuilder.RenameTable(
                name: "OPERATION_DETAILS",
                newName: "OPERATION_DETAIL");

            migrationBuilder.RenameColumn(
                name: "TrainingContentTypeId",
                table: "OPERATION_DETAIL",
                newName: "OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAILS_TrainingContentTypeId",
                table: "OPERATION_DETAIL",
                newName: "IX_OPERATION_DETAIL_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAILS_TrainingContentStepId",
                table: "OPERATION_DETAIL",
                newName: "IX_OPERATION_DETAIL_TrainingContentStepId");

            migrationBuilder.RenameIndex(
                name: "IX_OPERATION_DETAILS_OPERATION_DETAIL_LIFECYCLEId",
                table: "OPERATION_DETAIL",
                newName: "IX_OPERATION_DETAIL_OPERATION_DETAIL_LIFECYCLEId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OPERATION_DETAIL",
                table: "OPERATION_DETAIL",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAIL_M_OPERATION_OperationId",
                table: "OPERATION_DETAIL",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAIL_OPERATION_DETAIL_LIFECYCLE_OPERATION_DETAIL_LIFECYCLEId",
                table: "OPERATION_DETAIL",
                column: "OPERATION_DETAIL_LIFECYCLEId",
                principalTable: "OPERATION_DETAIL_LIFECYCLE",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OPERATION_DETAIL_OPERATION_DETAIL_STEP_TrainingContentStepId",
                table: "OPERATION_DETAIL",
                column: "TrainingContentStepId",
                principalTable: "OPERATION_DETAIL_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_USER_SKILLMAP_OPERATION_DETAIL_OPERATION_DETAILId",
                table: "M_USER_SKILLMAP",
                column: "OPERATION_DETAILId",
                principalTable: "OPERATION_DETAIL",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_OPERATION_DETAIL_OperationId",
                table: "TRAINING_ATTENDEE",
                column: "OperationId",
                principalTable: "OPERATION_DETAIL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
