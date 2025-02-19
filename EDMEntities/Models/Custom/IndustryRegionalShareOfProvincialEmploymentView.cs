using System;
using System.Collections.Generic;

namespace EDMEntities.Models.Custom
{
    public partial class IndustryRegionalShareOfProvincialEmploymentView
    {
        public int NAICS { get; set; }
        public Int16 LocationID { get; set; }
        public string LocationName { get; set; }
        public Nullable<double> RegionShareOfIndustryEmploymentInProvince { get; set; }        
    }


}
