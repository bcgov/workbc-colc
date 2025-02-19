using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models
{
    public partial class DataPointIndustry
    {
        public long DataPointID { get; set; }
        public int DataSourceID { get; set; }
        public int NAICS_Id { get; set; }
        public Nullable<int> VariableID { get; set; }
        public Nullable<short> DataYear { get; set; }
        public short LocationID { get; set; }
        public Nullable<double> Value { get; set; }
        public string CitationOverride { get; set; }
        public string AuditTrail { get; set; }
    }
}
