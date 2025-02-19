using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_Class
    {
        public FYF_Class()
        {
            this.FYF_QuizSubject = new List<FYF_QuizSubject>();
        }

        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
        public virtual FYF_Subject FYF_Subject { get; set; }
        public virtual ICollection<FYF_QuizSubject> FYF_QuizSubject { get; set; }
    }
}
