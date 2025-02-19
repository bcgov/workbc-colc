using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Custom
{
    public class Competitiveness
    {
        public double UnemployRate { get; set; } // Unemployment rate
        public int Unemployed { get; set; }  // Number of unemployed people
        public int NewJob { get; set; } // Number of new job openings
    }
}
