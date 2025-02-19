using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class DataViewCareerProfileRegionalOutlook
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public Nullable<short> LocationID { get; set; }
        public string LocationName { get; set; }
        public Nullable<double> JobOpeningsOutlook { get; set; }
        public Nullable<double> ExpectedAnnualDemandGrowthRate { get; set; }
        public Nullable<double> ForecastedEmployment { get; set; }
    }
}
