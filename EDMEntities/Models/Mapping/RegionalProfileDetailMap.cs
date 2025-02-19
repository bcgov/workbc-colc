using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalProfileDetailMap : EntityTypeConfiguration<RegionalProfileDetail>
    {
        public RegionalProfileDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.Title, t.ShareOfNewJobOpenings, t.ShareOfReplacementOpenings, t.ProfileSourceDate, t.ProfileSource, t.PopulationDistributionSource, t.EmploymentSourceDate, t.EmploymentRateSource, t.UnemploymentRateSource, t.EmploymentDistributionSource, t.LabourMarketOutlookSource });

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProfileSource)
                .IsRequired()
                .HasMaxLength(48);

            this.Property(t => t.PopulationDistributionSource)
                .IsRequired()
                .HasMaxLength(54);

            this.Property(t => t.EmploymentRateSource)
                .IsRequired()
                .HasMaxLength(29);

            this.Property(t => t.UnemploymentRateSource)
                .IsRequired()
                .HasMaxLength(29);

            this.Property(t => t.EmploymentDistributionSource)
                .IsRequired()
                .HasMaxLength(33);

            this.Property(t => t.LabourMarketOutlookSource)
                .IsRequired()
                .HasMaxLength(33);

            // Table & Column Mappings
            this.ToTable("View_RegionalProfileDetail");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Overview).HasColumnName("Overview");
            this.Property(t => t.KeyPoints).HasColumnName("KeyPoints");
            this.Property(t => t.RegionRoleSummary).HasColumnName("RegionRoleSummary");
            this.Property(t => t.RegionRoleGoodsSector).HasColumnName("RegionRoleGoodsSector");
            this.Property(t => t.RegionRoleServiceSector).HasColumnName("RegionRoleServiceSector");
            this.Property(t => t.EmployDistributionGoodsSector).HasColumnName("EmployDistributionGoodsSector");
            this.Property(t => t.EmployDistributionServiceSector).HasColumnName("EmployDistributionServiceSector");
            this.Property(t => t.EmployDistributionSummary).HasColumnName("EmployDistributionSummary");
            this.Property(t => t.TotalPopulation).HasColumnName("TotalPopulation");
            this.Property(t => t.UnemploymentRate).HasColumnName("UnemploymentRate");
            this.Property(t => t.TotalEmployment).HasColumnName("TotalEmployment");
            this.Property(t => t.ShareOfBCEmployment).HasColumnName("ShareOfBCEmployment");
            this.Property(t => t.ShareOfNewJobOpenings).HasColumnName("ShareOfNewJobOpenings");
            this.Property(t => t.NewJobOpenings).HasColumnName("NewJobOpenings");
            this.Property(t => t.ShareOfReplacementOpenings).HasColumnName("ShareOfReplacementOpenings");
            this.Property(t => t.ReplacementOpenings).HasColumnName("ReplacementOpenings");
            this.Property(t => t.TotalEmploymentIncrease).HasColumnName("TotalEmploymentIncrease");
            this.Property(t => t.AnnualEmploymentGrowthRate).HasColumnName("AnnualEmploymentGrowthRate");
            this.Property(t => t.ProfileSourceDate).HasColumnName("ProfileSourceDate");
            this.Property(t => t.ProfileSource).HasColumnName("ProfileSource");
            this.Property(t => t.ShareOfPopulationUrban).HasColumnName("ShareOfPopulationUrban");
            this.Property(t => t.ShareOfPopulationRural).HasColumnName("ShareOfPopulationRural");
            this.Property(t => t.PopulationDistributionSource).HasColumnName("PopulationDistributionSource");
            this.Property(t => t.EmploymentSourceDate).HasColumnName("EmploymentSourceDate");
            this.Property(t => t.EmploymentRateSource).HasColumnName("EmploymentRateSource");
            this.Property(t => t.UnemploymentRateSource).HasColumnName("UnemploymentRateSource");
            this.Property(t => t.EmploymentDistributionSource).HasColumnName("EmploymentDistributionSource");
            this.Property(t => t.LabourMarketOutlookSource).HasColumnName("LabourMarketOutlookSource");
            this.Property(t => t.PopulationOverFifteen).HasColumnName("PopulationOverFifteen");
            this.Property(t => t.EmploymentGrowthStartOfOutlook).HasColumnName("EmploymentGrowthStartOfOutlook");
            this.Property(t => t.EmploymentGrowthMidpointOfOutlook).HasColumnName("EmploymentGrowthMidpointOfOutlook");
            this.Property(t => t.EmploymentGrowthEndOfOutlook).HasColumnName("EmploymentGrowthEndOfOutlook");
        }
    }
}
