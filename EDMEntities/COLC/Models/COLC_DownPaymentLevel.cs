using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_DownPaymentLevel
    {
        public COLC_DownPaymentLevel()
        {
            this.COLC_HousingExpense = new List<COLC_HousingExpense>();
        }

        public short DownPaymentLevelID { get; set; }
        public decimal DownPayment { get; set; }
        public virtual ICollection<COLC_HousingExpense> COLC_HousingExpense { get; set; }
    }
}
