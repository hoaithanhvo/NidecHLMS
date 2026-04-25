using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "M_TRAINING_CONTENT_STEP2");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_STEP1_StatusId",
                table: "M_TRAINING_CONTENT_STEP2",
                newName: "IX_M_TRAINING_CONTENT_STEP2_StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_STEP2",
                table: "M_TRAINING_CONTENT_STEP2",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP2_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP2_FromStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "FromStepId",
                principalTable: "M_TRAINING_CONTENT_STEP2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP2_ToStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION",
                column: "ToStepId",
                principalTable: "M_TRAINING_CONTENT_STEP2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP2_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP2",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP2_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP2_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP2_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP2_FromStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP_TRANSITION_M_TRAINING_CONTENT_STEP2_ToStepId",
                table: "M_TRAINING_CONTENT_STEP_TRANSITION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_STEP2_M_STATUS_StatusId",
                table: "M_TRAINING_CONTENT_STEP2");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_STEP2_TrainingContentStepId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP2_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_STEP2",
                table: "M_TRAINING_CONTENT_STEP2");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_CONTENT_STEP2",
                newName: "M_TRAINING_CONTENT_STEP1");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_STEP2_StatusId",
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
    }
}
