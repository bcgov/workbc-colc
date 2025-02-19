using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DataViewCareerProfileMap : EntityTypeConfiguration<DataViewCareerProfile>
    {
        public DataViewCareerProfileMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_ID, t.NOCCode });

            // Properties
            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("vw_DataViewCareerProfile");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.AvgSalaryDataYear).HasColumnName("AvgSalaryDataYear");
            this.Property(t => t.AvgSalary).HasColumnName("AvgSalary");
            this.Property(t => t.AvgSalaryPercentileRank).HasColumnName("AvgSalaryPercentileRank");
            this.Property(t => t.WorkfoceDataYear).HasColumnName("WorkfoceDataYear");
            this.Property(t => t.WorkforceSize).HasColumnName("WorkforceSize");
            this.Property(t => t.WorkforcePercentileRank).HasColumnName("WorkforcePercentileRank");
            this.Property(t => t.UnemploymentRateDataYear).HasColumnName("UnemploymentRateDataYear");
            this.Property(t => t.UnemploymentRate).HasColumnName("UnemploymentRate");
            this.Property(t => t.UnemploymentRatePercentileRank).HasColumnName("UnemploymentRatePercentileRank");
            this.Property(t => t.PercentAnnualDemandGrowthRateDataYear).HasColumnName("PercentAnnualDemandGrowthRateDataYear");
            this.Property(t => t.PercentAnnualDemandGrowthRate).HasColumnName("PercentAnnualDemandGrowthRate");
            this.Property(t => t.ProjectedAnnualDemandGrowthPercentile).HasColumnName("ProjectedAnnualDemandGrowthPercentile");
            //this.Property(t => t.CensusDataYear).HasColumnName("CensusDataYear");
            this.Property(t => t.WorkersEmployed).HasColumnName("WorkersEmployed");
            this.Property(t => t.BCAvgWorkersEmployed).HasColumnName("BCAvgWorkersEmployed");
            this.Property(t => t.PercentWorkingFullTime).HasColumnName("PercentWorkingFullTime");
            this.Property(t => t.TotalLabourForce).HasColumnName("TotalLabourForce");
            this.Property(t => t.PercentMale).HasColumnName("PercentMale");
            this.Property(t => t.PercentFemale).HasColumnName("PercentFemale");
            this.Property(t => t.Percent15to24).HasColumnName("Percent15to24");
            this.Property(t => t.Percent25to44).HasColumnName("Percent25to44");
            this.Property(t => t.Percent45to64).HasColumnName("Percent45to64");
            this.Property(t => t.Percent65Plus).HasColumnName("Percent65Plus");
            
            this.Property(t => t.ProvWageHigh).HasColumnName("ProvWageHigh");
            this.Property(t => t.ProvWageLow).HasColumnName("ProvWageLow");
            this.Property(t => t.ProvWageMedian).HasColumnName("ProvWageMedian");

            this.Property(t => t.AnnualSalarySource).HasColumnName("AnnualSalarySource");

            this.Property(t => t.Education).HasColumnName("Education");
        }
    }
}
