using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class RegionalIndustryDetail
    {
        public int RegionalProfileId { get; set; }
        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public string Sector { get; set; }
        public Nullable<double> ShareOfJobs { get; set; }
        public Nullable<double> ShareOfEmployment { get; set; }
        public Nullable<bool> IsKeyIndustry { get; set; }
        public Nullable<int> AnnotationNumber { get; set; }
    }
}
