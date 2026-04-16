using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_ASSESSMENT_RESULT_ASSESSMENT_AssessmentId",
                table: "T_ASSESSMENT_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_ASSESSMENT_AssessmentId",
                table: "T_SKILLMAP");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_M_LEVEL_LevelId",
                table: "T_SKILLMAP");

            migrationBuilder.DropTable(
                name: "ASSESSMENT");

            migrationBuilder.DropIndex(
                name: "IX_T_SKILLMAP_LevelId",
                table: "T_SKILLMAP");

            migrationBuilder.AlterColumn<string>(
                name: "RoleCode",
                table: "M_ROLE",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PermissionCode",
                table: "M_PERMISSION",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "T_ASSESSMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TrainingDocumentId = table.Column<int>(type: "int", nullable: false),
                    Scope = table.Column<int>(type: "int", nullable: false),
                    ManagementNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmBy = table.Column<int>(type: "int", nullable: false),
                    ConfirmDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovalBy = table.Column<int>(type: "int", nullable: false),
                    ApprovalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    M_USERId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ASSESSMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_M_USER_ApprovalBy",
                        column: x => x.ApprovalBy,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_M_USER_M_USERId",
                        column: x => x.M_USERId,
                        principalTable: "M_USER",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_USER_EmployeeId",
                table: "M_USER",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_ROLE_RoleCode",
                table: "M_ROLE",
                column: "RoleCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_PERMISSION_PermissionCode",
                table: "M_PERMISSION",
                column: "PermissionCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_OperationCode",
                table: "M_OPERATION",
                column: "OperationCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_ApprovalBy",
                table: "T_ASSESSMENT",
                column: "ApprovalBy");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_M_USERId",
                table: "T_ASSESSMENT",
                column: "M_USERId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_TrainingDocumentId",
                table: "T_ASSESSMENT",
                column: "TrainingDocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_ASSESSMENT_RESULT_T_ASSESSMENT_AssessmentId",
                table: "T_ASSESSMENT_RESULT",
                column: "AssessmentId",
                principalTable: "T_ASSESSMENT",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_T_ASSESSMENT_AssessmentId",
                table: "T_SKILLMAP",
                column: "AssessmentId",
                principalTable: "T_ASSESSMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_ASSESSMENT_RESULT_T_ASSESSMENT_AssessmentId",
                table: "T_ASSESSMENT_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_T_ASSESSMENT_AssessmentId",
                table: "T_SKILLMAP");

            migrationBuilder.DropTable(
                name: "T_ASSESSMENT");

            migrationBuilder.DropIndex(
                name: "IX_M_USER_EmployeeId",
                table: "M_USER");

            migrationBuilder.DropIndex(
                name: "IX_M_ROLE_RoleCode",
                table: "M_ROLE");

            migrationBuilder.DropIndex(
                name: "IX_M_PERMISSION_PermissionCode",
                table: "M_PERMISSION");

            migrationBuilder.DropIndex(
                name: "IX_M_OPERATION_OperationCode",
                table: "M_OPERATION");

            migrationBuilder.AlterColumn<string>(
                name: "RoleCode",
                table: "M_ROLE",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PermissionCode",
                table: "M_PERMISSION",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "ASSESSMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingDocumentId = table.Column<int>(type: "int", nullable: false),
                    ApprovalBy = table.Column<int>(type: "int", nullable: false),
                    ApprovalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssessmentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ConfirmBy = table.Column<int>(type: "int", nullable: false),
                    ConfirmDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M_USERId = table.Column<int>(type: "int", nullable: true),
                    ManagementNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scope = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSESSMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSESSMENT_M_USER_M_USERId",
                        column: x => x.M_USERId,
                        principalTable: "M_USER",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_LevelId",
                table: "T_SKILLMAP",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ASSESSMENT_M_USERId",
                table: "ASSESSMENT",
                column: "M_USERId");

            migrationBuilder.CreateIndex(
                name: "IX_ASSESSMENT_TrainingDocumentId",
                table: "ASSESSMENT",
                column: "TrainingDocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_ASSESSMENT_RESULT_ASSESSMENT_AssessmentId",
                table: "T_ASSESSMENT_RESULT",
                column: "AssessmentId",
                principalTable: "ASSESSMENT",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_ASSESSMENT_AssessmentId",
                table: "T_SKILLMAP",
                column: "AssessmentId",
                principalTable: "ASSESSMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_M_LEVEL_LevelId",
                table: "T_SKILLMAP",
                column: "LevelId",
                principalTable: "M_LEVEL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
