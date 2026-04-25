using Application.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NidecSystemShared.Interfaces;

namespace Persistence.Context
{
	public class AppDbContext : DbContext, IAuditableEntityStamper
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
        /// <summary>
		/// Auto config Created, UpdatedBy, CreatedDate, UpdatedDate
		/// called from UnitOfWork
        /// </summary>
        public void StampAuditableEntities(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
                throw new InvalidOperationException("Audit stamping requires a non-empty user id.");

            var now = DateTime.Now; 

            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is IAuditAbleEntity<string> auditableEntity)
                {
                    var createdDateProp = entry.Entity.GetType().GetProperty("CreatedDate");
                    var updatedDateProp = entry.Entity.GetType().GetProperty("UpdatedDate");

                    switch (entry.State)
                    {
                        case EntityState.Added:
                            auditableEntity.CreatedBy = userId;
                            auditableEntity.UpdatedBy = userId;
                            createdDateProp?.SetValue(entry.Entity, now);
                            updatedDateProp?.SetValue(entry.Entity, now);
                            break;

                        case EntityState.Modified:
                            auditableEntity.UpdatedBy = userId;
                            updatedDateProp?.SetValue(entry.Entity, now);

                            var createdByProperty = entry.Metadata.FindProperty("CreatedBy");
                            var createdDateProperty = entry.Metadata.FindProperty("CreatedDate");
                            if (createdByProperty != null)
                                entry.Property("CreatedBy").IsModified = false;
                            if (createdDateProperty != null)
                                entry.Property("CreatedDate").IsModified = false;
                            break;
                    }
                }
            }
        }
    }
}
