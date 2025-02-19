using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class WBC_CatchmentArea
    {
        public WBC_CatchmentArea()
        {
            this.WBC_ServicesCentres = new List<WBC_ServicesCentre>();
        }

        public int CatchmentAreaID { get; set; }
        public string Name { get; set; }
        public string PDFLink { get; set; }
        public virtual ICollection<WBC_ServicesCentre> WBC_ServicesCentres { get; set; }
    }
}
