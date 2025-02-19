using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ColcDataLayerWcfService.Models.Calculator
{
    [DataContract]
    public class CalculatorDataInputModels
    {
        // Overview
        [DataMember]
        public int LocationID { get; set; } // Location (value in the city or neighbourhood dropdown)
        [DataMember]
        public string LocationName { get; set; }
        [DataMember]
        public decimal Salary1 { get; set; } // First annual income

        // Housing Expenses
        [DataMember]
        public int SqFtID { get; set; } // Home size (value in the dropdown)
        [DataMember]
        public int OwnIndicatorID { get; set; } // Rent or own (value in the dropdown)
        [DataMember]
        public int DownPaymentLevelID { get; set; } // Down payment (value in the dropdown)
               
        // Transportation Expenses
        [DataMember]
        public int TransportationType { get; set; } // Transportation type
        [DataMember]
        public int NumVehicles { get; set; } // Number of vehicles
        [DataMember]
        public int MileagePerYearID { get; set; } // Travel km/day (value in the dropdown)
                
        // Living and Personal
        [DataMember]
        public int NumAdults { get; set; } // Number of adults
        [DataMember]
        public int NumChildren { get; set; } // Number of children
        [DataMember]
        public decimal? Salary2 { get; set; } // Second annual income        
    }
}