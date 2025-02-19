using System;
using System.Collections.Generic;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class Tool
    {
        public Tool()
        {
            CareerCompassResults = new List<CareerCompassResult>();
        }

        public Guid ID { get; set; }
        public Guid BlueprintID { get; set; }
        public int KenticoToolID { get; set; }
        public bool Viewed { get; set; }
        public bool Added { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Comment { get; set; }

        public virtual Blueprint Blueprint { get; set; }
        public virtual ICollection<CareerCompassResult> CareerCompassResults { get; set; }
    }
}
