using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class HOOReport
    {
        public HOOReport()
        {

        }

        [Key]
        public int HOOReportID { get; set; }
        public DateTime DatePublished { get; set; }
        public Nullable<bool> IsPublished { get; set; }


        // content
        public virtual List<HOOReportContent> Content { get; set; }
        // Labour Market Indicators
        public virtual List<HOOLMIndicators> LMIndicators { get; set; }


    }
}

