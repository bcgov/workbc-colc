using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class LocationType
    {
        public LocationType()
        {
            this.Location = new List<Location>();
        }

        public byte LocationTypeID { get; set; }
        public string LocationTypeName { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
