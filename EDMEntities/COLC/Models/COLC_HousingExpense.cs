using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_HousingExpense
    {
        public int HousingExpenseID { get; set; }
        public short LocationID { get; set; }
        public short SalaryLevelID { get; set; }
        public byte OwnIndicatorID { get; set; }
        public short SqFtLevelID { get; set; }
        public short FamilySize { get; set; }
        public short DownPaymentLevelID { get; set; }
        public decimal AnnualHousingCost { get; set; }
        public virtual COLC_DownPaymentLevel COLC_DownPaymentLevel { get; set; }
        public virtual COLC_Location COLC_Location { get; set; }
        public virtual COLC_OwnIndicator COLC_OwnIndicator { get; set; }
        public virtual COLC_SalaryLevel COLC_SalaryLevel { get; set; }
        public virtual COLC_SqFtLevel COLC_SqFtLevel { get; set; }
    }
}
