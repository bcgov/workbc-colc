using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class DataViewCareerProfileTopIndustriesByEmployment
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public Nullable<int> NAICS_ID { get; set; }
        public Nullable<short> DataYear { get; set; }
        public Nullable<double> IndustryPercentEmploymentForNOC { get; set; }
        public string Sector { get; set; }
        public string SectorType { get; set; }
        public Nullable<int> AnnotationNumber { get; set; }
    }
}
