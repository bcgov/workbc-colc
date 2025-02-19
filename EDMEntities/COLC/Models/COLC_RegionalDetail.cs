using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_RegionalDetail
    {
        public short LocationID { get; set; }
        public string LocationName { get; set; }
        public string KeyCities { get; set; }
        public double ForecastedAnnualEmploymentGrowth {get; set;}
        public int DataYearStart { get; set; }
        public int DataYearMidpoint { get; set; }
        public int DataYearEnd { get; set; }
        public double EmploymentGrowthStartOfOutlook { get; set; }
        public double EmploymentGrowthMidpointOfOutlook { get; set; }
        public double EmploymentGrowthEndOfOutlook { get; set; }
        public double TotalEmploymentIncrease {get; set;}
        public string TopNOCCode1 { get; set; }
        public string TopOccupation1 { get; set; }
        public string TopNOCCode2 { get; set; }
        public string TopOccupation2 { get; set; }
        public string TopNOCCode3 { get; set; }
        public string TopOccupation3 { get; set; }
    }
}
