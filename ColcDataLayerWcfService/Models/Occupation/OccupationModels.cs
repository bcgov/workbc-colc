using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ColcDataLayerWcfService.Models.Occupation
{
    [DataContract]
    public class OccupationModels
    {
        [DataMember]
        public int NOC_ID { get; set; }

        [DataMember]
        public string NOCCode { get; set; }

        [DataMember]
        public string NameEnglish { get; set; }

        [DataMember]
        public Nullable<double> AvgSalary { get; set; }

        [DataMember]
        public string AlternativeJobTitles { get; set; }
    }
}