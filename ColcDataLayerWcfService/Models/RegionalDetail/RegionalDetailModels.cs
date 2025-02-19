using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ColcDataLayerWcfService.Models.RegionalDetail
{
    [DataContract]
    public class RegionalDetailModels
    {
        [DataMember]
        public int LocationID { get; set; }

        [DataMember]
        public string LocationName { get; set; }

        [DataMember]
        public string KeyCities { get; set; }

        [DataMember]
        public double ForecastedAnnualEmploymentGrowth { get; set; }

        [DataMember]
        public int DataYearStart { get; set; }

        [DataMember]
        public int DataYearMidpoint { get; set; }

        [DataMember]
        public int DataYearEnd { get; set; }

        [DataMember]
        public double EmploymentGrowthStartOfOutlook { get; set; }

        [DataMember]
        public double EmploymentGrowthMidpointOfOutlook { get; set; }

        [DataMember]
        public double EmploymentGrowthEndOfOutlook { get; set; }

        [DataMember]
        public double TotalEmploymentIncrease { get; set; }

        [DataMember]
        public string TopNOCCode1 { get; set; }

        [DataMember]
        public string TopOccupation1 { get; set; }

        [DataMember]
        public string TopNOCCode2 { get; set; }

        [DataMember]
        public string TopOccupation2 { get; set; }

        [DataMember]
        public string TopNOCCode3 { get; set; }

        [DataMember]
        public string TopOccupation3 { get; set; }
    }
}