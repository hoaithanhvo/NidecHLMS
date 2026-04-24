using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "M_TRAINING_CONTENT",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_StatusId",
                table: "M_TRAINING_CONTENT",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_StatusId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "M_TRAINING_CONTENT",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "M_TRAINING_CONTENT",
                type: "bit",
                nullable: true);
        }
    }
}
