using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Navigator.Models
{
    public partial class ExtendedIndustry
    {
        public ExtendedIndustry()
        {
            //this.Snapshots = new List<ExtendedSnapshot>();
        }

        public string Name { get; set; }
        public Nullable<double> Projected_Employment_Change_2010_2020 { get; set; }
        public Nullable<double> Forecasted_Average_Annual_Growth_in_Employment__2010_2020_ { get; set; }
        public Nullable<double> Employment_in_2010 { get; set; }
        public Nullable<double> Employment_in_2015 { get; set; }
        public Nullable<double> Employment_in_2020 { get; set; }
        public string Region_1 { get; set; }
        public Nullable<double> Average_Annual_Growth_of_employment_in_industry_in_region_1 { get; set; }
        public string Region_2 { get; set; }
        public Nullable<double> Average_Annual_Growth_of_employment_in_industry_in_region_2 { get; set; }
        public string Region_3 { get; set; }
        public Nullable<double> Average_Annual_Growth_of_employment_in_industry_in_region_3 { get; set; }
        public string Common_Occupation_1 { get; set; }
        public string NOC1 { get; set; }
        public string Common_Occupation_2 { get; set; }
        public string NOC2 { get; set; }
        public string Common_Occupation_3 { get; set; }
        public string NOC3 { get; set; }
        public string Common_Occupation_4 { get; set; }
        public string NOC4 { get; set; }
        public string Common_Occupation_5 { get; set; }
        public string NOC5 { get; set; }

        // additional fields
        [Key]
        public short NAICS { get; set; }

    }
}
