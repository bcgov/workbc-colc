using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class WBC_Province
    {
        public WBC_Province()
        {
            this.WBC_ServicesCentres = new List<WBC_ServicesCentre>();
        }

        public short ProvinceID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual ICollection<WBC_ServicesCentre> WBC_ServicesCentres { get; set; }
    }
}
