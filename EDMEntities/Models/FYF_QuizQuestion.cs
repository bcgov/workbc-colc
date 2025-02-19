using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_QuizQuestion
    {
        public int QuizQuestionId { get; set; }
        public int ArchetypeId { get; set; }
        public string OptionX { get; set; }
        public string OptionY { get; set; }
        public virtual FYF_Archetype FYF_Archetype { get; set; }
    }
}
