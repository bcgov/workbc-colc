using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LifestyleQuestion
    {
        public FYF_LifestyleQuestion()
        {
            this.FYF_LifestyleQuestionResponseOption = new List<FYF_LifestyleQuestionResponseOption>();
        }

        public int LifestyleQuestionId { get; set; }
        public string Title { get; set; }
        public int DisplayOrder{ get; set; }
        public virtual ICollection<FYF_LifestyleQuestionResponseOption> FYF_LifestyleQuestionResponseOption { get; set; }
    }
}
