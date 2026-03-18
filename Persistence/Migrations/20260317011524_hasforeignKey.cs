using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class hasforeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainingResultId",
                table: "Certificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_TrainingResultId",
                table: "Certificates",
                column: "TrainingResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_TrainingResults_TrainingResultId",
                table: "Certificates",
                column: "TrainingResultId",
                principalTable: "TrainingResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_TrainingResults_TrainingResultId",
                table: "Certificates");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_TrainingResultId",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "TrainingResultId",
                table: "Certificates");
        }
    }
}
