using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_M_USER_UserId",
                table: "T_USER_TAG");

            migrationBuilder.DropTable(
                name: "M_HANDOVER_RECORD");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "T_USER_TAG",
                newName: "UserTrainingEnrollmentId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TAG_UserId",
                table: "T_USER_TAG",
                newName: "IX_T_USER_TAG_UserTrainingEnrollmentId");

            migrationBuilder.AddColumn<int>(
                name: "ParticipantId",
                table: "T_USER_TAG",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TAG_ParticipantId",
                table: "T_USER_TAG",
                column: "ParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TAG",
                column: "ParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TAG",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TAG");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TAG_ParticipantId",
                table: "T_USER_TAG");

            migrationBuilder.DropColumn(
                name: "ParticipantId",
                table: "T_USER_TAG");

            migrationBuilder.RenameColumn(
                name: "UserTrainingEnrollmentId",
                table: "T_USER_TAG",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TAG_UserTrainingEnrollmentId",
                table: "T_USER_TAG",
                newName: "IX_T_USER_TAG_UserId");

            migrationBuilder.CreateTable(
                name: "M_HANDOVER_RECORD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransferDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_HANDOVER_RECORD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_HANDOVER_RECORD_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_HANDOVER_RECORD_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_HANDOVER_RECORD_StatusId",
                table: "M_HANDOVER_RECORD",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_M_HANDOVER_RECORD_TrainingContentId",
                table: "M_HANDOVER_RECORD",
                column: "TrainingContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_M_USER_UserId",
                table: "T_USER_TAG",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
