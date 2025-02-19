using System;

namespace EDMEntities.Models
{
    public partial class DataViewTopHealthOccupation
    {
        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public string NameEnglish { get; set; }
        public int SalaryRange { get; set; }
        public string SkillLevel { get; set; }
        public Nullable<int> TopOccupationSkillLevelRank { get; set; }
        public Nullable<byte> StatusID { get; set; }
        public int SkillLevelSortOrder { get; set; }
        public Nullable<double> WageMedian { get; set; }        
        public bool WageIsAnnual { get; set; }
        public Nullable<double> Employment { get; set; }
        public bool EmploymentIsException { get; set; }
        public bool DisplayNOC { get; set; }
    }
}
