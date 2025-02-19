using System;
using System.Collections.Generic;

namespace EDMEntities.Navigator.Models
{
    public partial class Snapshot
    {
        public int snap_id { get; set; }
        public string description { get; set; }
        public Nullable<double> month_over_month_change { get; set; }
        public Nullable<int> jobs { get; set; }
        public Nullable<double> un_employ_rate { get; set; }
        public int month_id { get; set; }
        public Nullable<int> snap_sec_id { get; set; }
        public virtual Month Month { get; set; }
        public virtual SnapshotSection SnapshotSection { get; set; }
    }
}
