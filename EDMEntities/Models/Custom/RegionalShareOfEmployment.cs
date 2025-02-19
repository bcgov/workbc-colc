using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Custom
{
    public class RegionalShareOfEmployment
    {
        public string RegionName { get; set; }
        public double? ShareOfEmployInGoods { get; set;}
        public double? ShareOfEmployInService { get; set; }
    }
}
