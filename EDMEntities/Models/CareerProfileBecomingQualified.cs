using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class CareerProfileBecomingQualified
    {
        public int BecomingQualifiedID { get; set; }
        public int CareerProfileID { get; set; }
        public short CareerLicensingID { get; set; }
        public string TotalApproximateFees { get; set; }
        public string TotalApproximateFeesNote { get; set; }
        public string EstimatedTime { get; set; }
        public string EstimatedTimeNote { get; set; }
        public string BecomingQualifiedHeader { get; set; }
        public string BecomingQualifiedContent { get; set; }
        public string JobTitle { get; set; }

        public virtual CareerProfile CareerProfile { get; set; }
        public virtual CareerLicensing CareerLicensing { get; set; }
    }
}
