using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class DemographicsProjectedParticipation
    {
        public DemographicsProjectedParticipation()
        {

        }

        public int Year { get; set; }
        public double MaleParticipation { get; set; }
        public double FemaleParticipation { get; set; }
        public double TotalParticipation { get; set; }

    }
}

