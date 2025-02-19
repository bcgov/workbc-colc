using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class DataViewTopLNGOccupation
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public Nullable<short> AvgSalaryDataYear { get; set; }
        public Nullable<double> AvgSalary { get; set; }
        public string NameEnglish { get; set; }
        public string CareerProfileDescription { get; set; }
        public int SalaryRange { get; set; }
        public string SkillLevel { get; set; } 
    }
}
