using System;
using System.Collections.Generic;

namespace EDMEntities.Navigator.Models
{
    public partial class ExtendedMonth
    {
        public ExtendedMonth()
        {
            this.Snapshots = new List<ExtendedSnapshot>();            
        }

        public int month_id { get; set; }
        public string description { get; set; }
        public Nullable<bool> is_published { get; set; }        
        public virtual ICollection<ExtendedSnapshot> Snapshots { get; set; }
    }
}
