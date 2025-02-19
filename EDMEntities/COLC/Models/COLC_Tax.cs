using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_Tax
    {
        public short TaxID { get; set; }
        public byte TaxTypeID { get; set; }
        public decimal LowerIncomeAmount { get; set; }
        public Nullable<decimal> UpperIncomeAmount { get; set; }
        public decimal BaseIncomeAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal CumulativeTaxAmount { get; set; }
        public virtual COLC_TaxType COLC_TaxType { get; set; }
    }
}
