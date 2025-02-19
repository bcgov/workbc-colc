using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class CareerLicensing
    {
        public short CareerLicensingID { get; set; }
        public string CareerLicensingName { get; set; }

        public virtual ICollection<CareerProfileBecomingQualified> CareerProfileBecomingQualified { get; set; }
    }    
}
