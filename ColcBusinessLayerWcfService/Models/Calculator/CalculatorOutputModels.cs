using System.Runtime.Serialization;
namespace ColcBusinessLayerWcfService.Models.Calculator
{
    /// <summary>
    /// Output model for the calculation 
    /// </summary>
    [DataContract]
    public class CalculatorOutputModels
    {
        [DataMember]
        public int LocationID { get; set; } // Location ID of the City
        [DataMember]
        public string LocationName { get; set; } // City or neighbourhood
        
        [DataMember]
        public decimal TotalIncome { get; set; } // First annual income + second annual income.
        
        [DataMember]
        public decimal HousingAndTransportationExpense { get; set; } // Housing and Transportation Expense        
        [DataMember]
        public decimal HousingExpense { get; set; } // Housing Expense
        [DataMember]
        public decimal PropertyTaxExpense { get; set; } // Property Tax Expense 
        [DataMember]
        public decimal HouseMaintenanceExpense { get; set; } // House Maintenenance Expense
        [DataMember]
        public decimal HomeInsuranceExpense { get; set; } // Home Insurance Expense
        [DataMember]
        public decimal TransportationExpense { get; set; } // Transportation Expense        
        [DataMember]
        public decimal CarInsuranceExpense { get; set; } // Car Insurance Expense
              
        [DataMember]
        public decimal LivingAndPersonalExpense { get; set; } // Living and Personal Expense
        [DataMember]
        public decimal ConsumablesExpense { get; set; } // Consumerables Expense
        [DataMember]
        public decimal HealthExpense { get; set; } // Health Expense
        [DataMember]
        public decimal FoodExpense { get; set; } // Food Expense
        [DataMember]
        public decimal EntertainmentExpense { get; set; } // Entertainment Expense
        [DataMember]
        public decimal LifeInsuranceExpense { get; set; } // Life Insurance Expense
        [DataMember]
        public decimal PetsExpense { get; set; } // Pets Expense
        [DataMember]
        public decimal ClothingExpense { get; set; } // Clothing Expense
        [DataMember]
        public decimal FitnessExpense { get; set; } // Fitness Expense
        [DataMember]
        public decimal GroomingExpense { get; set; } // Grooming Expense

        [DataMember]
        public decimal SavingsAndFinance { get; set; } // Savings and Finance Expense
        [DataMember]
        public decimal OutstandingLoanPayments { get; set; } // Outstanding Loan Payments
        [DataMember]
        public decimal RetirementSavingsPlan { get; set; } // Retirement Savings Plan
        [DataMember]
        public decimal RegisteredEducationSavingsPlan { get; set; } // Registered Education Savings Plan
        [DataMember]
        public decimal Savings { get; set; } // Savings
        [DataMember]
        public decimal Investment { get; set; } // Investment

        [DataMember]
        public decimal BasicTaxForIncome1 { get; set; } // Basic Tax Expense for the first annual income.
        [DataMember]
        public decimal BasicTaxForIncome2 { get; set; } // Basic Tax Expense for the second annual income.
        [DataMember]
        public decimal Expenses { get; set; } // Expenses (Income - HousingAndTransportationExpense - LivingAndPersonalExpense - SavingsAndFinance - BasicTax)
        [DataMember]
        public decimal Balance { get; set; } // Balance (Income - Expense)
    }
}