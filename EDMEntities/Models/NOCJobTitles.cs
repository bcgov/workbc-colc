using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class NOCJobTitles
    {
        public int NOCJobTitleID { get; set; }
        public int NOC_ID { get; set; }
        public string EnglishTitle { get; set; }
        public string FrenchTitle { get; set; }
        public virtual NOC NOC { get; set; }
    }
}
