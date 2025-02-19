using System;
using System.Collections.Generic;

namespace EDMEntities.Navigator.Models
{
    /// <summary>
    /// This model was created as a temporary measure, 
    /// so development could continue before extra data 
    /// fields and data were made available.
    /// 
    /// If these fields are added to the snapshot table,
    /// then this class will be obsolete when the models
    /// are updated.
    /// 
    /// Otherwise, the base view can be updated to bring
    /// in all the data required.
    /// </summary>
    public partial class ExtendedSnapshot
    {
        public int snap_id { get; set; }
        public string description { get; set; }
        public Nullable<double> month_over_month_change { get; set; }
        public Nullable<int> jobs { get; set; }
        public int month_id { get; set; }
        public Nullable<int> snap_sec_id { get; set; }

        public virtual ExtendedMonth Month { get; set; }
        public virtual ExtendedSnapshotSection SnapshotSection { get; set; }

        // additional fields
        public Nullable<int> region_id { get; set; } // optional, if the snapshot data relates to a region
        public Nullable<int> NAICS { get; set; } // optional, if the snapshot data relates to an industry

        public Nullable<double> current_value { get; set; }
        public Nullable<decimal> previous_value { get; set; }

        public Nullable<int> order_id { get; set; }


    }
}
