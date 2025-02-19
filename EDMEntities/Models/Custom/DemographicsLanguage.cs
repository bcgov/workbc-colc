using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class DemographicsLanguage
    {
        public DemographicsLanguage()
        {

        }

        public int Year { get; set; }
        public string Name { get; set; }
        public Nullable<int> NumSpeakers { get; set; }
        public double Percentage { get; set; }

    }
}

