using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ColcDataLayerWcfService.Models.Calculator
{
    [DataContract]
    public class CalculatorDataOutputModels
    {
        [DataMember]
        public int LocationID { get; set; } // Location ID of the City
        [DataMember]
        public string LocationName { get; set; } // City
        [DataMember]
        public decimal TotalIncome { get; set; } // First annual income + second annual income
        [DataMember]
        public decimal ConsumableExpense { get; set; } // ConsumableHealthExpense amount from the database
        [DataMember]
        public decimal HealthExpense { get; set; } // HealthExpense amount from the database
        [DataMember]
        public decimal HousingExpense { get; set; } // HouseExpense amount from the database
        [DataMember]
        public decimal TransportationExpense { get; set; } // TransportationExpense amount from the database
        [DataMember]
        public decimal BasicTaxForIncome1 { get; set; } // Basic Tax Expense for the first income from the database      
        [DataMember]
        public decimal BasicTaxForIncome2 { get; set; } // Basic Tax Expense for the second incme from the database   
    }
}