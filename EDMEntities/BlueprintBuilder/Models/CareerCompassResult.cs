using System;
using System.Collections.Generic;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class CareerCompassResult
    {
        public CareerCompassResult()
        {
            CareerSuggestions = new List<CareerSuggestion>();
            CareerIndustries = new List<CareerIndustry>();
        }

        public Guid ID { get; set; }
        public Guid ToolID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int QuizType { get; set; }
        public long QuizResult { get; set; }

        public virtual Tool Tool { get; set; }
        public virtual ICollection<CareerSuggestion> CareerSuggestions { get; set; }
        public virtual ICollection<CareerIndustry> CareerIndustries { get; set; }
    }
}
