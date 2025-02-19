using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDMEntities.Models.Custom
{
    public partial class HOOLMIndicators
    {
        public HOOLMIndicators()
        {

        }

        [Key]
        public string NOC { get; set; }
        public int HOOReportID { get; set; }
        public string OccupationCategoryID { get; set; }
        public string OccupationCategoryName { get; set; }
        public string OccupationName { get; set; }
        public int EmploymentSize { get; set; }
        public int JobOpenings { get; set; }
        public int ProjectedUnemploymentRate { get; set; }
        public string Education { get; set; }

        public virtual HOOReport Report { get; set; }

    }
}

