using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class IndustryProfile
    {
        public IndustryProfile()
        {
            this.IndustryProfileImpact = new List<IndustryProfileImpact>();
            this.RelatedNOC = new List<NOC>();
            this.RelatedDocument = new List<RelatedDocument>();
            this.RelatedSource = new List<RelatedSource>();
        }

        public int IndustryProfileID { get; set; }
        public int NAICS_ID { get; set; }
        public byte[] IndustryImage { get; set; }
        public string KeyPoints { get; set; }
        public string Overview { get; set; }        
        public string Employment { get; set; }
        public string Workforce { get; set; }
        public string EmploymentTypeFullTime { get; set; }
        public string EmploymentTypeSelfEmployed { get; set; }
        public string EmploymentTypeTemp { get; set; }        
        public string WorkEnvironment { get; set; }
        public string WorkEnvironmentPrivateSector { get; set; }
        public string WorkEnvironmentSmallerWorkspace { get; set; }
        public string WorkEnvironmentUnion { get; set; }
        public string WagesSummary { get; set; }
        public string RegionalDistributionSummary { get; set; }
        public string Outlook { get; set; }
        public string RelatedCareersIntro { get; set; }
        public bool IsFeatured { get; set; }
        public byte[] IndustryHeaderImage { get; set; }
        public virtual NAICS NAICS { get; set; }
        public virtual ICollection<IndustryProfileImpact> IndustryProfileImpact { get; set; }
        public virtual ICollection<NOC> RelatedNOC { get; set; }
        public virtual ICollection<RelatedDocument> RelatedDocument { get; set; }
        public virtual ICollection<RelatedSource> RelatedSource { get; set; }

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
    }
}
