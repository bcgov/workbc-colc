using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class FYF_CareerQuizAnswer
    {
        public int CareerQuizAnswerID { get; set; }
        public string AnswerText { get; set; }
        public short Score { get; set; }
        public short CareerQuizType { get; set; }
    }
}
