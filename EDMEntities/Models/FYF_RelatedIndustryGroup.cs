using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_RelatedIndustryGroup
    {
        public FYF_RelatedIndustryGroup()
        {
            this.FYF_QuizSubject = new List<FYF_QuizSubject>();
        }

        public int GroupId { get; set; }
        public int Score { get; set; }
        public virtual ICollection<FYF_ArchetypeRelatedIndustry> FYF_ArchetypeRelatedIndustry { get; set; }
        public virtual ICollection<FYF_QuizSubject> FYF_QuizSubject { get; set; }
    }
}
