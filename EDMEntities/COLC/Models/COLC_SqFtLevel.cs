using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_SqFtLevel
    {
        public COLC_SqFtLevel()
        {
            this.COLC_HousingExpense = new List<COLC_HousingExpense>();
        }

        public short SqFtLevelID { get; set; }
        public int SqFt { get; set; }
        public virtual ICollection<COLC_HousingExpense> COLC_HousingExpense { get; set; }
    }
}
