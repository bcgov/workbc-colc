using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ColcDataLayerWcfService.Models.SalaryLevel
{
    [DataContract]
    public class SalaryLevelModels
    {
        [DataMember]
        public short SalaryLevelID { get; set; }

        [DataMember]
        public decimal Salary { get; set; }
    }
}