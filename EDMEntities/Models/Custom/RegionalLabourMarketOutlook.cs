using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Custom
{
    public class RegionalLabourMarketOutlook
    {
        public double? ProjectedEmployment { get; set; }
        public double? ForecastAnnualGrowth { get; set; }
        public double? EmploymentIn2010 { get; set; }
        public double? EmploymentIn2015 { get; set; }
        public double? EmploymentIn2020 { get; set; }
    }
}
