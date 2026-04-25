using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V26 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ActionCode",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "M_WORKFLOW_ACTION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_WORKFLOW_ACTION", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_STEP_TRANSITION_ActionCode",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "ActionCode");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_WORKFLOW_ACTION_ActionCode",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "ActionCode",
                principalTable: "M_WORKFLOW_ACTION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_WORKFLOW_ACTION_ActionCode",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropTable(
                name: "M_WORKFLOW_ACTION");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_STEP_TRANSITION_ActionCode",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.AlterColumn<string>(
                name: "ActionCode",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);
        }
    }
}
