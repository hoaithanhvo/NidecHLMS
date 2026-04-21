using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
	public class AppDbContext : DbContext
    {
		public AppDbContext(DbContextOptions<AppDbContext> options)
	: base(options)
		{
		}
		// ================= MASTER DATA =================
		public DbSet<M_DEPARTMENT> Departments { get; set; }
		public DbSet<M_LEVEL> Levels { get; set; }
		public DbSet<M_OBJECT> Objects { get; set; }
		public DbSet<M_OPERATION> Operations { get; set; }
		public DbSet<M_PERMISSION> Permissions { get; set; }
		public DbSet<M_ROLE> Roles { get; set; }
		public DbSet<M_SESSION_TYPE> SessionTypes { get; set; }
		public DbSet<M_SOURCE> Sources { get; set; }
		public DbSet<M_STATUS> Statuses { get; set; }
		public DbSet<M_TAG> Tags { get; set; }
		public DbSet<M_USER> Users { get; set; }

		// ================= TRAINING MASTER =================
		public DbSet<M_TRAINING_CONTENT> TrainingContents { get; set; }
		public DbSet<M_TRAINING_CONTENT_FLOW> TrainingContentFlows { get; set; }
		public DbSet<M_TRAINING_CONTENT_FLOW_STEP> TrainingContentFlowSteps { get; set; }
		public DbSet<M_TRAINING_CONTENT_STEP> TrainingContentSteps { get; set; }
		public DbSet<M_TRAINING_CONTENT_LIFECYCLE> TrainingContentLifecycles { get; set; }
		public DbSet<M_TRAINING_CONTENT_TYPE> TrainingContentTypes { get; set; }
		public DbSet<M_TRAINING_DOCUMENT> TrainingDocuments { get; set; }

		// ================= SKILLMAP =================
		public DbSet<M_SKILLMAP_TEMPLATE> SkillmapTemplates { get; set; }
		public DbSet<M_SKILLMAP_TEMPLATE_DETAIL> SkillmapTemplateDetails { get; set; }
		public DbSet<M_SKILLMAP_CRITERIA> SkillmapCriterias { get; set; }

		// ================= TRANSACTION =================
		public DbSet<T_USER_TRAINING_ENROLLMENT> TrainingEnrollments { get; set; }
		public DbSet<T_USER_TRAINING_PROGRESS> TrainingProgresses { get; set; }
		public DbSet<T_TRAINING_SESSION> TrainingSessions { get; set; }
		public DbSet<T_TRAINING_RESULT> TrainingResults { get; set; }
		public DbSet<T_TRAINING_FILE> TrainingFiles { get; set; }
		public DbSet<T_TRAINING_PARTICIPANT> TrainingParticipants { get; set; }

		// ================= SECURITY =================
		public DbSet<T_USER_ROLE> UserRoles { get; set; }
		public DbSet<T_ROLE_PERMISSION> RolePermissions { get; set; }

		// ================= AUDIT =================
		public DbSet<LOG_AUDIT> AuditLogs { get; set; }



		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}
	}
}
