using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class RegionalDistrict
    {
        public short LocationID { get; set; }
        public byte LocationTypeID { get; set; }
        public Nullable<int> RegionalProfileId { get; set; }
        public string DistrictName { get; set; }
        public string KeyCities { get; set; }
        public Nullable<double> Population { get; set; }
        public Nullable<double> ShareOfPopulationUrban { get; set; }
        public Nullable<double> ShareOfPopulationRural { get; set; }
    }
}
