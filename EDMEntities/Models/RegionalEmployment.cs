using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class RegionalEmployment
    {
        public int RegionalProfileId { get; set; }
        public string RegionName { get; set; }
        public double FullTimeEmploymentRate { get; set; }
        public Nullable<double> ShareOfGoodsSector { get; set; }
        public Nullable<double> ShareOfServiceSector { get; set; }
        public int ListOrder { get; set; }
    }
}
