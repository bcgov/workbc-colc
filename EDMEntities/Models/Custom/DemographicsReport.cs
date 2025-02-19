using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class DemographicsReport
    {
        public DemographicsReport()
        {

        }

        [Key] 
        public int DemographicsReportID { get; set; }
        public int Year { get; set; }
        public Nullable<bool> IsPublished { get; set; }
        public string PDFLink { get; set; }


        // content
        public virtual List<DemographicsReportContent> Content { get; set; }


    }
}

