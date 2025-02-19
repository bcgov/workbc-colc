using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class RegionalProfile
    {
        public int RegionalProfileId { get; set; }
        public string Overview { get; set; }
        public string KeyPoints { get; set; }
        public string PopulationDistribution { get; set; }
        public string Demographics { get; set; }
        public string WorkforceFullTime { get; set; }
        public string WorkforceUnemployed { get; set; }
        public string RegionRoleSummary { get; set; }
        public string RegionRoleServiceSector { get; set; }
        public string RegionRoleGoodsSector { get; set; }
        public string EmployDistributionSummary { get; set; }
        public string EmployDistributionServiceSector { get; set; }
        public string EmployDistributionGoodsSector { get; set; }
        public byte[] RegionalHeaderImage { get; set; }
        public virtual Location Location { get; set; }
        
        // Foot Notes
        public string TableGraph1FootNote { get; set; }
        public string TableGraph2FootNote { get; set; }
        public string TableGraph3FootNote { get; set; }
        public string TableGraph4FootNote { get; set; }
        public string TableGraph5FootNote { get; set; }
        public string TableGraph6FootNote { get; set; }
        public string TableGraph7FootNote { get; set; }
        public string TableGraph8FootNote { get; set; }
        public string TableGraph9FootNote { get; set; }
        public string TableGraph10FootNote { get; set; }
        public string TableGraph11FootNote { get; set; }
        public string TableGraph12FootNote { get; set; }

        // Meta data for each profile
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string PageKeywords { get; set; }
    }
}
