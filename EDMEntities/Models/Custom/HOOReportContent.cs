using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class HOOReportContent
    {
        public HOOReportContent()
        {

        }

        [Key]
        public int HOOReportContentID { get; set; }
        public int HOOReportID { get; set; }
        public int HOOReportSectionID { get; set; }
        public string Intro { get; set; }
        public string MainContent { get; set; }

        public virtual HOOReport Report { get; set; }
        public virtual HOOReportSection Section { get; set; }

    }
}


