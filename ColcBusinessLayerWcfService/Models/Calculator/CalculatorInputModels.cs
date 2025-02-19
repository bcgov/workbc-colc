
using System.Runtime.Serialization;
namespace ColcBusinessLayerWcfService.Models.Calculator
{

    /// <summary>
    /// Input model for the calculation 
    /// </summary>
    [DataContract]
    public class CalculatorInputModels
    {
        // Overview
        [DataMember]
        public int RegionID { get; set; } // Region (value in the dropdown)
        [DataMember]
        public int LocationID { get; set; } // Location (value in the city or neighbourhood dropdown)
        [DataMember]
        public string LocationName { get; set; } // City or neighbourhood
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

        // Options within Housing and Transportion Expenses
        [DataMember]
        public decimal? PropertyTaxAmount { get; set; } // Property tax
        [DataMember]
        public decimal? HomeInsuranceAmount { get; set; } // Home insurance
        [DataMember]
        public decimal? HouseMaintainanceAmount { get; set; } // House maintenance amount
        [DataMember]
        public decimal? CarInsuranceAmount { get; set; } // Car insurance amount

        // Living and Personal
        [DataMember]
        public int NumAdults { get; set; } // Number of adults
        [DataMember]
        public int NumChildren { get; set; } // Number of children
        [DataMember]
        public decimal? Salary2 { get; set; } // Second annual income

        // Options within Living and Personal
        [DataMember]
        public decimal? FoodAmount { get; set; } // Food
        [DataMember]
        public decimal? ClothingAmount { get; set; } // Clothing
        [DataMember]
        public decimal? EntertainmentAmount { get; set; } // Entertainment
        [DataMember]
        public decimal? FitnessAmount { get; set; } // Fitness
        [DataMember]
        public decimal? LifeInsuranceAmount { get; set; } // Life Insurance
        [DataMember]
        public decimal? GroomingAmount { get; set; } // Grooming
        [DataMember]
        public decimal? PetsAmount { get; set; } // Pets

        // Savings & Finance
        [DataMember]
        public decimal? OutstandingLoanPaymentsAmount { get; set; } // Outstanding loan payments
        [DataMember]
        public decimal? RRSPAmount { get; set; } // Retirement savings plan
        [DataMember]
        public decimal? RESP { get; set; } // Registered education savings plan
        [DataMember]
        public decimal? SavingsAmount { get; set; } // Savings
        [DataMember]
        public decimal? InvestmentAmount { get; set; } // Investment
    }
}