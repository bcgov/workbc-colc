using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_TaxType
    {
        public COLC_TaxType()
        {
            this.COLC_Tax = new List<COLC_Tax>();
        }

        public byte TaxTypeID { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<COLC_Tax> COLC_Tax { get; set; }
    }
}
