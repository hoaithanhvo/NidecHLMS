using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V27 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_SKILLMAP_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropTable(
                name: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "M_TRAINING_CONTENT",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.CreateTable(
                name: "T_USER_TRAINING_ENROLLMENT2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    EnrollmentCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentFlowId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentFlowStepId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentStepId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CompleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgressPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_TRAINING_ENROLLMENT2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT2_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT2_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                        column: x => x.TrainingContentFlowStepId,
                        principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT2_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                        column: x => x.TrainingContentFlowId,
                        principalTable: "M_TRAINING_CONTENT_FLOW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT2_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                        column: x => x.TrainingContentStepId,
                        principalTable: "M_TRAINING_CONTENT_STEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT2_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT2_T_TRAINING_PARTICIPANT_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "T_TRAINING_PARTICIPANT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT2_EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT2",
                column: "EnrollmentCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT2_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT2",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT2_StatusId",
                table: "T_USER_TRAINING_ENROLLMENT2",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT2_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT2",
                column: "TrainingContentFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT2_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_ENROLLMENT2",
                column: "TrainingContentFlowStepId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT2_TrainingContentId",
                table: "T_USER_TRAINING_ENROLLMENT2",
                column: "TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT2_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT2",
                column: "TrainingContentStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT2_EnrollmentId",
                table: "T_SKILLMAP_RESULT",
                column: "EnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT2_EnrollmentId",
                table: "T_TRAINING_FILE",
                column: "EnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT2_UserTrainingEnrollmentId",
                table: "T_USER_TAG",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT2_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT2_EnrollmentId",
                table: "T_SKILLMAP_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT2_EnrollmentId",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT2_UserTrainingEnrollmentId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT2_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropTable(
                name: "T_USER_TRAINING_ENROLLMENT2");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "M_TRAINING_CONTENT",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "T_USER_TRAINING_ENROLLMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentFlowId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentStepId = table.Column<int>(type: "int", nullable: false),
                    CompleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnrollmentCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProgressPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_TRAINING_ENROLLMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                        column: x => x.TrainingContentFlowId,
                        principalTable: "M_TRAINING_CONTENT_FLOW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                        column: x => x.TrainingContentStepId,
                        principalTable: "M_TRAINING_CONTENT_STEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "T_TRAINING_PARTICIPANT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "EnrollmentCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_StatusId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_SKILLMAP_RESULT",
                column: "EnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_TRAINING_FILE",
                column: "EnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TAG",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
