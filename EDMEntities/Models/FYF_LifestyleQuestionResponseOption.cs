using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LifestyleQuestionResponseOption
    {
        public int LifestyleQuestionResponseOptionId { get; set; }
        public int LifestyleQuestionId { get; set; }
        public string Title { get; set; }
        public virtual FYF_LifestyleQuestion FYF_LifestyleQuestion { get; set; }
        public virtual ICollection<FYF_LifestyleQuestionResponseOptionLocationScore> FYF_LifestyleQuestionResponseOptionLocationScore { get; set; }
    }
}
