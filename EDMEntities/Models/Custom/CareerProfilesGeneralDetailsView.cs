using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public class CareerProfilesGeneralDetailsView
    {        
        public int CareerProfilesGeneralDetailsID { get; set; }
        public string SourceLinkTextProvAvgEarnings { get; set; }
        public string SourceLinkUrlProvAvgEarnings { get; set; }
        public string SourceLinkTextProvAvgFullTimeHrRate { get; set; }
        public string SourceLinkUrlProvAvgFullTimeHrRate { get; set; }
        public string SourceLinkTextWorkForceCharacteristics { get; set; }
        public string SourceLinkUrlWorkForceCharacteristics { get; set; }
        public string SourceLinkTextEmploymentByIndustry { get; set; }
        public string SourceLinkUrlEmploymentByIndustry { get; set; }
        public string SourceLinkTextEmploymentByRegion { get; set; }
        public string SourceLinkUrlEmploymentByRegion { get; set; }
        public string SourceLinkTextProvincialOutlook { get; set; }
        public string SourceLinkUrlProvincialOutlook { get; set; }
        public string SourceLinkTextRegionalOutlook { get; set; }
        public string SourceLinkUrlRegionalOutlook { get; set; }
        public int ProvincialOutlookStartYear { get; set; }
    }
}
