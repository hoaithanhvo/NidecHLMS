using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Upgrade_DB_V16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_M_SKILLMAP_TEMPLATE_SkillmapTemplateId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_SKILLMAP_TEMPLATE_DETAIL_M_SKILLMAP_TEMPLATE_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TAG_M_LEVEL_M_LEVELId",
                table: "M_TAG");

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
                name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_M_SKILLMAP_CRITERIA_CriteriaId",
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
                name: "FK_T_TRAINING_PARTICIPANT_M_USER_UserId",
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
                name: "PK_T_USER_TRAINING_PROGRESS",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_USER_TRAINING_ENROLLMENT",
                table: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_USER_ROLE",
                table: "T_USER_ROLE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_TRAINING_SESSION",
                table: "T_TRAINING_SESSION");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_TRAINING_RESULT",
                table: "T_TRAINING_RESULT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_TRAINING_PARTICIPANT",
                table: "T_TRAINING_PARTICIPANT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_TRAINING_FILE",
                table: "T_TRAINING_FILE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_ROLE_PERMISSION",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_DOCUMENT",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_TYPE",
                table: "M_TRAINING_CONTENT_TYPE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_STEP",
                table: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_LIFECYCLE",
                table: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_FLOW_STEP",
                table: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_FLOW",
                table: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_TAG",
                table: "M_TAG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_SOURCE",
                table: "M_SOURCE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_SKILLMAP_TEMPLATE_DETAIL",
                table: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_SKILLMAP_TEMPLATE",
                table: "M_SKILLMAP_TEMPLATE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_SKILLMAP_CRITERIA",
                table: "M_SKILLMAP_CRITERIA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_SESSION_TYPE",
                table: "M_SESSION_TYPE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_ROLE",
                table: "M_ROLE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_PERMISSION",
                table: "M_PERMISSION");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M_LEVEL",
                table: "M_LEVEL");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "T_SKILLMAP_DETAIL");

            migrationBuilder.RenameTable(
                name: "T_USER_TRAINING_PROGRESS",
                newName: "TrainingProgresses");

            migrationBuilder.RenameTable(
                name: "T_USER_TRAINING_ENROLLMENT",
                newName: "TrainingEnrollments");

            migrationBuilder.RenameTable(
                name: "T_USER_ROLE",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "T_TRAINING_SESSION",
                newName: "TrainingSessions");

            migrationBuilder.RenameTable(
                name: "T_TRAINING_RESULT",
                newName: "TrainingResults");

            migrationBuilder.RenameTable(
                name: "T_TRAINING_PARTICIPANT",
                newName: "TrainingParticipants");

            migrationBuilder.RenameTable(
                name: "T_TRAINING_FILE",
                newName: "TrainingFiles");

            migrationBuilder.RenameTable(
                name: "T_ROLE_PERMISSION",
                newName: "RolePermissions");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_DOCUMENT",
                newName: "TrainingDocuments");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_CONTENT_TYPE",
                newName: "TrainingContentTypes");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_CONTENT_STEP",
                newName: "TrainingContentSteps");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_CONTENT_LIFECYCLE",
                newName: "TrainingContentLifecycles");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_CONTENT_FLOW_STEP",
                newName: "TrainingContentFlowSteps");

            migrationBuilder.RenameTable(
                name: "M_TRAINING_CONTENT_FLOW",
                newName: "TrainingContentFlows");

            migrationBuilder.RenameTable(
                name: "M_TAG",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "M_SOURCE",
                newName: "Sources");

            migrationBuilder.RenameTable(
                name: "M_SKILLMAP_TEMPLATE_DETAIL",
                newName: "SkillmapTemplateDetails");

            migrationBuilder.RenameTable(
                name: "M_SKILLMAP_TEMPLATE",
                newName: "SkillmapTemplates");

            migrationBuilder.RenameTable(
                name: "M_SKILLMAP_CRITERIA",
                newName: "SkillmapCriterias");

            migrationBuilder.RenameTable(
                name: "M_SESSION_TYPE",
                newName: "SessionTypes");

            migrationBuilder.RenameTable(
                name: "M_ROLE",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "M_PERMISSION",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "M_LEVEL",
                newName: "Levels");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_UserTrainingEnrollmentId",
                table: "TrainingProgresses",
                newName: "IX_TrainingProgresses_UserTrainingEnrollmentId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_TrainingContentFlowStepId",
                table: "TrainingProgresses",
                newName: "IX_TrainingProgresses_TrainingContentFlowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_StatusId",
                table: "TrainingProgresses",
                newName: "IX_TrainingProgresses_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentId",
                table: "TrainingEnrollments",
                newName: "IX_TrainingEnrollments_TrainingContentId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentFlowId",
                table: "TrainingEnrollments",
                newName: "IX_TrainingEnrollments_TrainingContentFlowId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_StatusId",
                table: "TrainingEnrollments",
                newName: "IX_TrainingEnrollments_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_ParticipantId",
                table: "TrainingEnrollments",
                newName: "IX_TrainingEnrollments_ParticipantId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_TRAINING_ENROLLMENT_EnrollmentCode",
                table: "TrainingEnrollments",
                newName: "IX_TrainingEnrollments_EnrollmentCode");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_ROLE_UserId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_T_USER_ROLE_RoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_SESSION_SessionTypeId",
                table: "TrainingSessions",
                newName: "IX_TrainingSessions_SessionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_RESULT_UserId",
                table: "TrainingResults",
                newName: "IX_TrainingResults_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_RESULT_StatusId",
                table: "TrainingResults",
                newName: "IX_TrainingResults_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_RESULT_SessionId",
                table: "TrainingResults",
                newName: "IX_TrainingResults_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_RESULT_OperationId",
                table: "TrainingResults",
                newName: "IX_TrainingResults_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_RESULT_LevelId",
                table: "TrainingResults",
                newName: "IX_TrainingResults_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_PARTICIPANT_UserId",
                table: "TrainingParticipants",
                newName: "IX_TrainingParticipants_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_PARTICIPANT_StatusId",
                table: "TrainingParticipants",
                newName: "IX_TrainingParticipants_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_PARTICIPANT_SourceId",
                table: "TrainingParticipants",
                newName: "IX_TrainingParticipants_SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_PARTICIPANT_Code",
                table: "TrainingParticipants",
                newName: "IX_TrainingParticipants_Code");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_FILE_TrainingContentFlowStepId",
                table: "TrainingFiles",
                newName: "IX_TrainingFiles_TrainingContentFlowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_FILE_TrainingContentFlowId",
                table: "TrainingFiles",
                newName: "IX_TrainingFiles_TrainingContentFlowId");

            migrationBuilder.RenameIndex(
                name: "IX_T_TRAINING_FILE_EnrollmentId",
                table: "TrainingFiles",
                newName: "IX_TrainingFiles_EnrollmentId");

            migrationBuilder.RenameIndex(
                name: "IX_T_ROLE_PERMISSION_RoleId",
                table: "RolePermissions",
                newName: "IX_RolePermissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_T_ROLE_PERMISSION_PermissionId",
                table: "RolePermissions",
                newName: "IX_RolePermissions_PermissionId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_DOCUMENT_TrainingContentId",
                table: "TrainingDocuments",
                newName: "IX_TrainingDocuments_TrainingContentId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentStepId",
                table: "TrainingContentFlowSteps",
                newName: "IX_TrainingContentFlowSteps_TrainingContentStepId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowId_TrainingContentStepId_OrderNo",
                table: "TrainingContentFlowSteps",
                newName: "IX_TrainingContentFlowSteps_TrainingContentFlowId_TrainingContentStepId_OrderNo");

            migrationBuilder.RenameIndex(
                name: "IX_M_TRAINING_CONTENT_FLOW_TrainingContentId",
                table: "TrainingContentFlows",
                newName: "IX_TrainingContentFlows_TrainingContentId");

            migrationBuilder.RenameIndex(
                name: "IX_M_TAG_TagCode",
                table: "Tags",
                newName: "IX_Tags_TagCode");

            migrationBuilder.RenameIndex(
                name: "IX_M_TAG_M_LEVELId",
                table: "Tags",
                newName: "IX_Tags_M_LEVELId");

            migrationBuilder.RenameIndex(
                name: "IX_M_SKILLMAP_TEMPLATE_DETAIL_TemplateId",
                table: "SkillmapTemplateDetails",
                newName: "IX_SkillmapTemplateDetails_TemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_M_SKILLMAP_TEMPLATE_DETAIL_CriteriaId",
                table: "SkillmapTemplateDetails",
                newName: "IX_SkillmapTemplateDetails_CriteriaId");

            migrationBuilder.RenameIndex(
                name: "IX_M_ROLE_RoleCode",
                table: "Roles",
                newName: "IX_Roles_RoleCode");

            migrationBuilder.RenameIndex(
                name: "IX_M_PERMISSION_PermissionCode",
                table: "Permissions",
                newName: "IX_Permissions_PermissionCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingProgresses",
                table: "TrainingProgresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingEnrollments",
                table: "TrainingEnrollments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingSessions",
                table: "TrainingSessions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingResults",
                table: "TrainingResults",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingParticipants",
                table: "TrainingParticipants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingFiles",
                table: "TrainingFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolePermissions",
                table: "RolePermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingDocuments",
                table: "TrainingDocuments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingContentTypes",
                table: "TrainingContentTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingContentSteps",
                table: "TrainingContentSteps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingContentLifecycles",
                table: "TrainingContentLifecycles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingContentFlowSteps",
                table: "TrainingContentFlowSteps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingContentFlows",
                table: "TrainingContentFlows",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sources",
                table: "Sources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillmapTemplateDetails",
                table: "SkillmapTemplateDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillmapTemplates",
                table: "SkillmapTemplates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillmapCriterias",
                table: "SkillmapCriterias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SessionTypes",
                table: "SessionTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Levels",
                table: "Levels",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LOG_AUDIT_EntityName_RecordId",
                table: "LOG_AUDIT",
                columns: new[] { "EntityName", "RecordId" });

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_SkillmapTemplates_SkillmapTemplateId",
                table: "M_OPERATION",
                column: "SkillmapTemplateId",
                principalTable: "SkillmapTemplates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_TrainingContentLifecycles_LifecycleId",
                table: "M_TRAINING_CONTENT",
                column: "LifecycleId",
                principalTable: "TrainingContentLifecycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Roles_RoleId",
                table: "RolePermissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillmapTemplateDetails_SkillmapCriterias_CriteriaId",
                table: "SkillmapTemplateDetails",
                column: "CriteriaId",
                principalTable: "SkillmapCriterias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillmapTemplateDetails_SkillmapTemplates_TemplateId",
                table: "SkillmapTemplateDetails",
                column: "TemplateId",
                principalTable: "SkillmapTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_SkillmapCriterias_CriteriaId",
                table: "T_SKILLMAP_DETAIL",
                column: "CriteriaId",
                principalTable: "SkillmapCriterias",
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
                name: "FK_T_SKILLMAP_RESULT_TrainingEnrollments_EnrollmentId",
                table: "T_SKILLMAP_RESULT",
                column: "EnrollmentId",
                principalTable: "TrainingEnrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_Tags_TagId",
                table: "T_USER_TAG",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_TrainingEnrollments_UserTrainingEnrollmentId",
                table: "T_USER_TAG",
                column: "UserTrainingEnrollmentId",
                principalTable: "TrainingEnrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TAG_TrainingParticipants_ParticipantId",
                table: "T_USER_TAG",
                column: "ParticipantId",
                principalTable: "TrainingParticipants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Levels_M_LEVELId",
                table: "Tags",
                column: "M_LEVELId",
                principalTable: "Levels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingContentFlows_M_TRAINING_CONTENT_TrainingContentId",
                table: "TrainingContentFlows",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingContentFlowSteps_TrainingContentFlows_TrainingContentFlowId",
                table: "TrainingContentFlowSteps",
                column: "TrainingContentFlowId",
                principalTable: "TrainingContentFlows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingContentFlowSteps_TrainingContentSteps_TrainingContentStepId",
                table: "TrainingContentFlowSteps",
                column: "TrainingContentStepId",
                principalTable: "TrainingContentSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingDocuments_M_TRAINING_CONTENT_TrainingContentId",
                table: "TrainingDocuments",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingEnrollments_M_STATUS_StatusId",
                table: "TrainingEnrollments",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingEnrollments_M_TRAINING_CONTENT_TrainingContentId",
                table: "TrainingEnrollments",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingEnrollments_TrainingContentFlows_TrainingContentFlowId",
                table: "TrainingEnrollments",
                column: "TrainingContentFlowId",
                principalTable: "TrainingContentFlows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingEnrollments_TrainingParticipants_ParticipantId",
                table: "TrainingEnrollments",
                column: "ParticipantId",
                principalTable: "TrainingParticipants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingFiles_TrainingContentFlowSteps_TrainingContentFlowStepId",
                table: "TrainingFiles",
                column: "TrainingContentFlowStepId",
                principalTable: "TrainingContentFlowSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingFiles_TrainingContentFlows_TrainingContentFlowId",
                table: "TrainingFiles",
                column: "TrainingContentFlowId",
                principalTable: "TrainingContentFlows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingFiles_TrainingEnrollments_EnrollmentId",
                table: "TrainingFiles",
                column: "EnrollmentId",
                principalTable: "TrainingEnrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingParticipants_M_STATUS_StatusId",
                table: "TrainingParticipants",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingParticipants_M_USER_UserId",
                table: "TrainingParticipants",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingParticipants_Sources_SourceId",
                table: "TrainingParticipants",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingProgresses_M_STATUS_StatusId",
                table: "TrainingProgresses",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingProgresses_TrainingContentFlowSteps_TrainingContentFlowStepId",
                table: "TrainingProgresses",
                column: "TrainingContentFlowStepId",
                principalTable: "TrainingContentFlowSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingProgresses_TrainingEnrollments_UserTrainingEnrollmentId",
                table: "TrainingProgresses",
                column: "UserTrainingEnrollmentId",
                principalTable: "TrainingEnrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingResults_Levels_LevelId",
                table: "TrainingResults",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingResults_M_OPERATION_OperationId",
                table: "TrainingResults",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingResults_M_STATUS_StatusId",
                table: "TrainingResults",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingResults_M_USER_UserId",
                table: "TrainingResults",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingResults_TrainingSessions_SessionId",
                table: "TrainingResults",
                column: "SessionId",
                principalTable: "TrainingSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingSessions_SessionTypes_SessionTypeId",
                table: "TrainingSessions",
                column: "SessionTypeId",
                principalTable: "SessionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_M_USER_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_OPERATION_SkillmapTemplates_SkillmapTemplateId",
                table: "M_OPERATION");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_TrainingContentLifecycles_LifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionId",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Roles_RoleId",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillmapTemplateDetails_SkillmapCriterias_CriteriaId",
                table: "SkillmapTemplateDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillmapTemplateDetails_SkillmapTemplates_TemplateId",
                table: "SkillmapTemplateDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_DETAIL_SkillmapCriterias_CriteriaId",
                table: "T_SKILLMAP_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_RESULT_Levels_Rank",
                table: "T_SKILLMAP_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_RESULT_TrainingEnrollments_EnrollmentId",
                table: "T_SKILLMAP_RESULT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_Tags_TagId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_TrainingEnrollments_UserTrainingEnrollmentId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TAG_TrainingParticipants_ParticipantId",
                table: "T_USER_TAG");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Levels_M_LEVELId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingContentFlows_M_TRAINING_CONTENT_TrainingContentId",
                table: "TrainingContentFlows");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingContentFlowSteps_TrainingContentFlows_TrainingContentFlowId",
                table: "TrainingContentFlowSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingContentFlowSteps_TrainingContentSteps_TrainingContentStepId",
                table: "TrainingContentFlowSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingDocuments_M_TRAINING_CONTENT_TrainingContentId",
                table: "TrainingDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingEnrollments_M_STATUS_StatusId",
                table: "TrainingEnrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingEnrollments_M_TRAINING_CONTENT_TrainingContentId",
                table: "TrainingEnrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingEnrollments_TrainingContentFlows_TrainingContentFlowId",
                table: "TrainingEnrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingEnrollments_TrainingParticipants_ParticipantId",
                table: "TrainingEnrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingFiles_TrainingContentFlowSteps_TrainingContentFlowStepId",
                table: "TrainingFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingFiles_TrainingContentFlows_TrainingContentFlowId",
                table: "TrainingFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingFiles_TrainingEnrollments_EnrollmentId",
                table: "TrainingFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingParticipants_M_STATUS_StatusId",
                table: "TrainingParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingParticipants_M_USER_UserId",
                table: "TrainingParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingParticipants_Sources_SourceId",
                table: "TrainingParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgresses_M_STATUS_StatusId",
                table: "TrainingProgresses");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgresses_TrainingContentFlowSteps_TrainingContentFlowStepId",
                table: "TrainingProgresses");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgresses_TrainingEnrollments_UserTrainingEnrollmentId",
                table: "TrainingProgresses");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingResults_Levels_LevelId",
                table: "TrainingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingResults_M_OPERATION_OperationId",
                table: "TrainingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingResults_M_STATUS_StatusId",
                table: "TrainingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingResults_M_USER_UserId",
                table: "TrainingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingResults_TrainingSessions_SessionId",
                table: "TrainingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingSessions_SessionTypes_SessionTypeId",
                table: "TrainingSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_M_USER_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_LOG_AUDIT_EntityName_RecordId",
                table: "LOG_AUDIT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingSessions",
                table: "TrainingSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingResults",
                table: "TrainingResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingProgresses",
                table: "TrainingProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingParticipants",
                table: "TrainingParticipants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingFiles",
                table: "TrainingFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingEnrollments",
                table: "TrainingEnrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingDocuments",
                table: "TrainingDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingContentTypes",
                table: "TrainingContentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingContentSteps",
                table: "TrainingContentSteps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingContentLifecycles",
                table: "TrainingContentLifecycles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingContentFlowSteps",
                table: "TrainingContentFlowSteps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingContentFlows",
                table: "TrainingContentFlows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sources",
                table: "Sources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillmapTemplates",
                table: "SkillmapTemplates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillmapTemplateDetails",
                table: "SkillmapTemplateDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillmapCriterias",
                table: "SkillmapCriterias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SessionTypes",
                table: "SessionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolePermissions",
                table: "RolePermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Levels",
                table: "Levels");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "T_USER_ROLE");

            migrationBuilder.RenameTable(
                name: "TrainingSessions",
                newName: "T_TRAINING_SESSION");

            migrationBuilder.RenameTable(
                name: "TrainingResults",
                newName: "T_TRAINING_RESULT");

            migrationBuilder.RenameTable(
                name: "TrainingProgresses",
                newName: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.RenameTable(
                name: "TrainingParticipants",
                newName: "T_TRAINING_PARTICIPANT");

            migrationBuilder.RenameTable(
                name: "TrainingFiles",
                newName: "T_TRAINING_FILE");

            migrationBuilder.RenameTable(
                name: "TrainingEnrollments",
                newName: "T_USER_TRAINING_ENROLLMENT");

            migrationBuilder.RenameTable(
                name: "TrainingDocuments",
                newName: "M_TRAINING_DOCUMENT");

            migrationBuilder.RenameTable(
                name: "TrainingContentTypes",
                newName: "M_TRAINING_CONTENT_TYPE");

            migrationBuilder.RenameTable(
                name: "TrainingContentSteps",
                newName: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.RenameTable(
                name: "TrainingContentLifecycles",
                newName: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.RenameTable(
                name: "TrainingContentFlowSteps",
                newName: "M_TRAINING_CONTENT_FLOW_STEP");

            migrationBuilder.RenameTable(
                name: "TrainingContentFlows",
                newName: "M_TRAINING_CONTENT_FLOW");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "M_TAG");

            migrationBuilder.RenameTable(
                name: "Sources",
                newName: "M_SOURCE");

            migrationBuilder.RenameTable(
                name: "SkillmapTemplates",
                newName: "M_SKILLMAP_TEMPLATE");

            migrationBuilder.RenameTable(
                name: "SkillmapTemplateDetails",
                newName: "M_SKILLMAP_TEMPLATE_DETAIL");

            migrationBuilder.RenameTable(
                name: "SkillmapCriterias",
                newName: "M_SKILLMAP_CRITERIA");

            migrationBuilder.RenameTable(
                name: "SessionTypes",
                newName: "M_SESSION_TYPE");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "M_ROLE");

            migrationBuilder.RenameTable(
                name: "RolePermissions",
                newName: "T_ROLE_PERMISSION");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "M_PERMISSION");

            migrationBuilder.RenameTable(
                name: "Levels",
                newName: "M_LEVEL");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "T_USER_ROLE",
                newName: "IX_T_USER_ROLE_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "T_USER_ROLE",
                newName: "IX_T_USER_ROLE_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingSessions_SessionTypeId",
                table: "T_TRAINING_SESSION",
                newName: "IX_T_TRAINING_SESSION_SessionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingResults_UserId",
                table: "T_TRAINING_RESULT",
                newName: "IX_T_TRAINING_RESULT_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingResults_StatusId",
                table: "T_TRAINING_RESULT",
                newName: "IX_T_TRAINING_RESULT_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingResults_SessionId",
                table: "T_TRAINING_RESULT",
                newName: "IX_T_TRAINING_RESULT_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingResults_OperationId",
                table: "T_TRAINING_RESULT",
                newName: "IX_T_TRAINING_RESULT_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingResults_LevelId",
                table: "T_TRAINING_RESULT",
                newName: "IX_T_TRAINING_RESULT_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingProgresses_UserTrainingEnrollmentId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "IX_T_USER_TRAINING_PROGRESS_UserTrainingEnrollmentId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingProgresses_TrainingContentFlowStepId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "IX_T_USER_TRAINING_PROGRESS_TrainingContentFlowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingProgresses_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                newName: "IX_T_USER_TRAINING_PROGRESS_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingParticipants_UserId",
                table: "T_TRAINING_PARTICIPANT",
                newName: "IX_T_TRAINING_PARTICIPANT_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingParticipants_StatusId",
                table: "T_TRAINING_PARTICIPANT",
                newName: "IX_T_TRAINING_PARTICIPANT_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingParticipants_SourceId",
                table: "T_TRAINING_PARTICIPANT",
                newName: "IX_T_TRAINING_PARTICIPANT_SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingParticipants_Code",
                table: "T_TRAINING_PARTICIPANT",
                newName: "IX_T_TRAINING_PARTICIPANT_Code");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingFiles_TrainingContentFlowStepId",
                table: "T_TRAINING_FILE",
                newName: "IX_T_TRAINING_FILE_TrainingContentFlowStepId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingFiles_TrainingContentFlowId",
                table: "T_TRAINING_FILE",
                newName: "IX_T_TRAINING_FILE_TrainingContentFlowId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingFiles_EnrollmentId",
                table: "T_TRAINING_FILE",
                newName: "IX_T_TRAINING_FILE_EnrollmentId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingEnrollments_TrainingContentId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingEnrollments_TrainingContentFlowId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_TrainingContentFlowId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingEnrollments_StatusId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingEnrollments_ParticipantId",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_ParticipantId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingEnrollments_EnrollmentCode",
                table: "T_USER_TRAINING_ENROLLMENT",
                newName: "IX_T_USER_TRAINING_ENROLLMENT_EnrollmentCode");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingDocuments_TrainingContentId",
                table: "M_TRAINING_DOCUMENT",
                newName: "IX_M_TRAINING_DOCUMENT_TrainingContentId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingContentFlowSteps_TrainingContentStepId",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                newName: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentStepId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingContentFlowSteps_TrainingContentFlowId_TrainingContentStepId_OrderNo",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                newName: "IX_M_TRAINING_CONTENT_FLOW_STEP_TrainingContentFlowId_TrainingContentStepId_OrderNo");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingContentFlows_TrainingContentId",
                table: "M_TRAINING_CONTENT_FLOW",
                newName: "IX_M_TRAINING_CONTENT_FLOW_TrainingContentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_TagCode",
                table: "M_TAG",
                newName: "IX_M_TAG_TagCode");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_M_LEVELId",
                table: "M_TAG",
                newName: "IX_M_TAG_M_LEVELId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillmapTemplateDetails_TemplateId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                newName: "IX_M_SKILLMAP_TEMPLATE_DETAIL_TemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillmapTemplateDetails_CriteriaId",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                newName: "IX_M_SKILLMAP_TEMPLATE_DETAIL_CriteriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_RoleCode",
                table: "M_ROLE",
                newName: "IX_M_ROLE_RoleCode");

            migrationBuilder.RenameIndex(
                name: "IX_RolePermissions_RoleId",
                table: "T_ROLE_PERMISSION",
                newName: "IX_T_ROLE_PERMISSION_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "T_ROLE_PERMISSION",
                newName: "IX_T_ROLE_PERMISSION_PermissionId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_PermissionCode",
                table: "M_PERMISSION",
                newName: "IX_M_PERMISSION_PermissionCode");

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "T_SKILLMAP_DETAIL",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_USER_ROLE",
                table: "T_USER_ROLE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_TRAINING_SESSION",
                table: "T_TRAINING_SESSION",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_TRAINING_RESULT",
                table: "T_TRAINING_RESULT",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_USER_TRAINING_PROGRESS",
                table: "T_USER_TRAINING_PROGRESS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_TRAINING_PARTICIPANT",
                table: "T_TRAINING_PARTICIPANT",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_TRAINING_FILE",
                table: "T_TRAINING_FILE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_USER_TRAINING_ENROLLMENT",
                table: "T_USER_TRAINING_ENROLLMENT",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_DOCUMENT",
                table: "M_TRAINING_DOCUMENT",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_TYPE",
                table: "M_TRAINING_CONTENT_TYPE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_STEP",
                table: "M_TRAINING_CONTENT_STEP",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_LIFECYCLE",
                table: "M_TRAINING_CONTENT_LIFECYCLE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_FLOW_STEP",
                table: "M_TRAINING_CONTENT_FLOW_STEP",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TRAINING_CONTENT_FLOW",
                table: "M_TRAINING_CONTENT_FLOW",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_TAG",
                table: "M_TAG",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_SOURCE",
                table: "M_SOURCE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_SKILLMAP_TEMPLATE",
                table: "M_SKILLMAP_TEMPLATE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_SKILLMAP_TEMPLATE_DETAIL",
                table: "M_SKILLMAP_TEMPLATE_DETAIL",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_SKILLMAP_CRITERIA",
                table: "M_SKILLMAP_CRITERIA",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_SESSION_TYPE",
                table: "M_SESSION_TYPE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_ROLE",
                table: "M_ROLE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_ROLE_PERMISSION",
                table: "T_ROLE_PERMISSION",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_PERMISSION",
                table: "M_PERMISSION",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M_LEVEL",
                table: "M_LEVEL",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_M_OPERATION_M_SKILLMAP_TEMPLATE_SkillmapTemplateId",
                table: "M_OPERATION",
                column: "SkillmapTemplateId",
                principalTable: "M_SKILLMAP_TEMPLATE",
                principalColumn: "Id");

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
                name: "FK_M_TAG_M_LEVEL_M_LEVELId",
                table: "M_TAG",
                column: "M_LEVELId",
                principalTable: "M_LEVEL",
                principalColumn: "Id");

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
                name: "FK_T_TRAINING_PARTICIPANT_M_USER_UserId",
                table: "T_TRAINING_PARTICIPANT",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id");

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
