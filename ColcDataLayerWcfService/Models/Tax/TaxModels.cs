using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ColcDataLayerWcfService.Models.Tax
{
    [DataContract]
    public class TaxModels
    {
        [DataMember]
        public short TaxID { get; set; }

        [DataMember]
        public byte TaxTypeID { get; set; }

        [DataMember]
        public decimal LowerIncomeAmount { get; set; }

        [DataMember]
        public Nullable<decimal> UpperIncomeAmount { get; set; }

        [DataMember]
        public decimal BaseIncomeAmount { get; set; }

        [DataMember]
        public decimal TaxRate { get; set; }

        [DataMember]
        public decimal CumulativeTaxAmount { get; set; }
    }
}