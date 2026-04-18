using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropColumn(
                name: "SourceType",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "T_TRAINING_PARTICIPANT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "T_TRAINING_PARTICIPANT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "T_TRAINING_PARTICIPANT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "M_SOURCE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SOURCE", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_PARTICIPANT_SourceId",
                table: "T_TRAINING_PARTICIPANT",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_PARTICIPANT_StatusId",
                table: "T_TRAINING_PARTICIPANT",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_SOURCE_SourceId",
                table: "T_TRAINING_PARTICIPANT",
                column: "SourceId",
                principalTable: "M_SOURCE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_STATUS_StatusId",
                table: "T_TRAINING_PARTICIPANT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_SOURCE_SourceId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_STATUS_StatusId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropTable(
                name: "M_SOURCE");

            migrationBuilder.DropIndex(
                name: "IX_T_TRAINING_PARTICIPANT_SourceId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropIndex(
                name: "IX_T_TRAINING_PARTICIPANT_StatusId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "T_TRAINING_PARTICIPANT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "T_TRAINING_PARTICIPANT",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SourceType",
                table: "T_TRAINING_PARTICIPANT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
