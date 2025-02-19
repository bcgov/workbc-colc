using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLC.COLCWebsite.Models.OccupationSalary
{
    /// <summary>
    /// Model for the occupation and salary textboxes
    /// </summary>
    public class OccupationSalaryModels
    {
        public string NOCCode { get; set; }
        public string NameEnglish { get; set; }
        public Nullable<double> AvgSalary { get; set; }
        public string AlternativeJobTitles { get; set; }
    }
}