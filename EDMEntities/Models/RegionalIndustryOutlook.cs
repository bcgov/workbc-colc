using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class RegionalIndustryOutlook
    {
        public int RegionalProfileId { get; set; }
        public int NAICS_ID { get; set; }
        public string Title { get; set; }
        public double GrowthRate { get; set; }
    }
}
