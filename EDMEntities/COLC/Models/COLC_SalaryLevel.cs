using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_SalaryLevel
    {
        public COLC_SalaryLevel()
        {
            this.COLC_ConsumableHealthExpense = new List<COLC_ConsumableHealthExpense>();
            this.COLC_HousingExpense = new List<COLC_HousingExpense>();
            this.COLC_TransportationExpense = new List<COLC_TransportationExpense>();
        }

        public short SalaryLevelID { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<COLC_ConsumableHealthExpense> COLC_ConsumableHealthExpense { get; set; }
        public virtual ICollection<COLC_HousingExpense> COLC_HousingExpense { get; set; }
        public virtual ICollection<COLC_TransportationExpense> COLC_TransportationExpense { get; set; }
    }
}
