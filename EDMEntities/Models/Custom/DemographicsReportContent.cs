using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class DemographicsReportContent
    {
        public DemographicsReportContent()
        {

        }

        [Key]
        public int DemographicsReportContentID { get; set; }
        public int DemographicsReportID { get; set; }
        public int DemographicsReportSectionID { get; set; }
        public string Intro { get; set; }
        public string MainContent { get; set; }

        public virtual DemographicsReport Report { get; set; }
        public virtual DemographicsReportSection Section { get; set; }

    }
}


