using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.AddColumn<int>(
                name: "TrainingContentStepFlowId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "M_TRAINING_CONTENT_FLOW",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "M_TRAINING_CONTENT_FLOW",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "M_TRAINING_CONTENT_FLOW",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "M_TRAINING_CONTENT_FLOW",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_TrainingContentStepFlowId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepFlowId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentStepFlowId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentStepFlowId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_TrainingContentStepFlowId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "TrainingContentStepFlowId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "M_TRAINING_CONTENT_FLOW",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "M_TRAINING_CONTENT_FLOW",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "M_TRAINING_CONTENT_FLOW",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "M_TRAINING_CONTENT_FLOW",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
