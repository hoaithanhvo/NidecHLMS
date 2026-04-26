using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V36 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_REQUIREMENT_TYPE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_REQUIREMENT_TYPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_STEP_REQUIREMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingContentStepId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentFlowId = table.Column<int>(type: "int", nullable: true),
                    RequirementCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequirementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequirementTypeId = table.Column<int>(type: "int", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Placeholder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidationRegex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaxValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxFileSize = table.Column<long>(type: "bigint", nullable: true),
                    IsMultiple = table.Column<bool>(type: "bit", nullable: false),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_STEP_REQUIREMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_STEP_REQUIREMENT_M_REQUIREMENT_TYPE_RequirementTypeId",
                        column: x => x.RequirementTypeId,
                        principalTable: "M_REQUIREMENT_TYPE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_STEP_REQUIREMENT_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                        column: x => x.TrainingContentFlowId,
                        principalTable: "M_TRAINING_CONTENT_FLOW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_STEP_REQUIREMENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                        column: x => x.TrainingContentStepId,
                        principalTable: "M_TRAINING_CONTENT_STEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_REQUIREMENT_TYPE_Code",
                table: "M_REQUIREMENT_TYPE",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_STEP_REQUIREMENT_RequirementTypeId",
                table: "M_STEP_REQUIREMENT",
                column: "RequirementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_M_STEP_REQUIREMENT_TrainingContentFlowId",
                table: "M_STEP_REQUIREMENT",
                column: "TrainingContentFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_M_STEP_REQUIREMENT_TrainingContentStepId",
                table: "M_STEP_REQUIREMENT",
                column: "TrainingContentStepId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_STEP_REQUIREMENT");

            migrationBuilder.DropTable(
                name: "M_REQUIREMENT_TYPE");
        }
    }
}
