using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_QuizSubject
    {
        public int QuizSubjectId { get; set; }
        public int ClassId { get; set; }
        public int GroupId { get; set; }
        public int NAICS_ID { get; set; }
        public virtual NAICS NAICS { get; set; }
        public virtual FYF_Class FYF_Class { get; set; }
        public virtual FYF_RelatedIndustryGroup FYF_RelatedIndustryGroup { get; set; }
    }
}
