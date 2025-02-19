using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class RegionalOccupationOutlook
    {
        public int RegionalProfileId { get; set; }
        public int NOC_ID { get; set; }
        public string NameEnglish { get; set; }
        public double JobOpenings { get; set; }        
        public double TopOccForecastedAverageAnnualEmploymentGrowth { get; set; }
        public string NOCCode { get; set; }
        public string TopLevelNocCode { get; set; }        
    }
}
