using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProductDepartment",
                table: "M_USER");

            migrationBuilder.DropColumn(
                name: "IsQa_Department",
                table: "M_USER");

            migrationBuilder.DropColumn(
                name: "IsTrainingCenter",
                table: "M_USER");

            migrationBuilder.CreateTable(
                name: "M_PERMISSION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PERMISSION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_ROLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ROLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_ROLE_PERMISSION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ROLE_PERMISSION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "M_PERMISSION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                        column: x => x.RoleId,
                        principalTable: "M_ROLE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_ROLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_ROLE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_USER_ROLE_M_ROLE_RoleId",
                        column: x => x.RoleId,
                        principalTable: "M_ROLE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_USER_ROLE_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ROLE_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ROLE_PERMISSION_RoleId",
                table: "T_ROLE_PERMISSION",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_ROLE_RoleId",
                table: "T_USER_ROLE",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_ROLE_UserId",
                table: "T_USER_ROLE",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_ROLE_PERMISSION");

            migrationBuilder.DropTable(
                name: "T_USER_ROLE");

            migrationBuilder.DropTable(
                name: "M_PERMISSION");

            migrationBuilder.DropTable(
                name: "M_ROLE");

            migrationBuilder.AddColumn<bool>(
                name: "IsProductDepartment",
                table: "M_USER",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsQa_Department",
                table: "M_USER",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsTrainingCenter",
                table: "M_USER",
                type: "bit",
                nullable: true);
        }
    }
}
