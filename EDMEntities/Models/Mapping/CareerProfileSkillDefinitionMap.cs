using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileSkillDefinitionMap : EntityTypeConfiguration<CareerProfileSkillDefinition>
    {
        public CareerProfileSkillDefinitionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SkillsDefId });

            // Table & Column Mappings
            this.ToTable("EDM_CareerProfileSkillsDefinitions");
            this.Property(t => t.SkillsDefId).HasColumnName("SkillsDefId");
            this.Property(t => t.IconUrl).HasColumnName("IconUrl");
            this.Property(t => t.Skill).HasColumnName("Skill");
            this.Property(t => t.SkillDefinition).HasColumnName("SkillDefinition");           
        }
    }
}
