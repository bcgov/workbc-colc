using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class RegionalAgeDistribution
    {
        public int RegionalProfileId { get; set; }
        public string AgeRange { get; set; }
        public Nullable<double> ShareOfPopulation { get; set; }
    }
}
