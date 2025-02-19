using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerSkillMap : EntityTypeConfiguration<CareerSkill>
    {
        public CareerSkillMap()
        {
            // Primary Key
            this.HasKey(t => t.CareerSkillID);

            // Properties
            this.Property(t => t.CareerSkillName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("EDM_CareerSkill");
            this.Property(t => t.CareerSkillID).HasColumnName("CareerSkillID");
            this.Property(t => t.CareerSkillName).HasColumnName("CareerSkillName");
        }
    }
}
