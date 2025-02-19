using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class DemographicsRegionPopulation
    {
        public DemographicsRegionPopulation()
        {

        }

        [Key]
        public Int16 RegionID { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public Nullable<double> PopulationPercent { get; set; }
        public Nullable<double> Population { get; set; }
        public Nullable<double> UnemploymentRate { get; set; }
        public Nullable<double> TotalEmployment { get; set; }

    }
}

