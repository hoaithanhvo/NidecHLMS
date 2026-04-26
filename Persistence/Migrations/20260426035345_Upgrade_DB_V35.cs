using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionDate",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActionDate",
                table: "T_USER_TRAINING_PROGRESS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "T_USER_TRAINING_PROGRESS",
                type: "datetime2",
                nullable: true);
        }
    }
}
