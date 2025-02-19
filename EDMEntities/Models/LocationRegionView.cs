using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models
{
    public class LocationRegionView
    {
        public LocationRegionView()
        {
        }

        public short RegionID { get; set; }
        public string RegionName { get; set; }
        public Nullable<byte> ListOrder { get; set; }
    }
}
