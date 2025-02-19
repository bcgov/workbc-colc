using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class ViewCareerProfileWorkRelatedSkillMap : EntityTypeConfiguration<ViewCareerProfileWorkRelatedSkill>
    {
        public ViewCareerProfileWorkRelatedSkillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id });

            // Properties
            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("vw_CareerProfileWorkRelatedSkills");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.IconUrl).HasColumnName("IconUrl");
            this.Property(t => t.Skill).HasColumnName("Skill");
            this.Property(t => t.SkillDefinition).HasColumnName("SkillDefinition");
            this.Property(t => t.LevelOfImportancePercentage).HasColumnName("LevelOfImportancePercentage");
            this.Property(t => t.LevelOfImportanceDescription).HasColumnName("LevelOfImportanceDescription");
            this.Property(t => t.SkillStrength).HasColumnName("SkillStrength");
        }
    }
}
