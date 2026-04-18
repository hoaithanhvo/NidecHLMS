using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_AUDIT_LOG_M_USER_ActionBy",
                table: "T_AUDIT_LOG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_AUDIT_LOG",
                table: "T_AUDIT_LOG");

            migrationBuilder.RenameTable(
                name: "T_AUDIT_LOG",
                newName: "LOG_AUDIT");

            migrationBuilder.RenameIndex(
                name: "IX_T_AUDIT_LOG_ActionBy",
                table: "LOG_AUDIT",
                newName: "IX_LOG_AUDIT_ActionBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LOG_AUDIT",
                table: "LOG_AUDIT",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT",
                column: "ActionBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LOG_AUDIT",
                table: "LOG_AUDIT");

            migrationBuilder.RenameTable(
                name: "LOG_AUDIT",
                newName: "T_AUDIT_LOG");

            migrationBuilder.RenameIndex(
                name: "IX_LOG_AUDIT_ActionBy",
                table: "T_AUDIT_LOG",
                newName: "IX_T_AUDIT_LOG_ActionBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_AUDIT_LOG",
                table: "T_AUDIT_LOG",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_AUDIT_LOG_M_USER_ActionBy",
                table: "T_AUDIT_LOG",
                column: "ActionBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
