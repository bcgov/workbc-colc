using System;
using System.Collections.Generic;

namespace EDMEntities.Models.Custom
{
    public class TopOccupation
    {
        public TopOccupation()
        {
        }

        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public string NameEnglish { get; set; }
        public int SalaryRange { get; set; }
        public string SkillLevel { get; set; }                
        public Nullable<byte> StatusID { get; set; }
        public Nullable<double> WageMedian { get; set; }
        public Nullable<double> JobOpenings { get; set; }
        public bool WageIsAnnual { get; set; }
        public Nullable<double> Employment { get; set; }
        public bool EmploymentIsException { get; set; }
        public Nullable<int> TopOccupationSkillLevelRank { get; set; }
        public bool DisplayNOC { get; set; }
        public string OccupationalInterest { get; set; }
        public string Region { get; set; }
    }
}
