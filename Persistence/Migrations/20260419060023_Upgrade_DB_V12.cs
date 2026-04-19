using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
                table: "T_TRAINING_SESSION");

            migrationBuilder.DropTable(
                name: "LEARNING_REPORT");

            migrationBuilder.DropTable(
                name: "M_SKILLMAP_LEVEL");

            migrationBuilder.DropTable(
                name: "T_ASSESSMENT_RESULT");

            migrationBuilder.DropTable(
                name: "T_COURSE_CONTENT");

            migrationBuilder.DropTable(
                name: "T_SKILLMAP");

            migrationBuilder.DropTable(
                name: "T_TRAINING_ATTENDEE");

            migrationBuilder.DropTable(
                name: "T_ASSESSMENT");

            migrationBuilder.DropTable(
                name: "T_TRAINING_COURSE");

            migrationBuilder.DropIndex(
                name: "IX_T_TRAINING_SESSION_TrainingAttendeeId",
                table: "T_TRAINING_SESSION");

            migrationBuilder.DropColumn(
                name: "AchievedDate",
                table: "T_USER_TAG");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "M_LEVEL");

            migrationBuilder.AlterColumn<string>(
                name: "EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "StepType",
                table: "M_TRAINING_CONTENT_STEP",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "M_TAG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillmapTemplateId",
                table: "M_OPERATION",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "M_LEVEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "M_SKILLMAP_CRITERIA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SKILLMAP_CRITERIA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_SKILLMAP_TEMPLATE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SKILLMAP_TEMPLATE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_SKILLMAP_RESULT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentId = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPass = table.Column<bool>(type: "bit", nullable: false),
                    Evaluator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SKILLMAP_RESULT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "T_USER_TRAINING_ENROLLMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_TRAINING_FILE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentFlowId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentFlowStepId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedBy = table.Column<int>(type: "int", nullable: true),
                    UploadedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TRAINING_FILE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                        column: x => x.TrainingContentFlowStepId,
                        principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                        column: x => x.TrainingContentFlowId,
                        principalTable: "M_TRAINING_CONTENT_FLOW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "T_USER_TRAINING_ENROLLMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "M_SKILLMAP_TEMPLATE_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    CriteriaId = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SKILLMAP_TEMPLATE_DETAIL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                        column: x => x.CriteriaId,
                        principalTable: "M_SKILLMAP_CRITERIA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_TEMPLATE_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "M_SKILLMAP_TEMPLATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_SKILLMAP_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillmapResultId = table.Column<int>(type: "int", nullable: false),
                    CriteriaId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SKILLMAP_DETAIL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_SKILLMAP_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                        column: x => x.CriteriaId,
                        principalTable: "M_SKILLMAP_CRITERIA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_SKILLMAP_DETAIL_T_SKILLMAP_RESULT_SkillmapResultId",
                        column: x => x.SkillmapResultId,
                        principalTable: "T_SKILLMAP_RESULT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "EnrollmentCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_SkillmapTemplateId",
                table: "M_OPERATION",
                column: "SkillmapTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_M_SKILLMAP_TEMPLATE_DETAIL_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "CriteriaId");

            migrationBuilder.CreateIndex(
                name: "IX_M_SKILLMAP_TEMPLATE_DETAIL_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_DETAIL_CriteriaId",
                table: "T_SKILLMAP_DETAIL",
                column: "CriteriaId");

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_DETAIL_SkillmapResultId",
                table: "T_SKILLMAP_DETAIL",
                column: "SkillmapResultId");

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_RESULT_EnrollmentId",
                table: "T_SKILLMAP_RESULT",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_FILE_EnrollmentId",
                table: "T_TRAINING_FILE",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_FILE_TrainingContentFlowId",
                table: "T_TRAINING_FILE",
                column: "TrainingContentFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_FILE_TrainingContentFlowStepId",
                table: "T_TRAINING_FILE",
                column: "TrainingContentFlowStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_SKILLMAP_TEMPLATE_SkillmapTemplateId",
                table: "M_OPERATION",
                column: "SkillmapTemplateId",
                principalTable: "M_SKILLMAP_TEMPLATE",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_SKILLMAP_TEMPLATE_SkillmapTemplateId",
                table: "M_OPERATION");

            migrationBuilder.DropTable(
                name: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropTable(
                name: "T_SKILLMAP_DETAIL");

            migrationBuilder.DropTable(
                name: "T_TRAINING_FILE");

            migrationBuilder.DropTable(
                name: "M_SKILLMAP_TEMPLATE");

            migrationBuilder.DropTable(
                name: "M_SKILLMAP_CRITERIA");

            migrationBuilder.DropTable(
                name: "T_SKILLMAP_RESULT");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropIndex(
                name: "IX_M_OPERATION_SkillmapTemplateId",
                table: "M_OPERATION");

            migrationBuilder.DropColumn(
                name: "StepType",
                table: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "M_TAG");

            migrationBuilder.DropColumn(
                name: "SkillmapTemplateId",
                table: "M_OPERATION");

            migrationBuilder.AlterColumn<string>(
                name: "EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<DateTime>(
                name: "AchievedDate",
                table: "T_USER_TAG",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "M_LEVEL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "M_LEVEL",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LEARNING_REPORT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingDocumentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LeaningReportCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Trainer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEARNING_REPORT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LEARNING_REPORT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LEARNING_REPORT_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "M_SKILLMAP_LEVEL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coefficient = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EvaluationCategoryEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluationCategoryVI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationDetailId = table.Column<int>(type: "int", nullable: false),
                    Standard = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SKILLMAP_LEVEL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_ASSESSMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovalBy = table.Column<int>(type: "int", nullable: false),
                    TrainingDocumentId = table.Column<int>(type: "int", nullable: false),
                    ApprovalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssessmentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ConfirmBy = table.Column<int>(type: "int", nullable: false),
                    ConfirmDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ManagementNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scope = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ASSESSMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_M_USER_ApprovalBy",
                        column: x => x.ApprovalBy,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_TRAINING_COURSE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TRAINING_COURSE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_ASSESSMENT_RESULT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ASSESSMENT_RESULT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_RESULT_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_RESULT_T_ASSESSMENT_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "T_ASSESSMENT",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "T_SKILLMAP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApproveBy = table.Column<int>(type: "int", nullable: false),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    ConfirmBy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IssueBy = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SKILLMAP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_SKILLMAP_M_USER_ApproveBy",
                        column: x => x.ApproveBy,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_SKILLMAP_T_ASSESSMENT_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "T_ASSESSMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_COURSE_CONTENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_COURSE_CONTENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_COURSE_CONTENT_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_COURSE_CONTENT_T_TRAINING_COURSE_CourseId",
                        column: x => x.CourseId,
                        principalTable: "T_TRAINING_COURSE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_TRAINING_ATTENDEE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TrainingCourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TRAINING_ATTENDEE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_ATTENDEE_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_TRAINING_ATTENDEE_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_TRAINING_ATTENDEE_T_TRAINING_COURSE_TrainingCourseId",
                        column: x => x.TrainingCourseId,
                        principalTable: "T_TRAINING_COURSE",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_SESSION_TrainingAttendeeId",
                table: "T_TRAINING_SESSION",
                column: "TrainingAttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LEARNING_REPORT_TrainingDocumentId",
                table: "LEARNING_REPORT",
                column: "TrainingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_LEARNING_REPORT_UserId",
                table: "LEARNING_REPORT",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_ApprovalBy",
                table: "T_ASSESSMENT",
                column: "ApprovalBy");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_TrainingDocumentId",
                table: "T_ASSESSMENT",
                column: "TrainingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_RESULT_AssessmentId",
                table: "T_ASSESSMENT_RESULT",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_RESULT_UserId",
                table: "T_ASSESSMENT_RESULT",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_T_COURSE_CONTENT_CourseId",
                table: "T_COURSE_CONTENT",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_T_COURSE_CONTENT_TrainingContentId",
                table: "T_COURSE_CONTENT",
                column: "TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_ApproveBy",
                table: "T_SKILLMAP",
                column: "ApproveBy");

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_AssessmentId",
                table: "T_SKILLMAP",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_ATTENDEE_StatusId",
                table: "T_TRAINING_ATTENDEE",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_ATTENDEE_TrainingCourseId",
                table: "T_TRAINING_ATTENDEE",
                column: "TrainingCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_ATTENDEE_UserId",
                table: "T_TRAINING_ATTENDEE",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
                table: "T_TRAINING_SESSION",
                column: "TrainingAttendeeId",
                principalTable: "T_TRAINING_ATTENDEE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
