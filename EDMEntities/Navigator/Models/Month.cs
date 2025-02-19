using System;
using System.Collections.Generic;

namespace EDMEntities.Navigator.Models
{
    public partial class Month
    {
        public Month()
        {
            this.Snapshots = new List<Snapshot>();
        }

        public int month_id { get; set; }
        public string description { get; set; }
        public Nullable<bool> is_published { get; set; }       
        public virtual ICollection<Snapshot> Snapshots { get; set; }
    }
}
