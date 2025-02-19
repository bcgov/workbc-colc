using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_OwnIndicator
    {
        public COLC_OwnIndicator()
        {
            this.COLC_HousingExpense = new List<COLC_HousingExpense>();
        }

        public byte OwnIndicatorID { get; set; }
        public string OwnIndicator { get; set; }
        public virtual ICollection<COLC_HousingExpense> COLC_HousingExpense { get; set; }
    }
}
