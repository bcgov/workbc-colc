using System;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class Category
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string MobileTitle { get; set; }
        public string ImageUrl { get; set; }
        public string AlternateText { get; set; }
        public int CategoryNumber { get; set; }
    }
}
