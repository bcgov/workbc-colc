using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class EDM_EduPlannerSubjectAreaMap : EntityTypeConfiguration<EDM_EduPlannerSubjectArea>
    {
        public EDM_EduPlannerSubjectAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.subjectareaID);

            // Properties
            this.Property(t => t.subjectareaLabel)
                .IsRequired()
                .HasMaxLength(255);
            this.Property(t => t.fieldID)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("EDM_EduPlannerSubjectAreas", "fyf");
            this.Property(t => t.subjectareaID).HasColumnName("subjectareaID");
            this.Property(t => t.subjectareaLabel).HasColumnName("subjectareaLabel");
            this.Property(t => t.fieldID).HasColumnName("fieldID");
        }
    }
}
