using System;

namespace EDMEntities.Models
{
    public partial class DataViewCareerProfileForecastedEmployment
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public Nullable<short> LocationID { get; set; }
        public string LocationName { get; set; }
        public Nullable<double> ForecastedEmployment { get; set; }
    }
}
