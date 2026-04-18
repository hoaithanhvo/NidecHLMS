using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_M_TRAINING_CONTENTId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_TRAINING_ATTENDEE_T_TRAINING_ATTENDEEId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENTId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_T_TRAINING_ATTENDEEId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "M_TRAINING_CONTENTId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "T_TRAINING_ATTENDEEId",
                table: "T_USER_TRAINING_PROGRESS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "M_TRAINING_CONTENTId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "T_TRAINING_ATTENDEEId",
                table: "T_USER_TRAINING_PROGRESS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "M_TRAINING_CONTENT_FLOW_STEPId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENTId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "M_TRAINING_CONTENTId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_T_TRAINING_ATTENDEEId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "T_TRAINING_ATTENDEEId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_STEPId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "M_TRAINING_CONTENT_FLOW_STEPId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_M_TRAINING_CONTENTId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "M_TRAINING_CONTENTId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_TRAINING_ATTENDEE_T_TRAINING_ATTENDEEId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "T_TRAINING_ATTENDEEId",
                principalTable: "T_TRAINING_ATTENDEE",
                principalColumn: "Id");
        }
    }
}
