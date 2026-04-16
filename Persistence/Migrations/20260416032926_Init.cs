using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_DEPARTMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Section = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DEPARTMENT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_DIVISION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionCd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DivisionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DIVISION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_LEVEL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coefficient = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_LEVEL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_OBJECT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OBJECT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_PERMISSION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PERMISSION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_ROLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ROLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_SESSION_TYPE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionNameVI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SessionNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SessionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SESSION_TYPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_SKILLMAP_LEVEL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationDetailId = table.Column<int>(type: "int", nullable: false),
                    Standard = table.Column<int>(type: "int", nullable: false),
                    EvaluationCategoryEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluationCategoryVI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coefficient = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SKILLMAP_LEVEL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_STATUS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edit = table.Column<bool>(type: "bit", nullable: false),
                    Execute = table.Column<bool>(type: "bit", nullable: false),
                    View = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_STATUS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_TRAINING_CONTENT_LIFECYCLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRenew = table.Column<bool>(type: "bit", nullable: false),
                    RetrainingFrequency = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_CONTENT_LIFECYCLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_TRAINING_CONTENT_STEP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_CONTENT_STEP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_TRAINING_CONTENT_TYPE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentTypeNameVI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContentTypeNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_CONTENT_TYPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_TRAINING_COURSE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TRAINING_COURSE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_TAG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    M_LEVELId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TAG", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_TAG_M_LEVEL_M_LEVELId",
                        column: x => x.M_LEVELId,
                        principalTable: "M_LEVEL",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "M_OPERATION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OperationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    ObjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_OPERATION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_OPERATION_M_DEPARTMENT_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "M_DEPARTMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_OPERATION_M_OBJECT_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "M_OBJECT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ROLE_PERMISSION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ROLE_PERMISSION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ROLE_PERMISSION_M_PERMISSION_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "M_PERMISSION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ROLE_PERMISSION_M_ROLE_RoleId",
                        column: x => x.RoleId,
                        principalTable: "M_ROLE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "M_USER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdmUserId = table.Column<int>(type: "int", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_USER", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_USER_M_DEPARTMENT_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "M_DEPARTMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_USER_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "M_TRAINING_CONTENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagementNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrainingContentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrainingContentStepId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentTypeId = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentLifecycleId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_CONTENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_TRAINING_CONTENT_M_OPERATION_OperationId",
                        column: x => x.OperationId,
                        principalTable: "M_OPERATION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_LIFECYCLE_TrainingContentLifecycleId",
                        column: x => x.TrainingContentLifecycleId,
                        principalTable: "M_TRAINING_CONTENT_LIFECYCLE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                        column: x => x.TrainingContentStepId,
                        principalTable: "M_TRAINING_CONTENT_STEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_TRAINING_CONTENT_M_TRAINING_CONTENT_TYPE_TrainingContentTypeId",
                        column: x => x.TrainingContentTypeId,
                        principalTable: "M_TRAINING_CONTENT_TYPE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_TRAINING_ATTENDEE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TrainingCourseId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TRAINING_ATTENDEE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_ATTENDEE_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_TRAINING_ATTENDEE_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_TRAINING_ATTENDEE_T_TRAINING_COURSE_TrainingCourseId",
                        column: x => x.TrainingCourseId,
                        principalTable: "T_TRAINING_COURSE",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "T_USER_ROLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_ROLE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_USER_ROLE_M_ROLE_RoleId",
                        column: x => x.RoleId,
                        principalTable: "M_ROLE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_ROLE_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_TAG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    AchievedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_TAG", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_USER_TAG_M_TAG_TagId",
                        column: x => x.TagId,
                        principalTable: "M_TAG",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TAG_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "M_HANDOVER_RECORD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransferDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_HANDOVER_RECORD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_HANDOVER_RECORD_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M_HANDOVER_RECORD_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "M_TRAINING_DOCUMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TRAINING_DOCUMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_TRAINING_DOCUMENT_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_COURSE_CONTENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_COURSE_CONTENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_COURSE_CONTENT_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_COURSE_CONTENT_T_TRAINING_COURSE_CourseId",
                        column: x => x.CourseId,
                        principalTable: "T_TRAINING_COURSE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_TRAINING_PROGRESS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentId = table.Column<int>(type: "int", nullable: false),
                    TrainingContentStepId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CompleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_TRAINING_PROGRESS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_PROGRESS_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_STEP_TrainingContentStepId",
                        column: x => x.TrainingContentStepId,
                        principalTable: "M_TRAINING_CONTENT_STEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_PROGRESS_M_TRAINING_CONTENT_TrainingContentId",
                        column: x => x.TrainingContentId,
                        principalTable: "M_TRAINING_CONTENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_USER_TRAINING_PROGRESS_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_TRAINING_SESSION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionTypeId = table.Column<int>(type: "int", nullable: false),
                    TrainingAttendeeId = table.Column<int>(type: "int", nullable: false),
                    TrainingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TRAINING_SESSION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_SESSION_M_SESSION_TYPE_SessionTypeId",
                        column: x => x.SessionTypeId,
                        principalTable: "M_SESSION_TYPE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_SESSION_T_TRAINING_ATTENDEE_TrainingAttendeeId",
                        column: x => x.TrainingAttendeeId,
                        principalTable: "T_TRAINING_ATTENDEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LEARNING_REPORT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LeaningReportCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Trainer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrainingDocumentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEARNING_REPORT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LEARNING_REPORT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LEARNING_REPORT_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ASSESSMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrainingDocumentId = table.Column<int>(type: "int", nullable: false),
                    Scope = table.Column<int>(type: "int", nullable: false),
                    ManagementNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmBy = table.Column<int>(type: "int", nullable: false),
                    ConfirmDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovalBy = table.Column<int>(type: "int", nullable: false),
                    ApprovalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ASSESSMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_M_TRAINING_DOCUMENT_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "M_TRAINING_DOCUMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_M_USER_ApprovalBy",
                        column: x => x.ApprovalBy,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_TRAINING_RESULT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TRAINING_RESULT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_RESULT_M_LEVEL_LevelId",
                        column: x => x.LevelId,
                        principalTable: "M_LEVEL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_RESULT_M_OPERATION_OperationId",
                        column: x => x.OperationId,
                        principalTable: "M_OPERATION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_RESULT_M_STATUS_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_RESULT_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TRAINING_RESULT_T_TRAINING_SESSION_SessionId",
                        column: x => x.SessionId,
                        principalTable: "T_TRAINING_SESSION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ASSESSMENT_RESULT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ASSESSMENT_RESULT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_RESULT_M_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "M_USER",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_ASSESSMENT_RESULT_T_ASSESSMENT_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "T_ASSESSMENT",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "T_SKILLMAP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueBy = table.Column<int>(type: "int", nullable: false),
                    ApproveBy = table.Column<int>(type: "int", nullable: false),
                    ConfirmBy = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SKILLMAP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_SKILLMAP_M_USER_ApproveBy",
                        column: x => x.ApproveBy,
                        principalTable: "M_USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_SKILLMAP_T_ASSESSMENT_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "T_ASSESSMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LEARNING_REPORT_TrainingDocumentId",
                table: "LEARNING_REPORT",
                column: "TrainingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_LEARNING_REPORT_UserId",
                table: "LEARNING_REPORT",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_M_HANDOVER_RECORD_StatusId",
                table: "M_HANDOVER_RECORD",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_M_HANDOVER_RECORD_TrainingContentId",
                table: "M_HANDOVER_RECORD",
                column: "TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_DepartmentId",
                table: "M_OPERATION",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_ObjectId",
                table: "M_OPERATION",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_M_OPERATION_OperationCode",
                table: "M_OPERATION",
                column: "OperationCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_PERMISSION_PermissionCode",
                table: "M_PERMISSION",
                column: "PermissionCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_ROLE_RoleCode",
                table: "M_ROLE",
                column: "RoleCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_TAG_M_LEVELId",
                table: "M_TAG",
                column: "M_LEVELId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TAG_TagCode",
                table: "M_TAG",
                column: "TagCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_OperationId",
                table: "M_TRAINING_CONTENT",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentLifecycleId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentLifecycleId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentStepId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentStepId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_CONTENT_TrainingContentTypeId",
                table: "M_TRAINING_CONTENT",
                column: "TrainingContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_DOCUMENT_Code",
                table: "M_TRAINING_DOCUMENT",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_TRAINING_DOCUMENT_TrainingContentId",
                table: "M_TRAINING_DOCUMENT",
                column: "TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_M_USER_DepartmentId",
                table: "M_USER",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_M_USER_EmployeeId",
                table: "M_USER",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_USER_StatusId",
                table: "M_USER",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_ApprovalBy",
                table: "T_ASSESSMENT",
                column: "ApprovalBy");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_TrainingDocumentId",
                table: "T_ASSESSMENT",
                column: "TrainingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_RESULT_AssessmentId",
                table: "T_ASSESSMENT_RESULT",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ASSESSMENT_RESULT_UserId",
                table: "T_ASSESSMENT_RESULT",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_T_COURSE_CONTENT_CourseId",
                table: "T_COURSE_CONTENT",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_T_COURSE_CONTENT_TrainingContentId",
                table: "T_COURSE_CONTENT",
                column: "TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ROLE_PERMISSION_PermissionId",
                table: "T_ROLE_PERMISSION",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ROLE_PERMISSION_RoleId",
                table: "T_ROLE_PERMISSION",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_ApproveBy",
                table: "T_SKILLMAP",
                column: "ApproveBy");

            migrationBuilder.CreateIndex(
                name: "IX_T_SKILLMAP_AssessmentId",
                table: "T_SKILLMAP",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_ATTENDEE_StatusId",
                table: "T_TRAINING_ATTENDEE",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_ATTENDEE_TrainingCourseId",
                table: "T_TRAINING_ATTENDEE",
                column: "TrainingCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_ATTENDEE_UserId",
                table: "T_TRAINING_ATTENDEE",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_RESULT_LevelId",
                table: "T_TRAINING_RESULT",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_RESULT_OperationId",
                table: "T_TRAINING_RESULT",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_RESULT_SessionId",
                table: "T_TRAINING_RESULT",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_RESULT_StatusId",
                table: "T_TRAINING_RESULT",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_RESULT_UserId",
                table: "T_TRAINING_RESULT",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_SESSION_SessionTypeId",
                table: "T_TRAINING_SESSION",
                column: "SessionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_T_TRAINING_SESSION_TrainingAttendeeId",
                table: "T_TRAINING_SESSION",
                column: "TrainingAttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_ROLE_RoleId",
                table: "T_USER_ROLE",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_ROLE_UserId",
                table: "T_USER_ROLE",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TAG_TagId",
                table: "T_USER_TAG",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TAG_UserId",
                table: "T_USER_TAG",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_StatusId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_TrainingContentId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_TrainingContentStepId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "TrainingContentStepId");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_TRAINING_PROGRESS_UserId",
                table: "T_USER_TRAINING_PROGRESS",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LEARNING_REPORT");

            migrationBuilder.DropTable(
                name: "M_DIVISION");

            migrationBuilder.DropTable(
                name: "M_HANDOVER_RECORD");

            migrationBuilder.DropTable(
                name: "M_SKILLMAP_LEVEL");

            migrationBuilder.DropTable(
                name: "T_ASSESSMENT_RESULT");

            migrationBuilder.DropTable(
                name: "T_COURSE_CONTENT");

            migrationBuilder.DropTable(
                name: "T_ROLE_PERMISSION");

            migrationBuilder.DropTable(
                name: "T_SKILLMAP");

            migrationBuilder.DropTable(
                name: "T_TRAINING_RESULT");

            migrationBuilder.DropTable(
                name: "T_USER_ROLE");

            migrationBuilder.DropTable(
                name: "T_USER_TAG");

            migrationBuilder.DropTable(
                name: "T_USER_TRAINING_PROGRESS");

            migrationBuilder.DropTable(
                name: "M_PERMISSION");

            migrationBuilder.DropTable(
                name: "T_ASSESSMENT");

            migrationBuilder.DropTable(
                name: "T_TRAINING_SESSION");

            migrationBuilder.DropTable(
                name: "M_ROLE");

            migrationBuilder.DropTable(
                name: "M_TAG");

            migrationBuilder.DropTable(
                name: "M_TRAINING_DOCUMENT");

            migrationBuilder.DropTable(
                name: "M_SESSION_TYPE");

            migrationBuilder.DropTable(
                name: "T_TRAINING_ATTENDEE");

            migrationBuilder.DropTable(
                name: "M_LEVEL");

            migrationBuilder.DropTable(
                name: "M_TRAINING_CONTENT");

            migrationBuilder.DropTable(
                name: "M_USER");

            migrationBuilder.DropTable(
                name: "T_TRAINING_COURSE");

            migrationBuilder.DropTable(
                name: "M_OPERATION");

            migrationBuilder.DropTable(
                name: "M_TRAINING_CONTENT_LIFECYCLE");

            migrationBuilder.DropTable(
                name: "M_TRAINING_CONTENT_STEP");

            migrationBuilder.DropTable(
                name: "M_TRAINING_CONTENT_TYPE");

            migrationBuilder.DropTable(
                name: "M_STATUS");

            migrationBuilder.DropTable(
                name: "M_DEPARTMENT");

            migrationBuilder.DropTable(
                name: "M_OBJECT");
        }
    }
}
