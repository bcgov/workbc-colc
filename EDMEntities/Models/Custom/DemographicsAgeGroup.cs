using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class DemographicsAgeGroup
    {
        public DemographicsAgeGroup()
        {

        }

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }


        public virtual List<DemographicsPopulation> PopulationData {get;set;}
        public virtual List<DemographicsProjectedPopulation> ProjectedPopulationData {get;set;}
    }
}

