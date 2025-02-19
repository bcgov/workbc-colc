using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DataViewCareerProfileExpectedOutlookByRegionMap : EntityTypeConfiguration<DataViewCareerProfileExpectedOutlookByRegion>
    {
        public DataViewCareerProfileExpectedOutlookByRegionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_ID, t.NOCCode });

            // Properties
            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.LocationName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_DataViewCareerProfileExpectedOutlookByRegion");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");            
            this.Property(t => t.JobOpeningsOutlook).HasColumnName("JobOpeningsOutlook");
            this.Property(t => t.ExpectedDemandIncrease).HasColumnName("ExpectedDemandIncrease");
            this.Property(t => t.ExpectedAnnualDemandGrowthRate).HasColumnName("ExpectedAnnualDemandGrowthRate");
            this.Property(t => t.ReplacementDemandOutlookPercent).HasColumnName("ReplacementDemandOutlookPercent");
            this.Property(t => t.ReplacementDemandOutlookNumber).HasColumnName("ReplacementDemandOutlookNumber");
            this.Property(t => t.ExpansionDemandOutlookPercent).HasColumnName("ExpansionDemandOutlookPercent");
            this.Property(t => t.ExpansionDemandOutlookNumber).HasColumnName("ExpansionDemandOutlookNumber");
            this.Property(t => t.ExpectedAverageAnnualEmploymentGrowthRate1).HasColumnName("ExpectedAverageAnnualEmploymentGrowthRate1");
            this.Property(t => t.ExpectedAverageAnnualEmploymentGrowthRate2).HasColumnName("ExpectedAverageAnnualEmploymentGrowthRate2");
            this.Property(t => t.ForecastedEmployment).HasColumnName("ForecastedEmployment");
        }
    }
}
