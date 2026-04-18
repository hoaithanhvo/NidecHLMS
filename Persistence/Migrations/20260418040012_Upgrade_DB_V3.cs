using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_M_TRAINING_CONTENT_STEPId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEPId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "M_TRAINING_CONTENT_STEPId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.RenameColumn(
                name: "StepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "CurrentStepId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "CurrentStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "CurrentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.RenameColumn(
                name: "CurrentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "StepId");

            migrationBuilder.AddColumn<int>(
                name: "M_TRAINING_CONTENT_STEPId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEPId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "M_TRAINING_CONTENT_STEPId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_M_TRAINING_CONTENT_STEPId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "M_TRAINING_CONTENT_STEPId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id");
        }
    }
}
