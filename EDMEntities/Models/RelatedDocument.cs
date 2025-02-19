using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class RelatedDocument
    {
        public RelatedDocument()
        {
            this.IndustryProfile = new List<IndustryProfile>();
        }

        public int DocumentID { get; set; }
        public string Caption { get; set; }
        public string URL { get; set; }
        public virtual ICollection<IndustryProfile> IndustryProfile { get; set; }
    }
}
