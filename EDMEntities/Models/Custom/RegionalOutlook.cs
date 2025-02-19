using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Custom
{
    public class RegionalOutlook
    {
        public short LocationId { get; set; }
        public string Description { get; set; }
        public Nullable<double> Openings { get; set; }
        public Nullable<double> AAG { get; set; }             
    }
}
