using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT",
                newName: "LifecycleId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_LifecycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_LifecycleId",
                table: "M_TRAINING_CONTENT",
                column: "LifecycleId",
                principalTable: "M_TRAINING_CONTENT_LIFECYCLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_LifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.RenameColumn(
                name: "LifecycleId",
                table: "M_TRAINING_CONTENT",
                newName: "TrainingContentLifecycleId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_LifecycleId",
                table: "M_TRAINING_CONTENT",
                newName: "IX_M_TRAINING_CONTENT_TrainingContentLifecycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentLifecycleId",
                principalTable: "M_TRAINING_CONTENT_LIFECYCLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
