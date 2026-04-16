using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_TYPE_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentStepId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "TrainingContentStepId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropColumn(
                name: "TrainingContentTypeId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.CreateTable(
                name: "M_TRAINING_CONTENT_FLOW",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_CONTENT_FLOW", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_TRAINING_CONTENT_FLOW_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_TRAINING_CONTENT_FLOW_STEP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingContentFlowId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentStepId = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    DurationDays = table.Column<int>(type: "int", nullable: true),
                    TrainingContentStepId1 = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_CONTENT_FLOW_STEP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentStepId",
                        column: x => x.TrainingContentStepId,
                        principalTable: "M_TRAINING_CONTENT_FLOW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId1",
                        column: x => x.TrainingContentStepId1,
                        principalTable: "M_TRAINING_CONTENT_STEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_TrainingContentId",
                table: "M_TRAINING_CONTENT_FLOW",
                column: "TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentStepId1",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropTable(
                name: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.AddColumn<int>(
                name: "TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingContentTypeId",
                table: "M_TRAINING_CONTENT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentStepId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_TYPE_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentTypeId",
                principalTable: "M_TRAINING_CONTENT_TYPE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
