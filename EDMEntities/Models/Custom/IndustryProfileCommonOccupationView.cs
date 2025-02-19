using System;
using System.Collections.Generic;

namespace EDMEntities.Models.Custom
{
    public partial class IndustryProfileCommonOccupationView
    {
        public int IndustryCommonOccupationID { get; set; }
        public int NAICS { get; set; }
        public string NOC { get; set; }
        public string Title { get; set; }
        public virtual IndustryProfileView IndustryProfile { get; set; }
    }
}
