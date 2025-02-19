using System;
using System.Collections.Generic;

namespace EDMEntities.COLC.Models
{
    public partial class COLC_Location
    {
        public COLC_Location()
        {
            this.COLC_ConsumableHealthExpense = new List<COLC_ConsumableHealthExpense>();
            this.COLC_HousingExpense = new List<COLC_HousingExpense>();
            this.COLC_TransportationExpense = new List<COLC_TransportationExpense>();
        }

        public short LocationID { get; set; }
        public string LocationName { get; set; }
        public Nullable<short> ParentLocationID { get; set; }
        public byte LocationTypeID { get; set; }
        public virtual ICollection<COLC_ConsumableHealthExpense> COLC_ConsumableHealthExpense { get; set; }
        public virtual ICollection<COLC_HousingExpense> COLC_HousingExpense { get; set; }
        public virtual COLC_LocationType COLC_LocationType { get; set; }
        public virtual ICollection<COLC_TransportationExpense> COLC_TransportationExpense { get; set; }
    }
}
