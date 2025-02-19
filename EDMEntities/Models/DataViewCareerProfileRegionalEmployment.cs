using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class DataViewCareerProfileRegionalEmployment
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public string title { get; set; }
        public short LocationID { get; set; }
        public Nullable<double> Value { get; set; }
        public Location Location { get; set; }
    }
}
