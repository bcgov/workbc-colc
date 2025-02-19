using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_ArchetypeRelatedIndustry
    {
        public int ArchetypeRelatedIndustryId { get; set; }
        public int ArchetypeId { get; set; }
        public int GroupId { get; set; }
        public int NAICS_ID { get; set; }
        public virtual NAICS NAICS { get; set; }
        public virtual FYF_Archetype FYF_Archetype { get; set; }
        public virtual FYF_RelatedIndustryGroup FYF_RelatedIndustryGroup { get; set; }
    }
}
