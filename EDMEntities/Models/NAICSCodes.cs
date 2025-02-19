using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class NAICSCodes
    {
        public int NAICS_ID { get; set; }
        public short NAICSCode { get; set; }
        public virtual NAICS NAICS { get; set; }
    }
}
