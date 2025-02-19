using System;
using System.Collections.Generic;

namespace EDMEntities.Models.Custom
{
    public partial class IndustryProfileView
    {
        public IndustryProfileView()
        {
            this.IndustryProfileCommonOccupations = new List<IndustryProfileCommonOccupationView>();
            this.IndustryProfileImpacts = new List<IndustryProfileImpactView>();
            this.IndustryProfileRelatedDocuments = new List<IndustryProfileRelatedDocumentView>();
            this.IndustryProfileRelatedSources = new List<IndustryProfileRelatedSourceView>();
            //this.IndustryRegionalShareOfProvincialEmployments = new List<IndustryRegionalShareOfProvincialEmploymentView>();
        }

        public int NAICS { get; set; }
        public string Title { get; set; }
        public string KeyPoints { get; set; }
        public string Overview { get; set; }        
        public string Workforce { get; set; }
        public Nullable<double> PercentageOfWomenCurrent { get; set; }
        public Nullable<double> PercentageOfUnder25Current { get; set; }
        public Nullable<double> PercentageOfUnder25Previous { get; set; }
        public Nullable<double> PercentageOf55YearsAndOlderPrevious { get; set; }
        public Nullable<double> PercentageOf55YearsAndOlderCurrent { get; set; }
        public string Employment { get; set; }
        public string EmploymentTypeFullTime { get; set; }
        public Nullable<double> PercentageOfPartTimePrevious { get; set; }
        public Nullable<double> PercentageOfPartTimeCurrent { get; set; }
        public string EmploymentTypeSelfEmployed { get; set; }
        public Nullable<double> PercentageOfSelfEmployedPrevious { get; set; }
        public Nullable<double> PercentageOfSelfEmployedCurrent { get; set; }
        public string EmploymentTypeTemp { get; set; }
        public Nullable<double> PercentageOfTempPrevious { get; set; }
        public Nullable<double> PercentageOfTempCurrent { get; set; }        
        public Nullable<double> PercentageOfUnemploymentPrevious { get; set; }
        public Nullable<double> PercentageOfUnemploymentCurrent { get; set; }
        public string WorkEnvironment { get; set; }
        public string WorkEnvironmentSmallerWorkspace { get; set; }
        public Nullable<double> PercentageOfLess20EmpPrevious { get; set; }
        public Nullable<double> PercentageOfLess20EmpCurrent { get; set; }
        public string WorkEnvironmentPrivateSector { get; set; }
        public Nullable<double> PercentageOfPrivatePrevious { get; set; }
        public Nullable<double> PercentageOfPrivateCurrent { get; set; }
        public string WorkEnvironmentUnion { get; set; }
        public Nullable<double> PercentageOfUnionPrevious { get; set; }
        public Nullable<double> PercentageOfUnionCurrent { get; set; }
        public Nullable<double> AvgWagesMalesPrevious { get; set; }
        public Nullable<double> AvgWagesMalesCurrent { get; set; }
        public Nullable<double> AvgWagesYouthPrevious { get; set; }
        public Nullable<double> AvgWagesYouthCurrent { get; set; }
        public Nullable<double> AvgWagesFemalesPrevious { get; set; }
        public Nullable<double> AvgWagesFemalesCurrent { get; set; }
        public string WagesSummary { get; set; }
        public string RegionalDistributionSummary { get; set; }
        public Nullable<double> EmployLevelCurrent { get; set; }
        public Nullable<double> EmployLevelNext5Years { get; set; }
        public Nullable<double> EmployLevelNext10Years { get; set; }
        public Nullable<double> IndustryShareOfEmployCurrent { get; set; }
        public Nullable<double> IndustryShareOfEmployNext5Years { get; set; }
        public Nullable<double> IndustryShareOfEmployNext10Years { get; set; }
        public Nullable<double> JobDemandIncrease { get; set; }
        public Nullable<double> JobDemandGrowthRate { get; set; }
        public Nullable<double> TenYearDemandIncrease { get; set; }
        public Nullable<double> ProjectedAverageAnnualDemandGrowth { get; set; }
        public Nullable<double> TotalEmploymentCurrent { get; set; }
        public Nullable<double> ForecastedAverageAnnualDemandGrowth1 { get; set; }
        public Nullable<double> ForecastedAverageAnnualDemandGrowth2 { get; set; }
        public string Outlook { get; set; }
        public string RelatedCareersIntro { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        public byte[] IndustryImage { get; set; }
        
        public virtual ICollection<IndustryProfileCommonOccupationView> IndustryProfileCommonOccupations { get; set; }
        public virtual ICollection<IndustryProfileImpactView> IndustryProfileImpacts { get; set; }
        public virtual ICollection<IndustryProfileRelatedDocumentView> IndustryProfileRelatedDocuments { get; set; }
        public virtual ICollection<IndustryProfileRelatedSourceView> IndustryProfileRelatedSources { get; set; }
        //public virtual ICollection<IndustryRegionalShareOfProvincialEmploymentView> IndustryRegionalShareOfProvincialEmployments { get; set; }

        // Table or Graph Foot Notes
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
        public string TableGraph13FootNote { get; set; }
        public string TableGraph14FootNote { get; set; }
        public string TableGraph15FootNote { get; set; }
        public string TableGraph16FootNote { get; set; }
        public string TableGraph17FootNote { get; set; }
        public string TableGraph18FootNote { get; set; }

        // Meta data for each profile
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string PageKeywords { get; set; }

        public int? AnnotationNumber { get; set; }
    }
}
