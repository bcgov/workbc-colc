using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_LogLifestyleQuestionResult
    {
        public long LogLifestyleQuestionResultId { get; set; }
        public long LogQuizResultId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int ResponseOptionId { get; set; }
        public string ResponseOptionText { get; set; }
        public virtual FYF_LogQuizResult FYF_LogQuizResult { get; set; }
    }
}
