using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models
{
    public partial class FYF_LogQuizCareerQuizResult
    {
        public long LogQuizCareerQuizResultId { get; set; }
        public long LogQuizResultId { get; set; }
        public int CareerQuizQuestionId { get; set; }
        public int CareerQuizAnswerID { get; set; }

        public virtual FYF_LogQuizResult FYF_LogQuizResult { get; set; }
    }
}
