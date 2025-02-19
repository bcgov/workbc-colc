using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_Archetype
    {
        public FYF_Archetype()
        {
            this.FYF_ArchetypeRelatedIndustry = new List<FYF_ArchetypeRelatedIndustry>();
            this.FYF_QuizQuestion = new List<FYF_QuizQuestion>();
        }

        public int ArchetypeId { get; set; }
        public string Title { get; set; }
        public string Motivation { get; set; }
        public string Outcome { get; set; }
        public virtual ICollection<FYF_ArchetypeRelatedIndustry> FYF_ArchetypeRelatedIndustry { get; set; }
        public virtual ICollection<FYF_QuizQuestion> FYF_QuizQuestion { get; set; }
    }
}
