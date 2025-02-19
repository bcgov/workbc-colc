using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileWorkRelatedSkillMap : EntityTypeConfiguration<CareerProfileWorkRelatedSkill>
    {
        public CareerProfileWorkRelatedSkillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id });

            // Table & Column Mappings
            this.ToTable("EDM_CareerProfileWorkRelatedSkills");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.NOC).HasColumnName("NOC");
            this.Property(t => t.SkillsCompetencies).HasColumnName("Skills_Competencies");
            this.Property(t => t.Importance).HasColumnName("Importance");
            this.Property(t => t.ImportanceDescription).HasColumnName("Importance_Description");
            this.Property(t => t.Proficiency).HasColumnName("Proficiency");
            this.Property(t => t.ProficiencyDescription).HasColumnName("Proficiency Description");
            this.Property(t => t.SkillsDefId).HasColumnName("SkillsDefId");
        }
    }
}
