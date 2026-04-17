using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_LifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_LifecycleId",
                table: "M_TRAINING_CONTENT",
                column: "LifecycleId",
                principalTable: "M_TRAINING_CONTENT_LIFECYCLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_CONTENT_FLOW",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_LifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_LifecycleId",
                table: "M_TRAINING_CONTENT",
                column: "LifecycleId",
                principalTable: "M_TRAINING_CONTENT_LIFECYCLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_CONTENT_FLOW",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
