using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_MileagePerYear
    {
        public COLC_MileagePerYear()
        {
            this.COLC_TransportationExpense = new List<COLC_TransportationExpense>();
        }

        public short MileagePerYearID { get; set; }
        public int Mileage { get; set; }
        public virtual ICollection<COLC_TransportationExpense> COLC_TransportationExpense { get; set; }
    }
}
