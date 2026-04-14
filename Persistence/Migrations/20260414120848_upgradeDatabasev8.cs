using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropForeignKey(
name: "FK_TRAINING_ATTENDEE_DETAIL_M_LEVEL_M_LEVELId",
table: "TRAINING_ATTENDEE_DETAIL");

			migrationBuilder.DropIndex(
				name: "IX_TRAINING_ATTENDEE_DETAIL_M_LEVELId",
				table: "TRAINING_ATTENDEE_DETAIL");

			migrationBuilder.DropColumn(
				name: "M_LEVELId",
				table: "TRAINING_ATTENDEE_DETAIL");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
