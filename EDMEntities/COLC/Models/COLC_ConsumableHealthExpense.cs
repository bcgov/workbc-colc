using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_ConsumableHealthExpense
    {
        public int ConsumHealthExpID { get; set; }
        public short LocationID { get; set; }
        public short SalaryLevelID { get; set; }
        public short FamilySize { get; set; }
        public decimal ConsumerablesCost { get; set; }
        public decimal HealthCost { get; set; }
        public virtual COLC_Location COLC_Location { get; set; }
        public virtual COLC_SalaryLevel COLC_SalaryLevel { get; set; }
    }
}
