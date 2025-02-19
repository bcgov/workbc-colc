using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class IndustryProfileImpact
    {
        public int ImpactID { get; set; }
        public int IndustryProfileID { get; set; }
        public string Factor { get; set; }
        public string EffectOnEmployment { get; set; }
        public string Impact { get; set; }
        public virtual IndustryProfile IndustryProfile { get; set; }
    }
}
