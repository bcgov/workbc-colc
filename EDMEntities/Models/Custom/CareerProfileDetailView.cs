using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public class CareerProfileDetailView
    {
        [Key]
        public int CareerProfileID { get; set; }
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public string Title { get; set; }
        public string CareerTrekDescription { get; set; }
        public string CareerTrekID { get; set; }
        public string CareerTrekImageURL { get; set; }
        public string CareerTrekImageAltText { get; set; }
        public string CareerTrekSource { get; set; }
        public byte[] CareerImage { get; set; }
        public string CareerFullImageAltTag { get; set; }
        public byte[] CareerImageHeadShot { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string MinimumEducation { get; set; }
        public string CareerIntro { get; set; }
        public string CareerSummary { get; set; }
        public string MainDuties { get; set; }
        public string MainDutiesMore { get; set; }
        public string WorkEnvironment { get; set; }
        public string WorkEnvironmentMore { get; set; }

        public string JobRequirements { get; set; }
        public string JobRequirementsMore { get; set; }
        public string CareerPath { get; set; }
        public string CareerPathMore { get; set; }

        public string InsightsFromIndustry { get; set; }
        public string InsightsFromIndustryMore { get; set; }
        public string DayInTheLifeContent { get; set; }
        public string DayInTheLifeContentMore { get; set; }

        public string OccupationGroup { get; set; }
        public int SiteID { get; set; }

        public bool IsTopOccupation { get; set; }
        public bool IsTopHealthOccupation { get; set; }

        public string WorkRelatedSkillsIntro { get; set; }

        public string WorkRelatedSkillsSource { get; set; }

        public virtual NOC NOC { get; set; }
        public virtual IDictionary<IndustryProfile, int> RelatedIndustriesWithJobsFromSameCareer { get; set; }
    }
}
