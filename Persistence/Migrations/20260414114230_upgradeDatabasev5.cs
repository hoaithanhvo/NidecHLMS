using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_OPERATION_TYPE_OperationType_Id",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_LEVEL_LevelId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_OPERATION_OperationId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropTable(
                name: "M_ASSESSMENT");

            migrationBuilder.DropTable(
                name: "M_SKILLMAP");

            migrationBuilder.DropTable(
                name: "OPERATION_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_LevelId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropColumn(
                name: "Retraining",
                table: "TRAINING_ATTENDEE");

            migrationBuilder.RenameColumn(
                name: "OperationId",
                table: "TRAINING_ATTENDEE_DETAIL",
                newName: "TrainingSessionId");

            migrationBuilder.RenameColumn(
                name: "LevelId",
                table: "TRAINING_ATTENDEE_DETAIL",
                newName: "LearningReportId");

            migrationBuilder.RenameIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_OperationId",
                table: "TRAINING_ATTENDEE_DETAIL",
                newName: "IX_TRAINING_ATTENDEE_DETAIL_TrainingSessionId");

            migrationBuilder.AddColumn<int>(
                name: "AssessmentId",
                table: "TRAINING_ATTENDEE_DETAIL",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "M_LEVELId",
                table: "TRAINING_ATTENDEE_DETAIL",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "M_OPERATIONId",
                table: "TRAINING_ATTENDEE_DETAIL",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "M_SESSION_TYPEId",
                table: "TRAINING_ATTENDEE_DETAIL",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Coefficient",
                table: "M_LEVEL",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "M_LEVEL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ASSESSMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TrainingDocument_Id = table.Column<int>(type: "int", nullable: false),
                    Scope = table.Column<int>(type: "int", nullable: false),
                    ManagementNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovalBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSESSMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocument_Id",
                        column: x => x.TrainingDocument_Id,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LEARNING_REPORT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LeaningReportCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Trainer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEARNING_REPORT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LEARNING_REPORT_M_OPERATION_OperationId",
                        column: x => x.OperationId,
                        principalTable: "M_OPERATION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LEARNING_REPORT_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_OBJECT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OBJECT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_SESSION_TYPE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionNameVI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SessionNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SessionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SESSION_TYPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_SKILLMAP_LEVEL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationDetailId = table.Column<int>(type: "int", nullable: false),
                    Standard = table.Column<int>(type: "int", nullable: false),
                    EnaluationCategoryEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnaluationCategoryVI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coefficient = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SKILLMAP_LEVEL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_SKILLMAP_LEVEL_M_TRAINING_CONTENT_OperationDetailId",
                        column: x => x.OperationDetailId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_USER_SKILLMAP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationDetailId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_TRAINING_CONTENTId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_USER_SKILLMAP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_USER_SKILLMAP_M_TRAINING_CONTENT_M_TRAINING_CONTENTId",
                        column: x => x.M_TRAINING_CONTENTId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TRAINING_ATTENDEE_SESSION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionTypeId = table.Column<int>(type: "int", nullable: false),
                    TrainingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TRAINING_ATTENDEEId = table.Column<int>(type: "int", nullable: true),
                    TRAINING_ATTENDEEId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAINING_ATTENDEE_SESSION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_SESSION_M_SESSION_TYPE_SessionTypeId",
                        column: x => x.SessionTypeId,
                        principalTable: "M_SESSION_TYPE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_SESSION_TRAINING_ATTENDEE_TRAINING_ATTENDEEId",
                        column: x => x.TRAINING_ATTENDEEId,
                        principalTable: "TRAINING_ATTENDEE",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_SESSION_TRAINING_ATTENDEE_TRAINING_ATTENDEEId1",
                        column: x => x.TRAINING_ATTENDEEId1,
                        principalTable: "TRAINING_ATTENDEE",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_AssessmentId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_M_LEVELId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "M_LEVELId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_M_OPERATIONId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "M_OPERATIONId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_M_SESSION_TYPEId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "M_SESSION_TYPEId");

            migrationBuilder.CreateIndex(
                name: "IX_ASSESSMENT_TrainingDocument_Id",
                table: "ASSESSMENT",
                column: "TrainingDocument_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LEARNING_REPORT_OperationId",
                table: "LEARNING_REPORT",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_LEARNING_REPORT_UserId",
                table: "LEARNING_REPORT",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_M_SKILLMAP_LEVEL_OperationDetailId",
                table: "M_SKILLMAP_LEVEL",
                column: "OperationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_M_USER_SKILLMAP_M_TRAINING_CONTENTId",
                table: "M_USER_SKILLMAP",
                column: "M_TRAINING_CONTENTId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_SESSION_SessionTypeId",
                table: "TRAINING_ATTENDEE_SESSION",
                column: "SessionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_SESSION_TRAINING_ATTENDEEId",
                table: "TRAINING_ATTENDEE_SESSION",
                column: "TRAINING_ATTENDEEId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_SESSION_TRAINING_ATTENDEEId1",
                table: "TRAINING_ATTENDEE_SESSION",
                column: "TRAINING_ATTENDEEId1");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_OperationType_Id",
                table: "M_OPERATION",
                column: "OperationType_Id",
                principalTable: "M_OBJECT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_ASSESSMENT_AssessmentId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "AssessmentId",
                principalTable: "ASSESSMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_LEVEL_M_LEVELId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "M_LEVELId",
                principalTable: "M_LEVEL",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_OPERATION_M_OPERATIONId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "M_OPERATIONId",
                principalTable: "M_OPERATION",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_SESSION_TYPE_M_SESSION_TYPEId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "M_SESSION_TYPEId",
                principalTable: "M_SESSION_TYPE",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_TRAINING_ATTENDEE_SESSION_TrainingSessionId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "TrainingSessionId",
                principalTable: "TRAINING_ATTENDEE_SESSION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_OperationType_Id",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_ASSESSMENT_AssessmentId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_LEVEL_M_LEVELId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_OPERATION_M_OPERATIONId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_SESSION_TYPE_M_SESSION_TYPEId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_TRAINING_ATTENDEE_SESSION_TrainingSessionId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropTable(
                name: "ASSESSMENT");

            migrationBuilder.DropTable(
                name: "LEARNING_REPORT");

            migrationBuilder.DropTable(
                name: "M_OBJECT");

            migrationBuilder.DropTable(
                name: "M_SKILLMAP_LEVEL");

            migrationBuilder.DropTable(
                name: "M_USER_SKILLMAP");

            migrationBuilder.DropTable(
                name: "TRAINING_ATTENDEE_SESSION");

            migrationBuilder.DropTable(
                name: "M_SESSION_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_AssessmentId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_M_LEVELId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_M_OPERATIONId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_M_SESSION_TYPEId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropColumn(
                name: "AssessmentId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropColumn(
                name: "M_LEVELId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropColumn(
                name: "M_OPERATIONId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropColumn(
                name: "M_SESSION_TYPEId",
                table: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.DropColumn(
                name: "Coefficient",
                table: "M_LEVEL");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "M_LEVEL");

            migrationBuilder.RenameColumn(
                name: "TrainingSessionId",
                table: "TRAINING_ATTENDEE_DETAIL",
                newName: "OperationId");

            migrationBuilder.RenameColumn(
                name: "LearningReportId",
                table: "TRAINING_ATTENDEE_DETAIL",
                newName: "LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_TrainingSessionId",
                table: "TRAINING_ATTENDEE_DETAIL",
                newName: "IX_TRAINING_ATTENDEE_DETAIL_OperationId");

            migrationBuilder.AddColumn<int>(
                name: "Retraining",
                table: "TRAINING_ATTENDEE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "M_ASSESSMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingDocument_Id = table.Column<int>(type: "int", nullable: false),
                    AssessmentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ASSESSMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocument_Id",
                        column: x => x.TrainingDocument_Id,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_SKILLMAP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationDetailId = table.Column<int>(type: "int", nullable: false),
                    Coefficient = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EvaluationItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SkillMapCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "OPERATION_TYPE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPERATION_TYPE", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_LevelId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_M_ASSESSMENT_TrainingDocument_Id",
                table: "M_ASSESSMENT",
                column: "TrainingDocument_Id");

            migrationBuilder.CreateIndex(
                name: "IX_M_SKILLMAP_OperationDetailId",
                table: "M_SKILLMAP",
                column: "OperationDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_OPERATION_TYPE_OperationType_Id",
                table: "M_OPERATION",
                column: "OperationType_Id",
                principalTable: "OPERATION_TYPE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_LEVEL_LevelId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "LevelId",
                principalTable: "M_LEVEL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_DETAIL_M_OPERATION_OperationId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
