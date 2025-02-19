using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class DemographicsReportSection
    {
        public DemographicsReportSection()
        {
        }

        [Key]
        public int DemographicsReportSectionID { get; set; }
        public string Name { get; set; }
        public string DataReference { get; set; }
        public string LinkText { get; set; }
        public int OrderValue { get; set; }

        public virtual List<DemographicsReportContent> Content { get; set; }


    }
}

