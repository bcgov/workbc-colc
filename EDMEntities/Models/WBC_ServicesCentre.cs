using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class WBC_ServicesCentre
    {
        public int ServicesCentreID { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public short ProvinceID { get; set; }
        public string PostalCode { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string StoreFront { get; set; }
        public Nullable<bool> EnglishService { get; set; }
        public Nullable<bool> FrenchService { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string OpeningHours { get; set; }
        public int CatchmentAreaID { get; set; }
        public int ServicesCentreContractorID { get; set; }
        public virtual WBC_CatchmentArea WBC_CatchmentArea { get; set; }
        public virtual WBC_Province WBC_Province { get; set; }
        public virtual WBC_ServicesCentreContractor WBC_ServicesCentreContractor { get; set; }
    }
}
