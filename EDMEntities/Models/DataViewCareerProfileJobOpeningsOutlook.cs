using System;

namespace EDMEntities.Models
{
    public partial class DataViewCareerProfileJobOpeningsOutlook
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public Nullable<Int16> LocationID { get; set; }
        public Nullable<short> DataYear { get; set; }        
        public Nullable<double> JobOpenings { get; set; } 
    }
}
