using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_TransportationExpense
    {
        public int TransExpID { get; set; }
        public short LocationID { get; set; }
        public short SalaryLevelID { get; set; }
        public short NumOfAutos { get; set; }
        public decimal AutoValue { get; set; }
        public short MileagePerYearID { get; set; }
        public decimal TransportationCost { get; set; }
        public virtual COLC_Location COLC_Location { get; set; }
        public virtual COLC_MileagePerYear COLC_MileagePerYear { get; set; }
        public virtual COLC_SalaryLevel COLC_SalaryLevel { get; set; }
    }
}
