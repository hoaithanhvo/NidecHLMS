using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LEARNING_REPORT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "LEARNING_REPORT");

            migrationBuilder.DropForeignKey(
                name: "FK_LEARNING_REPORT_M_USER_UserId",
                table: "LEARNING_REPORT");

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
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_TYPE_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_DOCUMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_M_DEPARTMENT_DepartmentId",
                table: "M_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_M_STATUS_StatusId",
                table: "M_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "T_ASSESSMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ASSESSMENT_M_USER_ApprovalBy",
                table: "T_ASSESSMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_COURSE_CONTENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_COURSE_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_COURSE_CONTENT_T_TRAINING_COURSE_CourseId",
                table: "T_COURSE_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_M_USER_ApproveBy",
                table: "T_SKILLMAP");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_T_ASSESSMENT_AssessmentId",
                table: "T_SKILLMAP");

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
                name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
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
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_USER_UserId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_USER_TRAINING_PROGRESS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_USER_TRAINING_PROGRESS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_TRAINING_SESSION",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_TRAINING_SESSION",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_TRAINING_RESULT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_TRAINING_RESULT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_TRAINING_ATTENDEE",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_TRAINING_ATTENDEE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_SKILLMAP",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_SKILLMAP",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_ASSESSMENT_RESULT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_ASSESSMENT_RESULT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_ASSESSMENT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_ASSESSMENT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "M_USER",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "M_USER",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "M_TRAINING_DOCUMENT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "M_TRAINING_DOCUMENT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "M_TRAINING_CONTENT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "M_TRAINING_CONTENT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "LEARNING_REPORT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "LEARNING_REPORT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_LEARNING_REPORT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "LEARNING_REPORT",
                column: "TrainingDocumentId",
                principalTable: "M_TRAINING_DOCUMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LEARNING_REPORT_M_USER_UserId",
                table: "LEARNING_REPORT",
                column: "UserId",
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
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentLifecycleId",
                principalTable: "M_TRAINING_CONTENT_LIFECYCLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_TYPE_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentTypeId",
                principalTable: "M_TRAINING_CONTENT_TYPE",
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
                name: "FK_M_USER_M_DEPARTMENT_DepartmentId",
                table: "M_USER",
                column: "DepartmentId",
                principalTable: "M_DEPARTMENT",
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
                name: "FK_T_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "T_ASSESSMENT",
                column: "TrainingDocumentId",
                principalTable: "M_TRAINING_DOCUMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ASSESSMENT_M_USER_ApprovalBy",
                table: "T_ASSESSMENT",
                column: "ApprovalBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_COURSE_CONTENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_COURSE_CONTENT",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_COURSE_CONTENT_T_TRAINING_COURSE_CourseId",
                table: "T_COURSE_CONTENT",
                column: "CourseId",
                principalTable: "T_TRAINING_COURSE",
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
                name: "FK_T_SKILLMAP_M_USER_ApproveBy",
                table: "T_SKILLMAP",
                column: "ApproveBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_T_ASSESSMENT_AssessmentId",
                table: "T_SKILLMAP",
                column: "AssessmentId",
                principalTable: "T_ASSESSMENT",
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
                name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
                table: "T_TRAINING_SESSION",
                column: "TrainingAttendeeId",
                principalTable: "T_TRAINING_ATTENDEE",
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
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_USER_UserId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LEARNING_REPORT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "LEARNING_REPORT");

            migrationBuilder.DropForeignKey(
                name: "FK_LEARNING_REPORT_M_USER_UserId",
                table: "LEARNING_REPORT");

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
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_TYPE_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_TRAINING_DOCUMENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_M_DEPARTMENT_DepartmentId",
                table: "M_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_M_USER_M_STATUS_StatusId",
                table: "M_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "T_ASSESSMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ASSESSMENT_M_USER_ApprovalBy",
                table: "T_ASSESSMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_COURSE_CONTENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_COURSE_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_COURSE_CONTENT_T_TRAINING_COURSE_CourseId",
                table: "T_COURSE_CONTENT");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                table: "T_ROLE_PERMISSION");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_M_USER_ApproveBy",
                table: "T_SKILLMAP");

            migrationBuilder.DropForeignKey(
                name: "FK_T_SKILLMAP_T_ASSESSMENT_AssessmentId",
                table: "T_SKILLMAP");

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
                name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
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
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_USER_UserId",
                table: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_USER_TRAINING_PROGRESS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_USER_TRAINING_PROGRESS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_TRAINING_SESSION",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_TRAINING_SESSION",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_TRAINING_RESULT",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_TRAINING_RESULT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_TRAINING_ATTENDEE",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_TRAINING_ATTENDEE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_SKILLMAP",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_SKILLMAP",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_ASSESSMENT_RESULT",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_ASSESSMENT_RESULT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "T_ASSESSMENT",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "T_ASSESSMENT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "M_USER",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "M_USER",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "M_TRAINING_DOCUMENT",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "M_TRAINING_DOCUMENT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "M_TRAINING_CONTENT",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "M_TRAINING_CONTENT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "LEARNING_REPORT",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "LEARNING_REPORT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LEARNING_REPORT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "LEARNING_REPORT",
                column: "TrainingDocumentId",
                principalTable: "M_TRAINING_DOCUMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LEARNING_REPORT_M_USER_UserId",
                table: "LEARNING_REPORT",
                column: "UserId",
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
                name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                table: "M_TRAINING_CONTENT",
                column: "OperationId",
                principalTable: "M_OPERATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentLifecycleId",
                principalTable: "M_TRAINING_CONTENT_LIFECYCLE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_TYPE_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentTypeId",
                principalTable: "M_TRAINING_CONTENT_TYPE",
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
                name: "FK_M_USER_M_DEPARTMENT_DepartmentId",
                table: "M_USER",
                column: "DepartmentId",
                principalTable: "M_DEPARTMENT",
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
                name: "FK_T_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                table: "T_ASSESSMENT",
                column: "TrainingDocumentId",
                principalTable: "M_TRAINING_DOCUMENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ASSESSMENT_M_USER_ApprovalBy",
                table: "T_ASSESSMENT",
                column: "ApprovalBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_COURSE_CONTENT_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_COURSE_CONTENT",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_COURSE_CONTENT_T_TRAINING_COURSE_CourseId",
                table: "T_COURSE_CONTENT",
                column: "CourseId",
                principalTable: "T_TRAINING_COURSE",
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
                name: "FK_T_SKILLMAP_M_USER_ApproveBy",
                table: "T_SKILLMAP",
                column: "ApproveBy",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_SKILLMAP_T_ASSESSMENT_AssessmentId",
                table: "T_SKILLMAP",
                column: "AssessmentId",
                principalTable: "T_ASSESSMENT",
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
                name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
                table: "T_TRAINING_SESSION",
                column: "TrainingAttendeeId",
                principalTable: "T_TRAINING_ATTENDEE",
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
                name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId",
                principalTable: "M_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepId",
                principalTable: "M_TRAINING_CONTENT_STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_TrainingContentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentId",
                principalTable: "M_TRAINING_CONTENT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TRAINING_PROGRESS_M_USER_UserId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserId",
                principalTable: "M_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
