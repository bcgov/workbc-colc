using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace EDMEntities.Models.Mapping
{
    public class IndustryProfileViewMap : EntityTypeConfiguration<EDMEntities.Models.Custom.IndustryProfileView>
    {
        public IndustryProfileViewMap()
        {
            // Primary Key
            this.HasKey(t => t.NAICS);

            // Properties
            this.Property(t => t.NAICS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("vw_IndustryProfile");
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.IndustryImage).HasColumnName("IndustryImage");
            this.Property(t => t.KeyPoints).HasColumnName("KeyPoints");
            this.Property(t => t.Overview).HasColumnName("Overview");
            this.Property(t => t.Employment).HasColumnName("Employment");
            this.Property(t => t.Workforce).HasColumnName("Workforce");
            this.Property(t => t.EmploymentTypeFullTime).HasColumnName("EmploymentTypeFullTime");
            this.Property(t => t.EmploymentTypeSelfEmployed).HasColumnName("EmploymentTypeSelfEmployed");
            this.Property(t => t.EmploymentTypeTemp).HasColumnName("EmploymentTypeTemp");            
            this.Property(t => t.WorkEnvironment).HasColumnName("WorkEnvironment");
            this.Property(t => t.WorkEnvironmentPrivateSector).HasColumnName("WorkEnvironmentPrivateSector");
            this.Property(t => t.WorkEnvironmentSmallerWorkspace).HasColumnName("WorkEnvironmentSmallerWorkspace");
            this.Property(t => t.WorkEnvironmentUnion).HasColumnName("WorkEnvironmentUnion");
            this.Property(t => t.WagesSummary).HasColumnName("WagesSummary");

            this.Property(t => t.PercentageOfWomenCurrent).HasColumnName("PercentageOfWomenCurrent");
            this.Property(t => t.PercentageOf55YearsAndOlderPrevious).HasColumnName("PercentageOf55YearsAndOlderPrevious");
            this.Property(t => t.PercentageOf55YearsAndOlderCurrent).HasColumnName("PercentageOf55YearsAndOlderCurrent");
            this.Property(t => t.PercentageOfUnder25Current).HasColumnName("PercentageOfUnder25Current");
            this.Property(t => t.PercentageOfUnder25Previous).HasColumnName("PercentageOfUnder25Previous");
            this.Property(t => t.PercentageOfPartTimePrevious).HasColumnName("PercentageOfPartTimePrevious");
            this.Property(t => t.PercentageOfPartTimeCurrent).HasColumnName("PercentageOfPartTimeCurrent");
            this.Property(t => t.PercentageOfPrivatePrevious).HasColumnName("PercentageOfPrivatePrevious");
            this.Property(t => t.PercentageOfPrivateCurrent).HasColumnName("PercentageOfPrivateCurrent");
            this.Property(t => t.PercentageOfSelfEmployedPrevious).HasColumnName("PercentageOfSelfEmployedPrevious");
            this.Property(t => t.PercentageOfSelfEmployedCurrent).HasColumnName("PercentageOfSelfEmployedCurrent");
            this.Property(t => t.PercentageOfUnionPrevious).HasColumnName("PercentageOfUnionPrevious");
            this.Property(t => t.PercentageOfUnionCurrent).HasColumnName("PercentageOfUnionCurrent");
            this.Property(t => t.PercentageOfTempPrevious).HasColumnName("PercentageOfTempPrevious");
            this.Property(t => t.PercentageOfTempCurrent).HasColumnName("PercentageOfTempCurrent");
            this.Property(t => t.PercentageOfLess20EmpPrevious).HasColumnName("PercentageOfLess20EmpPrevious");
            this.Property(t => t.PercentageOfLess20EmpCurrent).HasColumnName("PercentageOfLess20EmpCurrent");
            this.Property(t => t.AvgWagesMalesPrevious).HasColumnName("AvgWagesMalesPrevious");
            this.Property(t => t.AvgWagesMalesCurrent).HasColumnName("AvgWagesMalesCurrent");
            this.Property(t => t.AvgWagesFemalesPrevious).HasColumnName("AvgWagesFemalesPrevious");
            this.Property(t => t.AvgWagesFemalesCurrent).HasColumnName("AvgWagesFemalesCurrent");
            this.Property(t => t.AvgWagesYouthPrevious).HasColumnName("AvgWagesYouthPrevious");
            this.Property(t => t.AvgWagesYouthCurrent).HasColumnName("AvgWagesYouthCurrent");
            this.Property(t => t.PercentageOfUnemploymentPrevious).HasColumnName("PercentageOfUnemploymentPrevious");
            this.Property(t => t.PercentageOfUnemploymentCurrent).HasColumnName("PercentageOfUnemploymentCurrent");
            this.Property(t => t.RegionalDistributionSummary).HasColumnName("RegionalDistributionSummary");
            this.Property(t => t.Outlook).HasColumnName("Outlook");
            this.Property(t => t.EmployLevelCurrent).HasColumnName("EmployLevelCurrent");
            this.Property(t => t.EmployLevelNext5Years).HasColumnName("EmployLevelNext5Years");
            this.Property(t => t.EmployLevelNext10Years).HasColumnName("EmployLevelNext10Years");
            this.Property(t => t.IndustryShareOfEmployCurrent).HasColumnName("IndustryShareOfEmployCurrent");
            this.Property(t => t.IndustryShareOfEmployNext5Years).HasColumnName("IndustryShareOfEmployNext5Years");
            this.Property(t => t.IndustryShareOfEmployNext10Years).HasColumnName("IndustryShareOfEmployNext10Years");
            this.Property(t => t.JobDemandIncrease).HasColumnName("JobDemandIncrease");
            this.Property(t => t.JobDemandGrowthRate).HasColumnName("JobDemandGrowthRate");
            this.Property(t => t.IsFeatured).HasColumnName("IsFeatured");
            this.Property(t => t.TenYearDemandIncrease).HasColumnName("TenYearDemandIncrease");
            this.Property(t => t.ProjectedAverageAnnualDemandGrowth).HasColumnName("ProjectedAverageAnnualDemandGrowth");
            this.Property(t => t.TotalEmploymentCurrent).HasColumnName("TotalEmploymentCurrent");
            this.Property(t => t.ForecastedAverageAnnualDemandGrowth1).HasColumnName("ForecastedAverageAnnualDemandGrowth1");
            this.Property(t => t.ForecastedAverageAnnualDemandGrowth2).HasColumnName("ForecastedAverageAnnualDemandGrowth2");
            this.Property(t => t.AnnotationNumber).HasColumnName("AnnotationNumber");
        }
    }
}
