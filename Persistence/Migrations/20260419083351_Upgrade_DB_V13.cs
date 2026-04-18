using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_HANDOVER_RECORD_M_STATUS_StatusId",
                table: "M_HANDOVER_RECORD");

            migrationBuilder.DropForeignKey(
                name: "FK_M_HANDOVER_RECORD_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_HANDOVER_RECORD");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_TEMPLATE_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_LifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_DOCUMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_M_STATUS_StatusId",
                table: "M_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "T_SKILLMAP_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_T_SKILLMAP_RESULT_SkillmapResultId",
                table: "T_SKILLMAP_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_SKILLMAP_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_SOURCE_SourceId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_STATUS_StatusId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_LEVEL_LevelId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_OPERATION_OperationId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_STATUS_StatusId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_USER_UserId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_T_TRAINING_SESSION_SessionId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_SESSION_M_SESSION_TYPE_SessionTypeId",
                table: "T_TRAINING_SESSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_ROLE_M_ROLE_RoleId",
                table: "T_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_ROLE_M_USER_UserId",
                table: "T_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_M_TAG_TagId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_M_USER_UserId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_STATUS_StatusId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropColumn(
                name: "Coefficient",
                table: "M_LEVEL");

            migrationBuilder.DropColumn(
                name: "LevelName",
                table: "M_LEVEL");

            migrationBuilder.AlterColumn<int>(
                name: "Rank",
                table: "T_SKILLMAP_RESULT",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "M_LEVEL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "M_LEVEL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Experienced",
                table: "M_LEVEL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxScore",
                table: "M_LEVEL",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinScore",
                table: "M_LEVEL",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_RESULT_Rank",
                table: "T_SKILLMAP_RESULT",
                column: "Rank");

            migrationBuilder.AddForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT",
                column: "ActionBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_HANDOVER_RECORD_M_STATUS_StatusId",
                table: "M_HANDOVER_RECORD",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_HANDOVER_RECORD_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_HANDOVER_RECORD",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION",
                column: "DepartmentId",
                principalTable: "M_DEPARTMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                table: "M_OPERATION",
                column: "ObjectId",
                principalTable: "M_OBJECT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "CriteriaId",
                principalTable: "M_SKILLMAP_CRITERIA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_TEMPLATE_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "TemplateId",
                principalTable: "M_SKILLMAP_TEMPLATE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_DOCUMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_DOCUMENT",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_USER_M_STATUS_StatusId",
                table: "M_USER",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION",
                column: "PermissionId",
                principalTable: "M_PERMISSION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                table: "T_ROLE_PERMISSION",
                column: "RoleId",
                principalTable: "M_ROLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "T_SKILLMAP_DETAIL",
                column: "CriteriaId",
                principalTable: "M_SKILLMAP_CRITERIA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_T_SKILLMAP_RESULT_SkillmapResultId",
                table: "T_SKILLMAP_DETAIL",
                column: "SkillmapResultId",
                principalTable: "T_SKILLMAP_RESULT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_RESULT_M_LEVEL_Rank",
                table: "T_SKILLMAP_RESULT",
                column: "Rank",
                principalTable: "M_LEVEL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_SKILLMAP_RESULT",
                column: "EnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_TRAINING_FILE",
                column: "TrainingContentFlowStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_TRAINING_FILE",
                column: "TrainingContentFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_TRAINING_FILE",
                column: "EnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_SOURCE_SourceId",
                table: "T_TRAINING_PARTICIPANT",
                column: "SourceId",
                principalTable: "M_SOURCE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_STATUS_StatusId",
                table: "T_TRAINING_PARTICIPANT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_LEVEL_LevelId",
                table: "T_TRAINING_RESULT",
                column: "LevelId",
                principalTable: "M_LEVEL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_OPERATION_OperationId",
                table: "T_TRAINING_RESULT",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_STATUS_StatusId",
                table: "T_TRAINING_RESULT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_USER_UserId",
                table: "T_TRAINING_RESULT",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_T_TRAINING_SESSION_SessionId",
                table: "T_TRAINING_RESULT",
                column: "SessionId",
                principalTable: "T_TRAINING_SESSION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_SESSION_M_SESSION_TYPE_SessionTypeId",
                table: "T_TRAINING_SESSION",
                column: "SessionTypeId",
                principalTable: "M_SESSION_TYPE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_ROLE_M_ROLE_RoleId",
                table: "T_USER_ROLE",
                column: "RoleId",
                principalTable: "M_ROLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_ROLE_M_USER_UserId",
                table: "T_USER_ROLE",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_M_TAG_TagId",
                table: "T_USER_TAG",
                column: "TagId",
                principalTable: "M_TAG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_M_USER_UserId",
                table: "T_USER_TAG",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_STATUS_StatusId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "ParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentFlowStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_HANDOVER_RECORD_M_STATUS_StatusId",
                table: "M_HANDOVER_RECORD");

            migrationBuilder.DropForeignKey(
                name: "FK_M_HANDOVER_RECORD_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_HANDOVER_RECORD");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_TEMPLATE_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_LifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_DOCUMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_M_STATUS_StatusId",
                table: "M_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "T_SKILLMAP_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_T_SKILLMAP_RESULT_SkillmapResultId",
                table: "T_SKILLMAP_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_RESULT_M_LEVEL_Rank",
                table: "T_SKILLMAP_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_SKILLMAP_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_SOURCE_SourceId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_STATUS_StatusId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_LEVEL_LevelId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_OPERATION_OperationId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_STATUS_StatusId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_M_USER_UserId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_T_TRAINING_SESSION_SessionId",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_SESSION_M_SESSION_TYPE_SessionTypeId",
                table: "T_TRAINING_SESSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_ROLE_M_ROLE_RoleId",
                table: "T_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_ROLE_M_USER_UserId",
                table: "T_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_M_TAG_TagId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_M_USER_UserId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_STATUS_StatusId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropIndex(
                name: "IX_T_SKILLMAP_RESULT_Rank",
                table: "T_SKILLMAP_RESULT");

            migrationBuilder.DropColumn(
                name: "Action",
                table: "M_LEVEL");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "M_LEVEL");

            migrationBuilder.DropColumn(
                name: "Experienced",
                table: "M_LEVEL");

            migrationBuilder.DropColumn(
                name: "MaxScore",
                table: "M_LEVEL");

            migrationBuilder.DropColumn(
                name: "MinScore",
                table: "M_LEVEL");

            migrationBuilder.AlterColumn<string>(
                name: "Rank",
                table: "T_SKILLMAP_RESULT",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Coefficient",
                table: "M_LEVEL",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "LevelName",
                table: "M_LEVEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT",
                column: "ActionBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_HANDOVER_RECORD_M_STATUS_StatusId",
                table: "M_HANDOVER_RECORD",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_HANDOVER_RECORD_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_HANDOVER_RECORD",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION",
                column: "DepartmentId",
                principalTable: "M_DEPARTMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                table: "M_OPERATION",
                column: "ObjectId",
                principalTable: "M_OBJECT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "CriteriaId",
                principalTable: "M_SKILLMAP_CRITERIA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_TEMPLATE_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "TemplateId",
                principalTable: "M_SKILLMAP_TEMPLATE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_FLOW_STEP_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_DOCUMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_DOCUMENT",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_USER_M_STATUS_StatusId",
                table: "M_USER",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION",
                column: "PermissionId",
                principalTable: "M_PERMISSION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                table: "T_ROLE_PERMISSION",
                column: "RoleId",
                principalTable: "M_ROLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "T_SKILLMAP_DETAIL",
                column: "CriteriaId",
                principalTable: "M_SKILLMAP_CRITERIA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_T_SKILLMAP_RESULT_SkillmapResultId",
                table: "T_SKILLMAP_DETAIL",
                column: "SkillmapResultId",
                principalTable: "T_SKILLMAP_RESULT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_RESULT_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_SKILLMAP_RESULT",
                column: "EnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_TRAINING_FILE",
                column: "TrainingContentFlowStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_FILE_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_TRAINING_FILE",
                column: "TrainingContentFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_FILE_T_USER_TRAINING_ENROLLMENT_EnrollmentId",
                table: "T_TRAINING_FILE",
                column: "EnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_SOURCE_SourceId",
                table: "T_TRAINING_PARTICIPANT",
                column: "SourceId",
                principalTable: "M_SOURCE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_M_STATUS_StatusId",
                table: "T_TRAINING_PARTICIPANT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_LEVEL_LevelId",
                table: "T_TRAINING_RESULT",
                column: "LevelId",
                principalTable: "M_LEVEL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_OPERATION_OperationId",
                table: "T_TRAINING_RESULT",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_STATUS_StatusId",
                table: "T_TRAINING_RESULT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_M_USER_UserId",
                table: "T_TRAINING_RESULT",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_T_TRAINING_SESSION_SessionId",
                table: "T_TRAINING_RESULT",
                column: "SessionId",
                principalTable: "T_TRAINING_SESSION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_SESSION_M_SESSION_TYPE_SessionTypeId",
                table: "T_TRAINING_SESSION",
                column: "SessionTypeId",
                principalTable: "M_SESSION_TYPE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_ROLE_M_ROLE_RoleId",
                table: "T_USER_ROLE",
                column: "RoleId",
                principalTable: "M_ROLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_ROLE_M_USER_UserId",
                table: "T_USER_ROLE",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_M_TAG_TagId",
                table: "T_USER_TAG",
                column: "TagId",
                principalTable: "M_TAG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_M_USER_UserId",
                table: "T_USER_TAG",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_STATUS_StatusId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_FLOW_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentFlowId",
                principalTable: "M_TRAINING_CONTENT_FLOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_ENROLLMENT_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "ParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentFlowStepId",
                principalTable: "M_TRAINING_CONTENT_FLOW_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
