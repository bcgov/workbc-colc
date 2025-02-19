using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LogQuizResult
    {
        public FYF_LogQuizResult()
        {
            this.FYF_LogLifestyleQuestionResult = new List<FYF_LogLifestyleQuestionResult>();
            this.FYF_LogQuizCareerResult = new List<FYF_LogQuizCareerResult>();
            this.FYF_LogQuizClassResult = new List<FYF_LogQuizClassResult>();
            this.FYF_LogQuizLocationResult = new List<FYF_LogQuizLocationResult>();
            this.FYF_LogQuizIndustryResult = new List<FYF_LogQuizIndustryResult>();
            this.FYF_LogQuizCareerQuizResult = new List<FYF_LogQuizCareerQuizResult>();
        }

        public long LogQuizResultId { get; set; }
        public int DominantArchetypeId { get; set; }
        public int DominantNACIS_ID { get; set; }
        public int CareerQuizType { get; set; }
        public virtual ICollection<FYF_LogLifestyleQuestionResult> FYF_LogLifestyleQuestionResult { get; set; }
        public virtual ICollection<FYF_LogQuizCareerResult> FYF_LogQuizCareerResult { get; set; }
        public virtual ICollection<FYF_LogQuizClassResult> FYF_LogQuizClassResult { get; set; }
        public virtual ICollection<FYF_LogQuizLocationResult> FYF_LogQuizLocationResult { get; set; }
        public virtual ICollection<FYF_LogQuizIndustryResult> FYF_LogQuizIndustryResult { get; set; }
        public virtual ICollection<FYF_LogQuizCareerQuizResult> FYF_LogQuizCareerQuizResult { get; set; }
    }
}
