using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_SkillmapTemplates_SkillmapTemplateId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_SkillmapTemplates_TemplateId",
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
                name: "FK_T_SKILLMAP_RESULT_Levels_Rank",
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
                name: "FK_T_TRAINING_PARTICIPANT_M_STATUS_StatusId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_Sources_SourceId",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_TRAINING_RESULT_Levels_LevelId",
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
                name: "FK_T_USER_TAG_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sources",
                table: "Sources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillmapTemplates",
                table: "SkillmapTemplates");

            migrationBuilder.RenameTable(
                name: "Sources",
                newName: "M_SOURCE");

            migrationBuilder.RenameTable(
                name: "SkillmapTemplates",
                newName: "M_SKILLMAP_TEMPLATEs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_SOURCE",
                table: "M_SOURCE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_SKILLMAP_TEMPLATEs",
                table: "M_SKILLMAP_TEMPLATEs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT",
                column: "ActionBy",
                principalTable: "M_USER",
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
                name: "FK_M_OPERATION_M_SKILLMAP_TEMPLATEs_SkillmapTemplateId",
                table: "M_OPERATION",
                column: "SkillmapTemplateId",
                principalTable: "M_SKILLMAP_TEMPLATEs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "CriteriaId",
                principalTable: "M_SKILLMAP_CRITERIA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_TEMPLATEs_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "TemplateId",
                principalTable: "M_SKILLMAP_TEMPLATEs",
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
                name: "FK_T_SKILLMAP_RESULT_Levels_Rank",
                table: "T_SKILLMAP_RESULT",
                column: "Rank",
                principalTable: "Levels",
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
                name: "FK_T_TRAINING_RESULT_Levels_LevelId",
                table: "T_TRAINING_RESULT",
                column: "LevelId",
                principalTable: "Levels",
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
                name: "FK_T_USER_TAG_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TAG",
                column: "ParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TAG",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
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
                name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_SKILLMAP_TEMPLATEs_SkillmapTemplateId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_TEMPLATEs_TemplateId",
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
                name: "FK_T_SKILLMAP_RESULT_Levels_Rank",
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
                name: "FK_T_TRAINING_RESULT_Levels_LevelId",
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
                name: "FK_T_USER_TAG_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_SOURCE",
                table: "M_SOURCE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_SKILLMAP_TEMPLATEs",
                table: "M_SKILLMAP_TEMPLATEs");

            migrationBuilder.RenameTable(
                name: "M_SOURCE",
                newName: "Sources");

            migrationBuilder.RenameTable(
                name: "M_SKILLMAP_TEMPLATEs",
                newName: "SkillmapTemplates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sources",
                table: "Sources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillmapTemplates",
                table: "SkillmapTemplates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LOG_AUDIT_M_USER_ActionBy",
                table: "LOG_AUDIT",
                column: "ActionBy",
                principalTable: "M_USER",
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
                name: "FK_M_OPERATION_SkillmapTemplates_SkillmapTemplateId",
                table: "M_OPERATION",
                column: "SkillmapTemplateId",
                principalTable: "SkillmapTemplates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "CriteriaId",
                principalTable: "M_SKILLMAP_CRITERIA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_SkillmapTemplates_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "TemplateId",
                principalTable: "SkillmapTemplates",
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
                name: "FK_T_SKILLMAP_RESULT_Levels_Rank",
                table: "T_SKILLMAP_RESULT",
                column: "Rank",
                principalTable: "Levels",
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
                name: "FK_T_TRAINING_PARTICIPANT_M_STATUS_StatusId",
                table: "T_TRAINING_PARTICIPANT",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_PARTICIPANT_Sources_SourceId",
                table: "T_TRAINING_PARTICIPANT",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_TRAINING_RESULT_Levels_LevelId",
                table: "T_TRAINING_RESULT",
                column: "LevelId",
                principalTable: "Levels",
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
                name: "FK_T_USER_TAG_T_TRAINING_PARTICIPANT_ParticipantId",
                table: "T_USER_TAG",
                column: "ParticipantId",
                principalTable: "T_TRAINING_PARTICIPANT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_T_USER_TRAINING_ENROLLMENT_UserTrainingEnrollmentId",
                table: "T_USER_TAG",
                column: "UserTrainingEnrollmentId",
                principalTable: "T_USER_TRAINING_ENROLLMENT",
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
