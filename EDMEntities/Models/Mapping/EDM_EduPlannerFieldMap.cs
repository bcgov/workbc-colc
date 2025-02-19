using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class EDM_EduPlannerFieldMap : EntityTypeConfiguration<EDM_EduPlannerField>
    {
        public EDM_EduPlannerFieldMap()
        {
            // Primary Key
            this.HasKey(t => t.fieldID);

            // Properties
            this.Property(t => t.fieldLabel)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EDM_EduPlannerFields", "fyf");
            this.Property(t => t.fieldID).HasColumnName("fieldID");
            this.Property(t => t.fieldLabel).HasColumnName("fieldLabel");

            // Relationships
            this.HasMany(t => t.EDM_EduPlannerSubjectAreas);
        }
    }
}
