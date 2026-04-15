using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_Operation_Id",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatus_Id",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "OpertionStatus_Id",
                table: "M_TRAINING_CONTENT",
                newName: "OpertionStatusId");

            migrationBuilder.RenameColumn(
                name: "Operation_Id",
                table: "M_TRAINING_CONTENT",
                newName: "OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_OpertionStatus_Id",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_OpertionStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_Operation_Id",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_OperationId");

            migrationBuilder.AlterColumn<string>(
                name: "LearnReport",
                table: "M_TRAINING_DOCUMENT",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "M_TRAINING_DOCUMENT",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "M_HANDOVER_RECORD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HandoverRecordCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HandOverRepordName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_HANDOVER_RECORD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_LEVEL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_LEVEL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_OPERATION_LIFECYCLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmRecurringOperation = table.Column<bool>(type: "bit", nullable: false),
                    RetrainingFrequency = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OPERATION_LIFECYCLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_SKILLMAP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillMapCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OperationDetailId = table.Column<int>(type: "int", nullable: false),
                    EvaluationItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Coefficient = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SKILLMAP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_SKILLMAP_M_TRAINING_CONTENT_OperationDetailId",
                        column: x => x.OperationDetailId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TRAINING_ATTENDEE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    TrainingDocumentId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Retraining = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    M_STATUSId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAINING_ATTENDEE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_M_STATUS_M_STATUSId",
                        column: x => x.M_STATUSId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_M_TRAINING_DOCUMENT_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_M_TRAINING_CONTENT_OperationId",
                        column: x => x.OperationId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_HATTAG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HatTagCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HatTagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_HATTAG", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_HATTAG_M_LEVEL_LevelId",
                        column: x => x.LevelId,
                        principalTable: "M_LEVEL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TRAINING_ATTENDEE_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAINING_ATTENDEE_DETAIL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_M_LEVEL_LevelId",
                        column: x => x.LevelId,
                        principalTable: "M_LEVEL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_M_OPERATION_OperationId",
                        column: x => x.OperationId,
                        principalTable: "M_OPERATION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_HATTAG_LevelId",
                table: "M_HATTAG",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_M_SKILLMAP_OperationDetailId",
                table: "M_SKILLMAP",
                column: "OperationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_M_STATUSId",
                table: "TRAINING_ATTENDEE",
                column: "M_STATUSId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_OperationId",
                table: "TRAINING_ATTENDEE",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_TrainingDocumentId",
                table: "TRAINING_ATTENDEE",
                column: "TrainingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_LevelId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_OperationId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_StatusId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT",
                column: "OperationId",
                principalTable: "M_OPERATION",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_STATUS_OpertionStatusId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropTable(
                name: "M_HANDOVER_RECORD");

            migrationBuilder.DropTable(
                name: "M_HATTAG");

            migrationBuilder.DropTable(
                name: "M_OPERATION_LIFECYCLE");

            migrationBuilder.DropTable(
                name: "M_SKILLMAP");

            migrationBuilder.DropTable(
                name: "TRAINING_ATTENDEE");

            migrationBuilder.DropTable(
                name: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropTable(
                name: "M_LEVEL");

            migrationBuilder.RenameColumn(
                name: "OpertionStatusId",
                table: "M_TRAINING_CONTENT",
                newName: "OpertionStatus_Id");

            migrationBuilder.RenameColumn(
                name: "OperationId",
                table: "M_TRAINING_CONTENT",
                newName: "Operation_Id");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_OpertionStatusId",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_OpertionStatus_Id");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_OperationId",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_Operation_Id");

            migrationBuilder.AlterColumn<string>(
                name: "LearnReport",
                table: "M_TRAINING_DOCUMENT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "M_TRAINING_DOCUMENT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

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
    }
}
