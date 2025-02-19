using System;
using System.Collections.Generic;


namespace EDMEntities.Models.Custom
{
    public partial class IndustrySnapshotLatestView
    {
        public int SnapID { get; set; }
        public string Title { get; set; }
        public string MonthName { get; set; }
        public double EmploymentRate { get; set; }
        public int NumberOfJobs { get; set; }
    }
}
