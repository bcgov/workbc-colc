using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLC.COLCWebsite.Models.Calculator
{
    public class RegionalDetailsModels
    {
        /// <summary>
        /// Output model for regional details 
        /// </summary>
        public int RegionID { get; set; } // region ID
        public string RegionName { get; set; } // region name
        public string KeyCities { get; set; } // key cities
        public double ForecastedAnnualEmploymentGrowth { get; set; } // forecasted annual employment growth
        public int DataYearStart { get; set; } // start of outlook period
        public int DataYearMidpoint { get; set; } // middle of outlook period
        public int DataYearEnd { get; set; } // end of outlook period
        public int EmploymentGrowthStartOfOutlook { get; set; } // employment growth at the start of outlook period
        public int EmploymentGrowthMidpointOfOutlook { get; set; } // employment growth at the middle of outlook year
        public int EmploymentGrowthEndOfOutlook { get; set; } // employment growth at the end of outlook year
        public int TotalEmploymentIncrease { get; set; } // 10 year total employment increase
        public string TopNOCCode1 { get; set; } // 1st occupation NOC code
        public string TopOccupation1 { get; set; } // 1st occupation name
        public string TopNOCCode2 { get; set; } // 2nd occupation NOC code
        public string TopOccupation2 { get; set; } // 2nd occupation name
        public string TopNOCCode3 { get; set; } // 3rd occupation NOC code
        public string TopOccupation3 { get; set; } // 3rd occupation name
    }
}