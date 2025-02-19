using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class NOCSkillLevelDemandOutlookMap : EntityTypeConfiguration<NOCSkillLevelDemandOutlook>
    {
        public NOCSkillLevelDemandOutlookMap()
        {
            // Primary Key
            this.HasKey(t => t.SkillTypeCode);

            // Properties
            this.Property(t => t.SkillTypeCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .IsUnicode(false);
            this.Property(t => t.OccupationType)
                .HasMaxLength(100)
                .IsUnicode(false);
            this.Property(t => t.Education)
                .HasMaxLength(50)
                .IsUnicode(false);
            this.Property(t => t.EducationLongDesc)
                .HasMaxLength(150)
                .IsUnicode(false);

            // Table & Column Mappings
            this.ToTable("EDM_NOCSkillLevel_DemandOutlook");
            this.Property(t => t.SkillTypeCode).HasColumnName("SkillTypeCode");           
            this.Property(t => t.Education).HasColumnName("Education");
            this.Property(t => t.PercentageOpenings).HasColumnName("PercentageOpenings");
            this.Property(t => t.EducationLongDesc).HasColumnName("EducationLongDesc");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
        }
    }
}
