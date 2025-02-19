using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class CareerProfile
    {
        public CareerProfile()
        {
            this.CareerProfileSkill = new List<CareerProfileSkill>();
            this.RelatedCareerProfiles = new List<CareerProfile>();
            this.RelatedFromCareerProfiles = new List<CareerProfile>();
            this.RelatedSource = new List<RelatedSource>();
            this.CareerProfileInYourLanguages = new List<CareerProfileInYourLanguage>();
            this.CareerProfileCareerTrekVideos = new List<CareerProfileCareerTrekVideos>();
        }

        public int CareerProfileID { get; set; }
        public int NOC_ID { get; set; }
        public string MinimumEducation { get; set; }
        public string CareerSummary { get; set; }
        public string MainDuties { get; set; }
        public string SpecialDuties { get; set; }
        public string WorkEnvironment { get; set; }
        public string JobRequirements { get; set; }        
        public string Workforce { get; set; }
        public string EarningsExtended { get; set; }
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
        public string RegionOutlookSummaryMSW { get; set; }
        public string RegionOutlookSummaryVI { get; set; }
        public string RegionOutlookSummaryTOK { get; set; }
        public string RegionOutlookSummaryKOO { get; set; }
        public string RegionOutlookSummaryCAR { get; set; }
        public string RegionOutlookSummaryNCN { get; set; }
        public string RegionOutlookSummaryNE { get; set; }
        public string CareerPath { get; set; }
        public string CareerTrekDescription { get; set; }
        public string CareerTrekID { get; set; }
        public string CareerTrekImageURL { get; set; }
        public string CareerTrekImageAltText { get; set; }
        public string CareerTrekSource { get; set; }
        public byte[] CareerImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        public string FeaturedDescription { get; set; }
        public byte[] CareerImageHeadShot { get; set; }
        public string DayInTheLifeOf { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<bool> IsFeaturedCategory { get; set; }
        public string FeaturedCategoryDescription { get; set; }
        public bool IsTopOccupation { get; set; }
        public bool IsTopHealthOccupation { get; set; }
        public string CareerProfileDescription { get; set; }
        public Nullable<int> TopOccupationSkillLevelRank { get; set; }
        public virtual NOC NOC { get; set; }
        public bool IsTop10Lng { get; set; }
        public bool IsTop50Occupation { get; set; }
        public bool IsDesignatedTrade { get; set; }
        public string TradesTrainingResourcesNote { get; set; }
        public string CareerFullImageAltTag { get; set; }
        public int SiteID { get; set; }
        public string SkillsAndAttributes { get; set; }
        public string EngLangRequire { get; set; }
        public Nullable<short> CareerLicensingID { get; set; }
        public string BecomingQualifiedHeader { get; set; }
        public string TotalApproximateFees { get; set; }
        public string EstimatedTime { get; set; }
        public string BecomingQualifiedContent { get; set; }
        public string RelatedCareersIntro { get; set; }
        public Nullable<int> RelatedCareersSites { get; set; }
        public string CareerIntro { get; set; }
        public string AddResourcesNotation { get; set; }
        

        public virtual ICollection<CareerProfileSkill> CareerProfileSkill { get; set; }
        public virtual ICollection<CareerProfile> RelatedCareerProfiles { get; set; }
        public virtual ICollection<CareerProfile> RelatedFromCareerProfiles { get; set; }
        public virtual ICollection<RelatedSource> RelatedSource { get; set; }
        public virtual ICollection<CareerProfileInYourLanguage> CareerProfileInYourLanguages { get; set; }
        public virtual ICollection<CareerProfileBecomingQualified> CareerProfileBecomingQualified { get; set; }
        public virtual ICollection<CareerProfileCareerTrekVideos> CareerProfileCareerTrekVideos { get; set; }

        // Table and Graphs Foot Note
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

        // Work-related skills
        public string WorkRelatedSkillsIntro { get; set; }

    }
}
