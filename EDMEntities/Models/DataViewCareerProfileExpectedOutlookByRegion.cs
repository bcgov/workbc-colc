using System;

namespace EDMEntities.Models
{
    public partial class DataViewCareerProfileExpectedOutlookByRegion
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public Nullable<short> LocationID { get; set; }
        public string LocationName { get; set; }       
        public Nullable<double> JobOpeningsOutlook { get; set; }
        public Nullable<double> ExpectedDemandIncrease { get; set; }
        public Nullable<double> ExpectedAnnualDemandGrowthRate { get; set; }
        public Nullable<double> ReplacementDemandOutlookPercent { get; set; }
        public Nullable<double> ExpansionDemandOutlookPercent { get; set; }
        public Nullable<double> ReplacementDemandOutlookNumber { get; set; }
        public Nullable<double> ExpansionDemandOutlookNumber { get; set; }
        public Nullable<double> ExpectedAverageAnnualEmploymentGrowthRate1 { get; set; }
        public Nullable<double> ExpectedAverageAnnualEmploymentGrowthRate2 { get; set; }
        public Nullable<double> ForecastedEmployment { get; set; }
    }
}
