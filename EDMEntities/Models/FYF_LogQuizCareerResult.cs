using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LogQuizCareerResult
    {
        public long LogQuizCareerResultId { get; set; }
        public long LogQuizResultId { get; set; }
        public string NOCCode { get; set; }
        public virtual FYF_LogQuizResult FYF_LogQuizResult { get; set; }
    }
}
