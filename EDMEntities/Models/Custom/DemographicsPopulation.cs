using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class DemographicsPopulation
    {
        public DemographicsPopulation()
        {

        }


        public Int16 Year { get; set; }
        public int AgeGroupID { get; set; }
        public Nullable<double> MalePopPercent { get; set; }
        public Nullable<double> FemalePopPercent { get; set; }
        public Nullable<double> TotalPop { get; set; }

        public virtual DemographicsAgeGroup AgeGroup { get; set; } 

    }
}

