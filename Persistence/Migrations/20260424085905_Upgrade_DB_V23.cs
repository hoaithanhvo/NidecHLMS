using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT");

            migrationBuilder.RenameColumn(
                name: "ActionBy",
                table: "LOG_AUDIT",
                newName: "UserAction");

            migrationBuilder.RenameIndex(
                name: "IX_LOG_AUDIT_ActionBy",
                table: "LOG_AUDIT",
                newName: "IX_LOG_AUDIT_UserAction");

            migrationBuilder.AddForeignKey(
                name: "FK_LOG_AUDIT_M_USER_UserAction",
                table: "LOG_AUDIT",
                column: "UserAction",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LOG_AUDIT_M_USER_UserAction",
                table: "LOG_AUDIT");

            migrationBuilder.RenameColumn(
                name: "UserAction",
                table: "LOG_AUDIT",
                newName: "ActionBy");

            migrationBuilder.RenameIndex(
                name: "IX_LOG_AUDIT_UserAction",
                table: "LOG_AUDIT",
                newName: "IX_LOG_AUDIT_ActionBy");

            migrationBuilder.AddForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT",
                column: "ActionBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
