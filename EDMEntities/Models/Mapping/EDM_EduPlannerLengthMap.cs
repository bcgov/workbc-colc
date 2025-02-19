using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class EDM_EduPlannerLengthMap : EntityTypeConfiguration<EDM_EduPlannerLength>
    {
        public EDM_EduPlannerLengthMap()
        {
            // Primary Key
            this.HasKey(t => t.lengthID);

            // Properties
            this.Property(t => t.lengthLabel)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EDM_EduPlannerLengths");
            this.Property(t => t.lengthID).HasColumnName("lengthID");
            this.Property(t => t.lengthLabel).HasColumnName("lengthLabel");
        }
    }
}
