using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EDMEntities.Models.Custom;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfilesGeneralDetailsViewMap : EntityTypeConfiguration<CareerProfilesGeneralDetailsView>
    {       
        public CareerProfilesGeneralDetailsViewMap() {
            // Primary Key
            this.HasKey(t => t.CareerProfilesGeneralDetailsID);

            // Properties
            this.Property(t => t.CareerProfilesGeneralDetailsID)
                .IsRequired();

            this.ToTable("vw_CareerProfilesGeneralDetails");
            this.Property(t => t.CareerProfilesGeneralDetailsID).HasColumnName("CareerProfilesGeneralDetailsID");
            this.Property(t => t.SourceLinkTextProvAvgEarnings).HasColumnName("SourceLinkTextProvAvgEarnings");
            this.Property(t => t.SourceLinkUrlProvAvgEarnings).HasColumnName("SourceLinkUrlProvAvgEarnings");
            this.Property(t => t.SourceLinkTextProvAvgFullTimeHrRate).HasColumnName("SourceLinkTextProvAvgFullTimeHrRate");
            this.Property(t => t.SourceLinkUrlProvAvgFullTimeHrRate).HasColumnName("SourceLinkUrlProvAvgFullTimeHrRate");
            this.Property(t => t.SourceLinkTextWorkForceCharacteristics).HasColumnName("SourceLinkTextWorkForceCharacteristics");
            this.Property(t => t.SourceLinkUrlWorkForceCharacteristics).HasColumnName("SourceLinkUrlWorkForceCharacteristics");
            this.Property(t => t.SourceLinkTextEmploymentByIndustry).HasColumnName("SourceLinkTextEmploymentByIndustry");
            this.Property(t => t.SourceLinkUrlEmploymentByIndustry).HasColumnName("SourceLinkUrlEmploymentByIndustry");
            this.Property(t => t.SourceLinkTextEmploymentByRegion).HasColumnName("SourceLinkTextEmploymentByRegion");
            this.Property(t => t.SourceLinkUrlEmploymentByRegion).HasColumnName("SourceLinkUrlEmploymentByRegion");
            this.Property(t => t.SourceLinkTextProvincialOutlook).HasColumnName("SourceLinkTextProvincialOutlook");
            this.Property(t => t.SourceLinkUrlProvincialOutlook).HasColumnName("SourceLinkUrlProvincialOutlook");
            this.Property(t => t.SourceLinkTextRegionalOutlook).HasColumnName("SourceLinkTextRegionalOutlook");
            this.Property(t => t.SourceLinkUrlRegionalOutlook).HasColumnName("SourceLinkUrlRegionalOutlook");
            this.Property(t => t.ProvincialOutlookStartYear).HasColumnName("ProvincialOutlookStartYear");
        }
    }
}
