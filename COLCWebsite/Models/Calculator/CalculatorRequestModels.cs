using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLC.COLCWebsite.Models.Calculator
{
    /// <summary>
    /// Input model for the calculation 
    /// </summary>
    public class CalculatorRequestModels
    {
        private int _downPaymentLevelID;

        // Default values 
        public CalculatorRequestModels()
        {
            // Housing Expenses
            SqFtID = 1; // ID for 500 square feet in the COLC_SqFtLevel table
            OwnIndicatorID = 1; // ID for Rent in the COLC_OwnIndicator table
            DownPaymentLevelID = 1; // ID for 0.00 down payment in the COLC_DownPaymentLevel table

            // Transportation Expenses
            TransportationType = 1; // Default to car
            NumVehicles = 0;
            MileagePerYearID = 1; // ID for 0 mileage in the COLC_MileagePerYear table

            // Options within Housing and Transportion Expenses
            PropertyTaxAmount = 0;
            HomeInsuranceAmount = 0;
            HouseMaintainanceAmount = 0;
            CarInsuranceAmount = 0;

            // Living and Personal
            NumAdults = 1;
            NumChildren = 0;
            Salary2 = 0;

            // Options within Living and Personal
            FoodAmount = 0;
            ClothingAmount = 0;
            EntertainmentAmount = 0;
            FitnessAmount = 0;
            LifeInsuranceAmount = 0;
            GroomingAmount = 0;
            PetsAmount = 0;

            // Savings & Finance
            OutstandingLoanPaymentsAmount = 0;
            RRSPAmount = 0;
            RESP = 0;
            SavingsAmount = 0;
            InvestmentAmount = 0;
        }


        // Overview
        public int RegionID { get; set; } // Region (value in the dropdown)
        public int LocationID { get; set; } // Location ID (value in the city or neighbourhood dropdown)
        public string LocationName { get; set; } // City or neighbourhood
        public decimal Salary1 { get; set; } // First annual income

        // Housing Expenses
        public int SqFtID { get; set; } // Home size (value in the dropdown)
        public int OwnIndicatorID { get; set; } // Rent or own (value in the dropdown)
        public int DownPaymentLevelID
        {
            get
            {
                return _downPaymentLevelID;
            }
            set
            {
                if (OwnIndicatorID == 1) // If the Rent/Own drop is set to "Rent", set the DownPaymentID to 1 (0% down payment).
                {
                    _downPaymentLevelID = 1;
                }
                else
                {
                    _downPaymentLevelID = value;
                }
            }

        } // Down payment (value in the dropdown)

        // Transportation Expenses
        public int TransportationType { get; set; } // Transportation type (1 = Car; 2 = Public transportation; 3 = Walk; 4 = Bike) 
        public int NumVehicles { get; set; } // Number of vehicles
        public int MileagePerYearID { get; set; } // Travel km/day (value in the dropdown)

        // Options within Housing and Transportion Expenses
        public decimal? PropertyTaxAmount { get; set; } // Property tax
        public decimal? HomeInsuranceAmount { get; set; } // Home insurance
        public decimal? HouseMaintainanceAmount { get; set; } // House maintenance amount
        public decimal? CarInsuranceAmount { get; set; } // Car insurance amount

        // Living and Personal
        public int NumAdults { get; set; } // Number of adults
        public int NumChildren { get; set; } // Number of children
        public decimal? Salary2 { get; set; } // Second annual income

        // Options within Living and Personal
        public decimal? FoodAmount { get; set; } // Food
        public decimal? ClothingAmount { get; set; } // Clothing
        public decimal? EntertainmentAmount { get; set; } // Entertainment
        public decimal? FitnessAmount { get; set; } // Fitness
        public decimal? LifeInsuranceAmount { get; set; } // Life Insurance
        public decimal? GroomingAmount { get; set; } // Grooming
        public decimal? PetsAmount { get; set; } // Pets

        // Savings & Finance
        public decimal? OutstandingLoanPaymentsAmount { get; set; } // Outstanding loan payments
        public decimal? RRSPAmount { get; set; } // Retirement savings plan
        public decimal? RESP { get; set; } // Registered education savings plan
        public decimal? SavingsAmount { get; set; } // Savings
        public decimal? InvestmentAmount { get; set; } // Investment

    }
}