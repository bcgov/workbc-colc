using System;
using System.Collections.Generic;

namespace EDMEntities.Models.Custom
{
    public class CareerProfileDetail
    {
        public CareerProfileDetail()
        {  
            this.RelatedSources = new List<RelatedSource>();
        }

        public string NOC4Digit { get; set; }
        public string Title { get; set; }
        public string MinimumEducation { get; set; }
        public string SalaryRange { get; set; }
        public string SalaryStarRating { get; set; }
        public string SalaryTextRating { get; set; }
        public string SalarySummary { get; set; }
        public string OccupationStarRating { get; set; }
        public string OccupationTextRating { get; set; }
        public string StabilityStarRating { get; set; }
        public string StabilityTextRating { get; set; }
        public string CareerSummary { get; set; }
        public string MainDuties { get; set; }
        public string SpecialDuties { get; set; }
        public string WorkEnvironment { get; set; }
        public string JobRequirements { get; set; }
        public string Workforce { get; set; }
        public string EarningsExtended { get; set; }
        public string CharEmployedThis { get; set; }
        public string CharEmployedOther { get; set; }
        public string CharAvgSalaryRangeThis { get; set; }
        public string CharAvgSalaryRangeOther { get; set; }
        public Nullable<double> CharWorkingFullTimeThis { get; set; }
        public string CharWorkingFullTimeOther { get; set; }
        public Nullable<double> CharFemaleThis { get; set; }
        public string CharFemaleOther { get; set; }
        public string RegionalEmploymentGraph { get; set; }
        public Nullable<double> RegionalEmploymentVIThis { get; set; }
        public Nullable<double> RegionalEmploymentVIAll { get; set; }
        public Nullable<double> RegionalEmploymentMSWThis { get; set; }
        public Nullable<double> RegionalEmploymentMSWAll { get; set; }
        public Nullable<double> RegionalEmploymentTOKThis { get; set; }
        public Nullable<double> RegionalEmploymentTOKAll { get; set; }
        public Nullable<double> RegionalEmploymentKOOThis { get; set; }
        public Nullable<double> RegionalEmploymentKOOAll { get; set; }
        public Nullable<double> RegionalEmploymentCARThis { get; set; }
        public Nullable<double> RegionalEmploymentCARAll { get; set; }
        public Nullable<double> RegionalEmploymentNCNThis { get; set; }
        public Nullable<double> RegionalEmploymentNCNAll { get; set; }
        public string EmploymentOutlook { get; set; }
        public string CareerOutlookTitle { get; set; }
        public string CareerOutlookSummary { get; set; }
        public string ScenarioModel { get; set; }
        public Nullable<int> EmploymentCurrentMSW { get; set; }
        public Nullable<int> OpeningsNext5YearsMSW { get; set; }
        public Nullable<int> JobSeekersNext5YearsMSW { get; set; }
        public string ExpectedOutlookMSW { get; set; }
        public string SummaryMSW { get; set; }
        public Nullable<int> EmploymentCurrentVI { get; set; }
        public Nullable<int> OpeningsNext5YearsVI { get; set; }
        public Nullable<int> JobSeekersNext5YearsVI { get; set; }
        public string ExpectedOutlookVI { get; set; }
        public string SummaryVI { get; set; }
        public Nullable<int> EmploymentCurrentTOK { get; set; }
        public Nullable<int> OpeningsNext5YearsTOK { get; set; }
        public Nullable<int> JobSeekersNext5YearsTOK { get; set; }
        public string ExpectedOutlookTOK { get; set; }
        public string SummaryTOK { get; set; }
        public Nullable<int> EmploymentCurrentKOO { get; set; }
        public Nullable<int> OpeningsNext5YearsKOO { get; set; }
        public Nullable<int> JobSeekersNext5YearsKOO { get; set; }
        public string ExpectedOutlookKOO { get; set; }
        public string SummaryKOO { get; set; }
        public Nullable<int> EmploymentCurrentCAR { get; set; }
        public Nullable<int> OpeningsNext5YearsCAR { get; set; }
        public Nullable<int> JobSeekersNext5YearsCAR { get; set; }
        public string ExpectedOutlookCAR { get; set; }
        public string SummaryCAR { get; set; }
        public Nullable<int> EmploymentCurrentNCN { get; set; }
        public Nullable<int> OpeningsNext5YearsNCN { get; set; }
        public Nullable<int> JobSeekersNext5YearsNCN { get; set; }
        public string ExpectedOutlookNCN { get; set; }
        public string SummaryNCN { get; set; }
        public Nullable<int> EmploymentCurrentNE { get; set; }
        public Nullable<int> OpeningsNext5YearsNE { get; set; }
        public Nullable<int> JobSeekersNext5YearsNE { get; set; }
        public string ExpectedOutlookNE { get; set; }
        public string SummaryNE { get; set; }
        public string CareerPath { get; set; }
        public string CareerTrekID { get; set; }
        public byte[] CareerImage { get; set; }
        public string BecomingQualifiedHeader { get; set; }
        public string TotalApproximateFees { get; set; }
        public string EstimatedTime { get; set; }
        public string BecomingQualifiedContent { get; set; }
        public string RelatedCareersIntro { get; set; }
        public Nullable<int> RelatedCareersSites { get; set; }
        public string CareersIntro { get; set; }
        public string SkillsAndAttributes { get; set; }
        public string EngLangRequire { get; set; }
                
        /** Fields from Navigator **/
        public Nullable<decimal> WageBCLow { get; set; }
        public Nullable<decimal> WageBCMedian { get; set; }
        public Nullable<decimal> WageBCHigh { get; set; }
        public Nullable<double> WorkforceMale { get; set; }
        public Nullable<double> WorkforceFemale { get; set; }
        public Nullable<double> WorkforceAge1524 { get; set; }
        public Nullable<double> WorkforceAge2544 { get; set; }
        public Nullable<double> WorkforceAge4564 { get; set; }
        public Nullable<double> WorkforceAge65Plus { get; set; }
        public Nullable<double> UnemployRatePrev { get; set; }
        public Nullable<double> UnemployRateIn5Yrs { get; set; }
        public Nullable<double> UnemployRateIn10Yrs { get; set; }
        public Nullable<double> UnemployPerJobPrev { get; set; }
        public Nullable<double> UnemployPerJobIn5Yrs { get; set; }
        public Nullable<double> UnemployPerJobIn10Yrs { get; set; }
        public Nullable<double> OpeningsBC { get; set; }
        public Nullable<double> JobsFromExpansion { get; set; }
        public Nullable<double> JobsFromReplacement { get; set; }
        public Nullable<double> AAGBC { get; set; }
        public Nullable<double> OpeningsVIC { get; set; }
        public Nullable<double> OpeningsMSW { get; set; }
        public Nullable<double> OpeningsKOO { get; set; }
        public Nullable<double> OpeningsTOK { get; set; }
        public Nullable<double> OpeningsCAR { get; set; }
        public Nullable<double> OpeningsNCN { get; set; }
        public Nullable<double> OpeningsNE { get; set; }
        public Nullable<double> AAGVIC { get; set; }
        public Nullable<double> AAGMSW { get; set; }
        public Nullable<double> AAGKOO { get; set; }
        public Nullable<double> AAGTOK { get; set; }
        public Nullable<double> AAGCAR { get; set; }
        public Nullable<double> AAGNCN { get; set; }
        public Nullable<double> AAGNE { get; set; }
        public string OccupationGroup { get; set; }
        public string NOC3Digit { get; set; }
        /** End of fields from Navigator **/

        public string DayInTheLifeContent { get; set; }
        public bool IsDesignatedTrade { get; set; }
        public string TradesTrainingResourcesNote { get; set; }

        public virtual ICollection<RelatedSource> RelatedSources { get; set; }
        public string AddResourcesNotation { get; set; }
        public virtual ICollection<CareerSkill> CareerSkills { get; set; }

        // Table and Graphs Foot Notes
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

        // Meta data for each profile
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string PageKeywords { get; set; }

    }
}
