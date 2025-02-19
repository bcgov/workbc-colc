using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class EDM_EduPlannerNocMap : EntityTypeConfiguration<EDM_EduPlannerNoc>
    {
        public EDM_EduPlannerNocMap()
        {
            // Primary Key
            this.HasKey(t => t.noc);

            // Properties
            this.Property(t => t.nocLabel)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EDM_EduPlannerNoc", "fyf");
            this.Property(t => t.noc).HasColumnName("noc");
            this.Property(t => t.nocLabel).HasColumnName("noclabel");

            // Relationships
            this.HasMany(t => t.EDM_EduPlannerSubjectAreas)
                .WithMany(t => t.EDM_EduPlannerNocs)
                .Map(m =>
                {
                    m.ToTable("EDM_EduPlannerSubjectAreaXNocs", "fyf");
                    m.MapLeftKey("noc");
                    m.MapRightKey("SubjectAreaId");
                });
        }
    }
}
