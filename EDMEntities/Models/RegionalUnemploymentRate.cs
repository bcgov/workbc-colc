using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class RegionalUnemploymentRate
    {
        private Nullable<double> rate = 0;
        public int RegionalProfileId { get; set; }
        public short Year { get; set; }
        public Nullable<double> Rate 
        {
            get { if (rate.HasValue) return rate; else return 0; }
            set { rate = value; }
        }
    }
}
