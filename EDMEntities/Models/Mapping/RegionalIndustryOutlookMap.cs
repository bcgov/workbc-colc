using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalIndustryOutlookMap : EntityTypeConfiguration<RegionalIndustryOutlook>
    {
        public RegionalIndustryOutlookMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.NAICS_ID });

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAICS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("View_RegionalIndustryOutlook");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.NAICS_ID).HasColumnName("NAICS_ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.GrowthRate).HasColumnName("GrowthRate");
        }
    }
}
