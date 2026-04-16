using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FrequencyUnit",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.DropColumn(
                name: "FrequencyUnit",
                table: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
