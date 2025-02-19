using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LogQuizIndustryResult
    {
        public long LogQuizLocationResultId { get; set; }
        public long LogQuizResultId { get; set; }
        public int IndustryId { get; set; }
        public string IndustryText { get; set; }

        public virtual FYF_LogQuizResult FYF_LogQuizResult { get; set; }
    }
}