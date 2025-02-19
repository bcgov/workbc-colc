using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class RelatedSource
    {
        public RelatedSource()
        {
            this.CareerProfile = new List<CareerProfile>();
            this.IndustryProfile = new List<IndustryProfile>();
        }

        public int SourceID { get; set; }
        public string Caption { get; set; }
        public string URL { get; set; }
        public virtual ICollection<CareerProfile> CareerProfile { get; set; }
        public virtual ICollection<IndustryProfile> IndustryProfile { get; set; }
    }
}
