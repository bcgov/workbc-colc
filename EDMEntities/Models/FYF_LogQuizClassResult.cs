using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LogQuizClassResult
    {
        public long LogQuizClassResultId { get; set; }
        public long LogQuizResultId { get; set; }
        public int ClassId { get; set; }
        public string ClassText { get; set; }
        public virtual FYF_LogQuizResult FYF_LogQuizResult { get; set; }
    }
}
