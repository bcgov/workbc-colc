using System;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class CareerSuggestion
    {
        public Guid ID { get; set; }
        public Guid ResultsID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Suggestion { get; set; }
        public bool Hidden { get; set; }

        public virtual CareerCompassResult Result { get; set; }
    }
}
