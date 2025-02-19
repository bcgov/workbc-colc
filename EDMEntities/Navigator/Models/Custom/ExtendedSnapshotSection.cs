using System;
using System.Collections.Generic;

namespace EDMEntities.Navigator.Models
{
    public partial class ExtendedSnapshotSection
    {
        public ExtendedSnapshotSection()
        {
            this.Snapshots = new List<ExtendedSnapshot>();           
        }

        public int snap_sec_id { get; set; }
        public string description { get; set; }
        public virtual ICollection<ExtendedSnapshot> Snapshots { get; set; }
    }
}
