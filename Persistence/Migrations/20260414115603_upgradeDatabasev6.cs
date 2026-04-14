using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabasev6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_M_STATUS_M_STATUSId",
                table: "TRAINING_ATTENDEE");

            migrationBuilder.AlterColumn<int>(
                name: "M_STATUSId",
                table: "TRAINING_ATTENDEE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_M_STATUS_M_STATUSId",
                table: "TRAINING_ATTENDEE",
                column: "M_STATUSId",
                principalTable: "M_STATUS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRAINING_ATTENDEE_M_STATUS_M_STATUSId",
                table: "TRAINING_ATTENDEE");

            migrationBuilder.AlterColumn<int>(
                name: "M_STATUSId",
                table: "TRAINING_ATTENDEE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TRAINING_ATTENDEE_M_STATUS_M_STATUSId",
                table: "TRAINING_ATTENDEE",
                column: "M_STATUSId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
