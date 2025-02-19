using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class WBC_ServicesCentreContractor
    {
        public WBC_ServicesCentreContractor()
        {
            this.WBC_ServicesCentres = new List<WBC_ServicesCentre>();
        }

        public int ServicesCentreContractorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<WBC_ServicesCentre> WBC_ServicesCentres { get; set; }
    }
}
