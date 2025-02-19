using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class RegionalExpectedHighGrowthOccupation
    {
        public int RegionalProfileId { get; set; }
        public int NOC_ID { get; set; }
        public string NameEnglish { get; set; }
        public double GrowthRate { get; set; }
        public double Jobs { get; set; }
        public string NOCCode { get; set; }
        public string TopLevelNocCode { get; set; }
        //public long Ranking { get; set; }
    }
}
