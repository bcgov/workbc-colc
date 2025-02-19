using System;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class Resource
    {
        public Guid ID { get; set; }
        public Guid BlueprintID { get; set; }
        public int KenticoResourceID { get; set; }
        public int CategoryID { get; set; }
        public bool Viewed { get; set; }
        public bool Added { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Comment { get; set; }

        public virtual Blueprint Blueprint { get; set; }
    }
}
