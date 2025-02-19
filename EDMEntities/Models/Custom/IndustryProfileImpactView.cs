using System;
using System.Collections.Generic;


namespace EDMEntities.Models.Custom
{
    public partial class IndustryProfileImpactView
    {
        public int ImpactID { get; set; }
        public int NAICS { get; set; }
        public string Factor { get; set; }
        public string EffectOnEmployment { get; set; }
        public string Impact { get; set; }
        public virtual IndustryProfileView IndustryProfile { get; set; }
    }
}
