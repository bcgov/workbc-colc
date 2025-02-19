using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LogQuizLocationResult
    {
        public long LogQuizLocationResultId { get; set; }
        public long LogQuizResultId { get; set; }
        public int LocationId { get; set; }
        public string LocationText { get; set; }
        public virtual FYF_LogQuizResult FYF_LogQuizResult { get; set; }
    }
}
