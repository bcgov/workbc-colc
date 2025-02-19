using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models
{
    public partial class DataPointCareer
    {
        public long DataPointID { get; set; }
        public int DataSourceID { get; set; }
        public int NOC_ID { get; set; }
        public int VariableID { get; set; }
        public Nullable<short> DataYear { get; set; }
        public short LocationID { get; set; }
        public Nullable<double> Value { get; set; }
        public string CitationOverride { get; set; }
        public string AuditTrail { get; set; }

        public virtual NOC NOC { get; set; }
    }
}
