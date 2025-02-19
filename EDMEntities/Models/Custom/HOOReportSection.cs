using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class HOOReportSection
    {
        public HOOReportSection()
        {
        }

        [Key]
        public int HOOReportSectionID { get; set; }
        public string Name { get; set; }
        public string DataReference { get; set; }
        public int OrderValue { get; set; }

        public virtual List<HOOReportContent> Content { get; set; }


    }
}

