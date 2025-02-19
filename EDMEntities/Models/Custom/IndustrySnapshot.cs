using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Custom
{
    public class IndustrySnapshot
    {
        public int NAICS { get; set; }
        public string Title { get; set; }
        public string MonthName { get; set; }
        public string EmploymentRate { get; set; }
        public string TotalEmployment { get; set; } //Display total current employment on Industry Landing Page
        /// <summary>
        /// For displaying "+" if the employment rate is positive
        /// </summary>
        public bool? IsEmploymentRatePositive { get; set; }
        public string NumberOfJobs { get; set; }
        /// <summary>
        /// For displaying "+" if the number of jobs is positive
        /// </summary>
        public bool? IsNumberOfJobsPositive { get; set; }

        public IndustrySnapshot()
        {
            EmploymentRate = "N/A";
            NumberOfJobs = "N/A";
            TotalEmployment = "";
        }

        public string ImageUrl { get; set; }

        public int? AnnotationNumber { get; set; }
    }
}
