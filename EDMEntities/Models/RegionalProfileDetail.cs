using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class RegionalProfileDetail
    {
        public int RegionalProfileId { get; set; }
        public Nullable<short> LocationID { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string KeyPoints { get; set; }
        public string RegionRoleSummary { get; set; }
        public string RegionRoleGoodsSector { get; set; }
        public string RegionRoleServiceSector { get; set; }
        public string EmployDistributionGoodsSector { get; set; }
        public string EmployDistributionServiceSector { get; set; }
        public string EmployDistributionSummary { get; set; }
        public Nullable<double> TotalPopulation { get; set; }
        public Nullable<double> UnemploymentRate { get; set; }
        public Nullable<double> TotalEmployment { get; set; }
        public Nullable<double> ShareOfBCEmployment { get; set; }
        public double ShareOfNewJobOpenings { get; set; }
        public Nullable<double> NewJobOpenings { get; set; }
        public double ShareOfReplacementOpenings { get; set; }
        public Nullable<double> ReplacementOpenings { get; set; }
        public Nullable<double> TotalEmploymentIncrease { get; set; }
        public Nullable<double> AnnualEmploymentGrowthRate { get; set; }
        public System.DateTime ProfileSourceDate { get; set; }
        public string ProfileSource { get; set; }
        public Nullable<double> ShareOfPopulationUrban { get; set; }
        public Nullable<double> ShareOfPopulationRural { get; set; }
        public string PopulationDistributionSource { get; set; }
        public System.DateTime EmploymentSourceDate { get; set; }
        public string EmploymentRateSource { get; set; }
        public string UnemploymentRateSource { get; set; }
        public string EmploymentDistributionSource { get; set; }
        public string LabourMarketOutlookSource { get; set; }
        public Nullable<double> PopulationOverFifteen { get; set; }
        public Nullable<double> EmploymentGrowthStartOfOutlook { get; set; }
        public Nullable<double> EmploymentGrowthMidpointOfOutlook { get; set; }
        public Nullable<double> EmploymentGrowthEndOfOutlook { get; set; }

        // Foot Notes
        public string TableGraph1FootNote { get; set; }
        public string TableGraph2FootNote { get; set; }
        public string TableGraph3FootNote { get; set; }
        public string TableGraph4FootNote { get; set; }
        public string TableGraph5FootNote { get; set; }
        public string TableGraph6FootNote { get; set; }
        public string TableGraph7FootNote { get; set; }
        public string TableGraph8FootNote { get; set; }
        public string TableGraph9FootNote { get; set; }
        public string TableGraph10FootNote { get; set; }
        public string TableGraph11FootNote { get; set; }
        public string TableGraph12FootNote { get; set; }

        // Meta data for each profile
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string PageKeywords { get; set; }
    }
}
