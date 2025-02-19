using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_Occupation
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public string NameEnglish { get; set; }
        public Nullable<double> AvgSalary { get; set; }
        public string AlternativeJobTitles { get; set; }
    }
}
