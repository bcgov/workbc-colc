using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileSkillMap : EntityTypeConfiguration<CareerProfileSkill>
    {
        public CareerProfileSkillMap()
        {
            // Primary Key
            this.HasKey(t => t.CareerProfileSkillID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EDM_CareerProfileSkill");
            this.Property(t => t.CareerProfileSkillID).HasColumnName("CareerProfileSkillID");
            this.Property(t => t.CareerProfileID).HasColumnName("CareerProfileID");
            this.Property(t => t.CareerSkillID).HasColumnName("CareerSkillID");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");

            // Relationships
            this.HasRequired(t => t.CareerProfile)
                .WithMany(t => t.CareerProfileSkill)
                .HasForeignKey(d => d.CareerProfileID);
            this.HasRequired(t => t.CareerSkill)
                .WithMany(t => t.CareerProfileSkill)
                .HasForeignKey(d => d.CareerSkillID);

        }
    }
}
