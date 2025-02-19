using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileWorkedRelatedSkillsSourceMap : EntityTypeConfiguration<CareerProfileWorkRelatedSkillsSource>
    {
        public CareerProfileWorkedRelatedSkillsSourceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SourceId });

            // Table & Column Mappings
            this.ToTable("EDM_CareerProfileWorkRelatedSkillsSource");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.WorkRelatedSkillsSource).HasColumnName("WorkRelatedSkillsSource");
        }
    }
}
