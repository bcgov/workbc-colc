using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_LocationType
    {
        public COLC_LocationType()
        {
            this.COLC_Location = new List<COLC_Location>();
        }

        public byte LocationTypeID { get; set; }
        public string LocationTypeName { get; set; }
        public virtual ICollection<COLC_Location> COLC_Location { get; set; }
    }
}
