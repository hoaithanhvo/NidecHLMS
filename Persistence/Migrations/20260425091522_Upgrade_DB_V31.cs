using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP_FromStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP_ToStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_STEP",
                table: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_CONTENT_STEP",
                newName: "M_TRAINING_CONTENT_STEP1");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_STEP_StatusId",
                table: "M_TRAINING_CONTENT_STEP1",
                newName: "IX_M_TRAINING_CONTENT_STEP1_StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_STEP1",
                table: "M_TRAINING_CONTENT_STEP1",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP1_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP1_FromStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "FromStepId",
                principalTable: "M_TRAINING_CONTENT_STEP1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP1_ToStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "ToStepId",
                principalTable: "M_TRAINING_CONTENT_STEP1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP1_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP1",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP1_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP1_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP1_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP1_FromStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP1_ToStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP1_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP1");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP1_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP1_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_STEP1",
                table: "M_TRAINING_CONTENT_STEP1");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_CONTENT_STEP1",
                newName: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_STEP1_StatusId",
                table: "M_TRAINING_CONTENT_STEP",
                newName: "IX_M_TRAINING_CONTENT_STEP_StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_STEP",
                table: "M_TRAINING_CONTENT_STEP",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP_FromStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "FromStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP_ToStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "ToStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
