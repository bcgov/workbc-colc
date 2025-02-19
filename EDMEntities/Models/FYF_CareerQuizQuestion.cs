using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class FYF_CareerQuizQuestion
    {
        public int CareerQuestionId { get; set; }
        public int QuestionNumber { get; set; }
        public string Question { get; set; }
        public short CareerQuizType { get; set; }
    }
}
