using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LifestyleQuestionResponseOptionLocationScore
    {
        public int LifestyleQuestionResponseOptionLocationScoreId { get; set; }
        public int LifestyleQuestionResponseOptionId { get; set; }
        public short LocationId { get; set; }
        public int Score { get; set; }
        public virtual FYF_LifestyleQuestionResponseOption FYF_LifestyleQuestionResponseOption { get; set; }
        public virtual Location Location { get; set; }
    }
}
