using System;
using System.Collections.Generic;

namespace EDMEntities.Navigator.Models
{
    public partial class SnapshotSection
    {
        public SnapshotSection()
        {
            this.Snapshots = new List<Snapshot>();
        }

        public int snap_sec_id { get; set; }
        public string description { get; set; }
        public virtual ICollection<Snapshot> Snapshots { get; set; }
    }
}
