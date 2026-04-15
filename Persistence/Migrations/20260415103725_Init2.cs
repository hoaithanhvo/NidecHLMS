using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_SESSION_TRAINING_ATTENDEE_TrainingAttendeeId",
                table: "T_TRAINING_SESSION");

            migrationBuilder.DropTable(
                name: "TRAINING_ATTENDEE");

            migrationBuilder.DropTable(
                name: "TRAINING_ATTENDEE_DETAIL");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "T_TRAINING_RESULT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "T_TRAINING_ATTENDEE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TrainingCourseId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "IX_T_TRAINING_RESULT_UserId",
                table: "T_TRAINING_RESULT",
                column: "UserId");

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
                name: "FK_T_TRAINING_RESULT_M_USER_UserId",
                table: "T_TRAINING_RESULT",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
                table: "T_TRAINING_SESSION",
                column: "TrainingAttendeeId",
                principalTable: "T_TRAINING_ATTENDEE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_USER_UserId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
                table: "T_TRAINING_SESSION");

            migrationBuilder.DropTable(
                name: "T_TRAINING_ATTENDEE");

            migrationBuilder.DropIndex(
                name: "IX_T_TRAINING_RESULT_UserId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.CreateTable(
                name: "TRAINING_ATTENDEE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_STATUSId = table.Column<int>(type: "int", nullable: true),
                    TrainingCourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAINING_ATTENDEE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_M_STATUS_M_STATUSId",
                        column: x => x.M_STATUSId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_T_TRAINING_COURSE_TrainingCourseId",
                        column: x => x.TrainingCourseId,
                        principalTable: "T_TRAINING_COURSE",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TRAINING_ATTENDEE_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TrainingSessionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LearningReportId = table.Column<int>(type: "int", nullable: false),
                    M_LEVELId = table.Column<int>(type: "int", nullable: true),
                    M_OPERATIONId = table.Column<int>(type: "int", nullable: true),
                    M_SESSION_TYPEId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAINING_ATTENDEE_DETAIL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_ASSESSMENT_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "ASSESSMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_M_LEVEL_M_LEVELId",
                        column: x => x.M_LEVELId,
                        principalTable: "M_LEVEL",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_M_OPERATION_M_OPERATIONId",
                        column: x => x.M_OPERATIONId,
                        principalTable: "M_OPERATION",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_M_SESSION_TYPE_M_SESSION_TYPEId",
                        column: x => x.M_SESSION_TYPEId,
                        principalTable: "M_SESSION_TYPE",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRAINING_ATTENDEE_DETAIL_T_TRAINING_SESSION_TrainingSessionId",
                        column: x => x.TrainingSessionId,
                        principalTable: "T_TRAINING_SESSION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_M_STATUSId",
                table: "TRAINING_ATTENDEE",
                column: "M_STATUSId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_TrainingCourseId",
                table: "TRAINING_ATTENDEE",
                column: "TrainingCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_UserId",
                table: "TRAINING_ATTENDEE",
                column: "UserId");

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
                name: "IX_TRAINING_ATTENDEE_DETAIL_StatusId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_DETAIL_TrainingSessionId",
                table: "TRAINING_ATTENDEE_DETAIL",
                column: "TrainingSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_SESSION_TRAINING_ATTENDEE_TrainingAttendeeId",
                table: "T_TRAINING_SESSION",
                column: "TrainingAttendeeId",
                principalTable: "TRAINING_ATTENDEE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
