using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class FYF_Subject
    {
        public FYF_Subject()
        {
            this.FYF_Class = new List<FYF_Class>();
        }

        public int SubjectId { get; set; }
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
        public virtual ICollection<FYF_Class> FYF_Class { get; set; }
    }
}
