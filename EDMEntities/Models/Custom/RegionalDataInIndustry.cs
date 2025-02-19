using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Custom
{
    public class RegionalDataInIndustry
    {
        public string Sector { get; set; }
        public string Industry { get; set; }
        public double? ShareOfJobs { get; set; }
        public double? ShareOfEmploy { get; set; }
    }
}
