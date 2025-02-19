using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileWorkRelatedSkillsFileMap : EntityTypeConfiguration<CareerProfileWorkRelatedSkillsFile>
    {
        public CareerProfileWorkRelatedSkillsFileMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FileId });

            // Table & Column Mappings
            this.ToTable("EDM_CareerProfileWorkRelatedSkillsFile");
            this.Property(t => t.FileId).HasColumnName("FileId");
            this.Property(t => t.FileName).HasColumnName("FileName");
        }
    }
}
