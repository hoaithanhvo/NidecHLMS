using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_table_M_OPERATION : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_SkillTypes_SkillTypesId",
                table: "M_OPERATION");

            migrationBuilder.DropIndex(
                name: "IX_M_OPERATION_SkillTypesId",
                table: "M_OPERATION");

            migrationBuilder.DropColumn(
                name: "SkillTypesId",
                table: "M_OPERATION");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillTypesId",
                table: "M_OPERATION",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_SkillTypesId",
                table: "M_OPERATION",
                column: "SkillTypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_SkillTypes_SkillTypesId",
                table: "M_OPERATION",
                column: "SkillTypesId",
                principalTable: "SkillTypes",
                principalColumn: "Id");
        }
    }
}
