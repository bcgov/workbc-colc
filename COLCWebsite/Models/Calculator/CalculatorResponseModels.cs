using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLC.COLCWebsite.Models.Calculator
{
    /// <summary>
    /// Output model for the calculation 
    /// </summary>
    public class CalculatorResponseModels
    {
        public int LocationID { get; set; } // Location ID of the City
        public string LocationName { get; set; } // City or neighbourhood
        
        //***** BY MONTH *****/
        
        //** Monthly Income **//
        public string IncomeByMonth { get; set; } // Income By Month

        //** Monthly Housing & Transportation **//
        public string HousingAndTransportationExpenseByMonth { get; set; } // Housing and Transportation Expense By Month
        public string HousingExpenseByMonth { get; set; } // Housing Expense By Year
        public string PropertyTaxExpenseByMonth { get; set; } // Property Tax Expense By Month
        public string HouseMaintenanceExpenseByMonth { get; set; } // House Maintenenance Expense By Month
        public string HomeInsuranceExpenseByMonth { get; set; } // Home Insurance Expense by Month
        public string TransportationExpenseByMonth { get; set; } // Transportation Expense by Month
        public string CarInsuranceExpenseByMonth { get; set; } // Car Insurance Expense by Month
       
        //** Monthly Living & Personal **//
        public string LivingAndPersonalExpenseByMonth { get; set; } // Living and Personal Expense By Month
        public string ConsumablesExpenseByMonth { get; set; } // Consumerables Expense By Month
        public string HealthExpenseByMonth { get; set; } // Health Expense By Month
        public string FoodExpenseByMonth { get; set; } // Food Expense By Month
        public string EntertainmentExpenseByMonth { get; set; } // Entertainment Expense By Month
        public string LifeInsuranceExpenseByMonth { get; set; } // Life Insurance Expense By Month
        public string PetsExpenseByMonth { get; set; } // Pets Expense By Month
        public string ClothingExpenseByMonth { get; set; } // Clothing Expense By Month
        public string FitnessExpenseByMonth { get; set; } // Fitness Expense By Month
        public string GroomingExpenseByMonth { get; set; } // Grooming Expense By Month
        

        //** Monthly Savings & Finance **//
        public string SavingsAndFinanceByMonth { get; set; } // Savings and Finance Expense By Month
        public string OutstandingLoanPaymentsByMonth { get; set; } // Outstanding Loan Payments By Month
        public string RetirementSavingsPlanByMonth { get; set; } // Retirement Savings Plan By Month
        public string RegisteredEducationSavingsPlanByMonth { get; set; } // Registered Education Savings Plan By Month
        public string SavingsByMonth { get; set; } // Savings By Month
        public string InvestmentByMonth { get; set; } // Investment By Month
      
        //** Monthly Basic Tax **//
        public string BasicTaxByMonth { get; set; } // Basic Tax Expense By Month
        
        //** Monthly Expenses **//
        public string ExpensesByMonth { get; set; } // Expenses By Month(HousingAndTransportationExpenseByMonth + LivingAndPersonalExpenseByMonth + SavingsAndFinanceByMonth + BasicTaxByMonth)
        
        //** Monthly Balance (AKA Remaining) **//
        public string BalanceByMonth { get; set; } // Balance By Month(IncomeByMonth - ExpensesByMonth)
        

        //***** BY YEAR *****/

        //** Yearly Income **//
        public string IncomeByYear { get; set; } // Income By Year

        //** Yearly Housing & Transportation **//
        public string HousingAndTransportationExpenseByYear { get; set; } // Housing and Transportation Expense By Year
        public string HousingExpenseByYear { get; set; } // Housing Expense By Year
        public string PropertyTaxExpenseByYear { get; set; } // Property Tax Expense By Year
        public string HouseMaintenanceExpenseByYear { get; set; } // House Maintenenance Expense By Year
        public string HomeInsuranceExpenseByYear { get; set; } // Home Insurance Expense by Year
        public string TransportationExpenseByYear { get; set; } // Transportation Expense by Year
        public string CarInsuranceExpenseByYear { get; set; } // Car Insurance Expense by Year
        

        //** Yearly Living & Personal **//
        public string LivingAndPersonalExpenseByYear { get; set; } // Living and Personal Expense By Year
        public string ConsumablesExpenseByYear { get; set; } // Consumerables Expense By Year
        public string HealthExpenseByYear { get; set; } // Health Expense By Year
        public string FoodExpenseByYear { get; set; } // Food Expense By Year
        public string EntertainmentExpenseByYear { get; set; } // Entertainment Expense By Year
        public string LifeInsuranceExpenseByYear { get; set; } // Life Insurance Expense By Year
        public string PetsExpenseByYear { get; set; } // Pets Expense By Year
        public string ClothingExpenseByYear { get; set; } // Clothing Expense By Year
        public string FitnessExpenseByYear { get; set; } // Fitness Expense By Year
        public string GroomingExpenseByYear { get; set; } // Grooming Expense By Year
              

        //** Yearly Savings & Finance **//
        public string SavingsAndFinanceByYear { get; set; } // Savings and Finance Expense By Year
        public string OutstandingLoanPaymentsByYear { get; set; } // Outstanding Loan Payments By Year
        public string RetirementSavingsPlanByYear { get; set; } // Retirement Savings Plan By Year
        public string RegisteredEducationSavingsPlanByYear { get; set; } // Registered Education Savings Plan By Year
        public string SavingsByYear { get; set; } // Savings By Year
        public string InvestmentByYear { get; set; } // Investment By Year        
       
        //** Yearly Basic Tax **//
        public string BasicTaxByYear { get; set; } // Basic Tax Expense By Year

        //** Yearly Expenses **//
        public string ExpensesByYear { get; set; } // Expenses By Year (HousingAndTransportationExpenseByYear+ LivingAndPersonalExpenseByYear + SavingsAndFinanceByYear + BasicTaxByYear) By Year

        //** Yearly Balance (AKA Remaining) **//
        public string BalanceByYear { get; set; } // Balance By Year (Income By Year - Expenses By Year)
    }
}