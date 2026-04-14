using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TRAINING_ATTENDEE",
                type: "int",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_TRAINING_ATTENDEE_UserId",
                table: "TRAINING_ATTENDEE",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_M_USER_UserId",
                table: "TRAINING_ATTENDEE",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_M_USER_UserId",
                table: "TRAINING_ATTENDEE");

            migrationBuilder.DropIndex(
                name: "IX_TRAINING_ATTENDEE_UserId",
                table: "TRAINING_ATTENDEE");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TRAINING_ATTENDEE");
        }
    }
}
