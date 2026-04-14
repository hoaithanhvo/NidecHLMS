using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropForeignKey(
				name: "FK_TRAINING_ATTENDEE_M_STATUS_M_STATUSId",
				table: "TRAINING_ATTENDEE");
			migrationBuilder.DropIndex(
				name: "IX_TRAINING_ATTENDEE_M_STATUSId",
				table: "TRAINING_ATTENDEE");
			migrationBuilder.DropColumn(
				name: "M_STATUSId",
				table: "TRAINING_ATTENDEE");

			migrationBuilder.DropForeignKey(
				name: "FK_TRAINING_ATTENDEE_DETAIL_M_OPERATION_M_OPERATIONId",
				table: "TRAINING_ATTENDEE_DETAIL");
			migrationBuilder.DropIndex(
				name: "IX_TRAINING_ATTENDEE_DETAIL_M_OPERATIONId",
				table: "TRAINING_ATTENDEE_DETAIL");
			migrationBuilder.DropColumn(
				name: "M_OPERATIONId",
				table: "TRAINING_ATTENDEE_DETAIL");

			migrationBuilder.DropForeignKey(
				name: "FK_TRAINING_ATTENDEE_DETAIL_M_SESSION_TYPE_M_SESSION_TYPEId",
				table: "TRAINING_ATTENDEE_DETAIL");
			migrationBuilder.DropIndex(
				name: "IX_TRAINING_ATTENDEE_DETAIL_M_SESSION_TYPEId",
				table: "TRAINING_ATTENDEE_DETAIL");
			migrationBuilder.DropColumn(
				name: "M_SESSION_TYPEId",
				table: "TRAINING_ATTENDEE_DETAIL");

			migrationBuilder.DropForeignKey(
				name: "FK_TRAINING_ATTENDEE_SESSION_TRAINING_ATTENDEE_TRAINING_ATTENDEEId",
				table: "TRAINING_ATTENDEE_SESSION");
			migrationBuilder.DropIndex(
				name: "IX_TRAINING_ATTENDEE_SESSION_TRAINING_ATTENDEEId",
				table: "TRAINING_ATTENDEE_SESSION");
			migrationBuilder.DropColumn(
				name: "TRAINING_ATTENDEEId",
				table: "TRAINING_ATTENDEE_SESSION");

			migrationBuilder.DropForeignKey(
				name: "FK_TRAINING_ATTENDEE_SESSION_TRAINING_ATTENDEE_TRAINING_ATTENDEEId1",
				table: "TRAINING_ATTENDEE_SESSION");
			migrationBuilder.DropIndex(
				name: "IX_TRAINING_ATTENDEE_SESSION_TRAINING_ATTENDEEId1",
				table: "TRAINING_ATTENDEE_SESSION");
			migrationBuilder.DropColumn(
				name: "TRAINING_ATTENDEEId1",
				table: "TRAINING_ATTENDEE_SESSION");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
