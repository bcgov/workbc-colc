using ColcBusinessLayerWcfService.Models.Calculator;
using ColcDataLayerWcfService;
using ColcDataLayerWcfService.Models.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcBusinessLayerWcfService.Controllers
{
    public class CalculatorController
    {
        private CalculatorInputModels _calculatorInput;
        private CalculatorDataOutputModels _calculatorDataOutput;
        private decimal _grossIncome;
        private const int MONTHS = 12;

        /// <summary>
        /// Calculates the yearly Cost of Living for each city or neighbourhood.
        /// </summary>
        /// <param name="calculatorInputModels">A list of inputs for the calculator. One item is for a city or neighbourhood.</param>
        /// <returns>A list of calculation results. One item is for a city or neighbourhood.</returns>
        public IEnumerable<CalculatorOutputModels> Calculate(IEnumerable<CalculatorInputModels> calculatorInputModels)
        {
            List<CalculatorOutputModels> listOutput = new List<CalculatorOutputModels>();
            List<CalculatorDataOutputModels> colcDataFromDatabase = GetCOLCDataFromDatabase(calculatorInputModels).ToList();
            int colcDataIndex = 0;

            foreach (ColcBusinessLayerWcfService.Models.Calculator.CalculatorInputModels input in calculatorInputModels)
            {
                CalculatorOutputModels output = new CalculatorOutputModels();
                _calculatorInput = input;
                _calculatorDataOutput = colcDataFromDatabase[colcDataIndex];
                _grossIncome = _calculatorInput.Salary1 + _calculatorInput.Salary2.GetValueOrDefault();
                              
                output.LocationID = _calculatorInput.LocationID;
                output.LocationName = _calculatorInput.LocationName;
                output.TotalIncome = Math.Round(_calculatorDataOutput.TotalIncome, 2, MidpointRounding.AwayFromZero);
                
                output.HousingAndTransportationExpense = Math.Round(CalculateHousingAndTransportationExpense(), 2, MidpointRounding.AwayFromZero);
                output.HousingExpense = Math.Round(CalculateHousingExpense(), 2, MidpointRounding.AwayFromZero);
                output.PropertyTaxExpense = Math.Round(_calculatorInput.PropertyTaxAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.HouseMaintenanceExpense = Math.Round(_calculatorInput.HouseMaintainanceAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.HomeInsuranceExpense = Math.Round(_calculatorInput.HomeInsuranceAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.TransportationExpense = Math.Round(CalculateTransportationExpense(), 2, MidpointRounding.AwayFromZero);
                output.CarInsuranceExpense = Math.Round(_calculatorInput.CarInsuranceAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                
                output.LivingAndPersonalExpense = Math.Round(CalculateLivingAndPersonalExpense(), 2, MidpointRounding.AwayFromZero);
                output.ConsumablesExpense = Math.Round(_calculatorDataOutput.ConsumableExpense, 2, MidpointRounding.AwayFromZero);
                output.HealthExpense = Math.Round(_calculatorDataOutput.HealthExpense, 2, MidpointRounding.AwayFromZero);
                output.FoodExpense = Math.Round(_calculatorInput.FoodAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.EntertainmentExpense = Math.Round(_calculatorInput.EntertainmentAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.LifeInsuranceExpense = Math.Round(_calculatorInput.LifeInsuranceAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.PetsExpense = Math.Round(_calculatorInput.PetsAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.ClothingExpense = Math.Round(_calculatorInput.ClothingAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.FitnessExpense = Math.Round(_calculatorInput.FitnessAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.GroomingExpense = Math.Round(_calculatorInput.GroomingAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);

                output.SavingsAndFinance = Math.Round(CalculateSavingsAndFinance(), 2, MidpointRounding.AwayFromZero);
                output.OutstandingLoanPayments = Math.Round(_calculatorInput.OutstandingLoanPaymentsAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.RegisteredEducationSavingsPlan = Math.Round(_calculatorInput.RESP.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.RetirementSavingsPlan = Math.Round(_calculatorInput.RRSPAmount.GetValueOrDefault() * MONTHS, 2, MidpointRounding.AwayFromZero);
                output.Savings = Math.Round(CalculateSavingsAmount(), 2, MidpointRounding.AwayFromZero);
                output.Investment = Math.Round(CalculateInvestmentAmount(), 2, MidpointRounding.AwayFromZero);

                output.BasicTaxForIncome1 = _calculatorDataOutput.BasicTaxForIncome1;
                output.BasicTaxForIncome2 = _calculatorDataOutput.BasicTaxForIncome2;
                output.Expenses = output.HousingAndTransportationExpense + output.LivingAndPersonalExpense + output.SavingsAndFinance + output.BasicTaxForIncome1 + output.BasicTaxForIncome2;
                output.Balance = output.TotalIncome - output.Expenses;

                listOutput.Add(output);

                colcDataIndex = colcDataIndex + 1;
            }           

            return listOutput;
        }

        /// <summary>
        /// Gets values for consumable expense, health expense, housing expense, transportation expense, and basic taxes that must be retrieved from the database.
        /// </summary>
        /// <param name="calculatorInputModels">A list of inputs for the calculator. One item is for a city or neighbourhood.</param>
        /// <returns>A list of outputs containing consumable expense, health expense, housing expense, transportation expense, and basic taxes. One item is for a city or neighbourhood. </returns>
        private IEnumerable<CalculatorDataOutputModels> GetCOLCDataFromDatabase(IEnumerable<CalculatorInputModels> calculatorInputModels)
        {
            List<CalculatorDataInputModels> listDataInput = new List<CalculatorDataInputModels>();
            IEnumerable<CalculatorDataOutputModels> listDataOutput = null;

            using (var colcDataLayerService = new ColcDataLayerService())
            {
                foreach(ColcBusinessLayerWcfService.Models.Calculator.CalculatorInputModels input in calculatorInputModels)
                {
                    CalculatorDataInputModels dataInput = new CalculatorDataInputModels();

                    dataInput.LocationID = input.LocationID;
                    dataInput.LocationName = input.LocationName;
                    dataInput.Salary1 = input.Salary1;
                    dataInput.Salary2 = input.Salary2;
                    dataInput.SqFtID = input.SqFtID;
                    dataInput.OwnIndicatorID = input.OwnIndicatorID;
                    dataInput.DownPaymentLevelID = input.DownPaymentLevelID;
                    dataInput.TransportationType = input.TransportationType;
                    dataInput.NumVehicles = input.NumVehicles;
                    dataInput.MileagePerYearID = input.MileagePerYearID;
                    dataInput.NumAdults = input.NumAdults;
                    dataInput.NumChildren = input.NumChildren;

                    listDataInput.Add(dataInput);
                }
                
                // Calls the database layer to get data from the database
                listDataOutput = colcDataLayerService.GetCOLCData(listDataInput);
            }

            return listDataOutput;
        }

        /// <summary>
        /// Adds housing, transportation, and options inside the Housing & Transportation expense section from the front-end 
        /// </summary>
        /// <returns>Combined housing and transportation expense per year</returns>
        private decimal CalculateHousingAndTransportationExpense()
        {
            decimal housingAndTransportationExpense = 0;
            decimal housingExpense = CalculateHousingExpense();
            decimal transportationExpense = CalculateTransportationExpense();
            decimal optionsExpense = CalculateHousingAndTransportationExpenseOptions();

            housingAndTransportationExpense = housingExpense + transportationExpense + optionsExpense;

            return housingAndTransportationExpense;
        }

        /// <summary>
        /// Sets housing expense value retrieved from the database layer
        /// </summary>
        /// <returns>Housing expense per year</returns>
        private decimal CalculateHousingExpense()
        {
            decimal housingExpense = _calculatorDataOutput.HousingExpense;
            return housingExpense;
        }
        
        /// <summary>
        /// Sets transportation expense value retrieved from the database layer.
        /// </summary>
        /// <returns>Housing expense per year</returns>
        private decimal CalculateTransportationExpense()
        {
            decimal transportationExpense = _calculatorDataOutput.TransportationExpense;
            return transportationExpense;
        }

        
        /// <summary>
        /// Adds options inside the Housing & Transportation expense section.
        /// </summary>
        /// <returns>Yearly sum of options from the Housing & Transportation expense section.</returns>
        private decimal CalculateHousingAndTransportationExpenseOptions()
        {
            decimal options = 0;

            options = _calculatorInput.PropertyTaxAmount.GetValueOrDefault() +
                        _calculatorInput.HomeInsuranceAmount.GetValueOrDefault() +
                        _calculatorInput.HouseMaintainanceAmount.GetValueOrDefault() +
                        _calculatorInput.CarInsuranceAmount.GetValueOrDefault();

            options = options * MONTHS;

            return options;
        }

        /// <summary>
        /// Adds consumable and health expense value from the database layer and options from the Living & Personal section.
        /// </summary>
        /// <returns>Living and personal expense per year</returns>
        private decimal CalculateLivingAndPersonalExpense()
        {
            decimal consumableHealthExpense = _calculatorDataOutput.ConsumableExpense + _calculatorDataOutput.HealthExpense + CalculateLivingAndPersonalExpenseOptions();
            return consumableHealthExpense;
        }

        /// <summary>
        /// Adds options from the Living & Personal expense section.
        /// </summary>
        /// <returns>Yearly sum of options from the Living & Personal expense section.</returns>
        private decimal CalculateLivingAndPersonalExpenseOptions()
        {
            decimal options = 0;

            options = _calculatorInput.FoodAmount.GetValueOrDefault() +
                        _calculatorInput.ClothingAmount.GetValueOrDefault() +
                        _calculatorInput.EntertainmentAmount.GetValueOrDefault() +
                        _calculatorInput.FitnessAmount.GetValueOrDefault() +
                        _calculatorInput.LifeInsuranceAmount.GetValueOrDefault() +
                        _calculatorInput.GroomingAmount.GetValueOrDefault() +
                        _calculatorInput.PetsAmount.GetValueOrDefault();

            options = options * MONTHS;

            return options;
        }

        /// <summary>
        /// Adds values from the Savings & Finance section.
        /// </summary>
        /// <returns>Yearly sum of values from the Savings & Finance section.</returns>
        private decimal CalculateSavingsAndFinance()
        {
            decimal savingsAndFinance = 0;

            decimal savingsAmount = CalculateSavingsAmount();
            decimal investmentAmount = CalculateInvestmentAmount();
           
            savingsAndFinance = (_calculatorInput.OutstandingLoanPaymentsAmount.GetValueOrDefault() * MONTHS) +
                                (_calculatorInput.RRSPAmount.GetValueOrDefault() * MONTHS) +
                                (_calculatorInput.RESP.GetValueOrDefault() * MONTHS) +
                                savingsAmount +
                                investmentAmount;

            return savingsAndFinance;
        }

        /// <summary>
        /// Calculates Savings Amount
        /// </summary>
        /// <returns>Yearly savings amount.</returns>
        private decimal CalculateSavingsAmount()
        {
            decimal savingsAmount = 0;

            if (_calculatorInput.SavingsAmount.HasValue)
            {
                savingsAmount = _grossIncome * (_calculatorInput.SavingsAmount.GetValueOrDefault() / 100);
            }

            return savingsAmount;
        }

        /// <summary>
        /// Calculates Investment Amount
        /// </summary>
        /// <returns>Yearly investment amount.</returns>
        private decimal CalculateInvestmentAmount()
        {
            decimal investmentAmount = 0;
            
            if (_calculatorInput.InvestmentAmount.HasValue)
            {
                investmentAmount = _grossIncome * (_calculatorInput.InvestmentAmount.GetValueOrDefault() / 100);
            }

            return investmentAmount;
        }

        /// <summary>
        /// Sets basic tax value retrieved from the database layer.
        /// </summary>
        /// <returns>Basic tax amount per year</returns>
        private decimal CalculateBasicTax()
        {
            decimal basicTax = _calculatorDataOutput.BasicTaxForIncome1 + _calculatorDataOutput.BasicTaxForIncome2;            
            return basicTax;
        }        
    }
}