using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Custom
{
    public class IndustryRegionalEmpByNAICS
    {
        public Nullable<double> DistributionThisCAR { get; set; } // Cariboo
        public Nullable<double> DistributionThisKOO { get; set; } // Kootenay
        public Nullable<double> DistributionThisMSW { get; set; } // Mainland/Southwest
        public Nullable<double> DistributionThisNCN { get; set; } // North Coast & Nechako
        public Nullable<double> DistributionThisNE { get; set; } // Northeast
        public Nullable<double> DistributionThisTOK { get; set; } // Thompson-Okanagan
        public Nullable<double> DistributionThisVI { get; set; } // Vancouver Island/Coast
    }
}
