using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class DataViewCareerProfile
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public Nullable<short> AvgSalaryDataYear { get; set; }
        public Nullable<double> AvgSalary { get; set; }
        public Nullable<decimal> AvgSalaryPercentileRank { get; set; }
        public Nullable<short> WorkfoceDataYear { get; set; }
        public Nullable<double> WorkforceSize { get; set; }
        public Nullable<long> WorkforcePercentileRank { get; set; }
        public Nullable<short> UnemploymentRateDataYear { get; set; }
        public Nullable<double> UnemploymentRate { get; set; }
        public Nullable<long> UnemploymentRatePercentileRank { get; set; }
        public Nullable<short> PercentAnnualDemandGrowthRateDataYear { get; set; }
        public Nullable<double> PercentAnnualDemandGrowthRate { get; set; }
        public Nullable<long> ProjectedAnnualDemandGrowthPercentile { get; set; }       
        public Nullable<double> WorkersEmployed { get; set; }
        public Nullable<double> BCAvgWorkersEmployed { get; set; }
        public Nullable<double> PercentWorkingFullTime { get; set; }
        public Nullable<double> TotalLabourForce { get; set; }
        public Nullable<double> PercentMale { get; set; }
        public Nullable<double> PercentFemale { get; set; }
        public Nullable<double> Percent15to24 { get; set; }
        public Nullable<double> Percent25to44 { get; set; }
        public Nullable<double> Percent45to64 { get; set; }
        public Nullable<double> Percent65Plus { get; set; }
        public Nullable<double> ProvWageLow { get; set; }
        public Nullable<double> ProvWageMedian { get; set; }
        public Nullable<double> ProvWageHigh { get; set; }
        public string AnnualSalarySource { get; set; }
        public string Education { get; set; }
    }
}
