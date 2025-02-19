using System;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class CareerIndustry
    {
        public Guid ID { get; set; }
        public Guid ResultsID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Industry { get; set; }
        public int SortIndex { get; set; }
        public bool Hidden { get; set; }

        public virtual CareerCompassResult Result { get; set; }
    }
}
