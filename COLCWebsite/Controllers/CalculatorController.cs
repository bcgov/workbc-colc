using COLC.COLCWebsite.Helpers;
using COLC.COLCWebsite.Models.Calculator;
using ColcBusinessLayerWcfService;
using ColcBusinessLayerWcfService.Models.Calculator;
using ColcBusinessLayerWcfService.Models.RegionalDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace COLC.COLCWebsite.Controllers
{
    /// <summary>
    /// Endpoint used by the front-end to make a AJAX calls to get Cost of Living Calculations and regional details
    /// </summary>
    public class CalculatorController : ApiController
    {
        
        /// <summary>
        /// Calculates the monthly and yearly Cost of Living for each city or neighbourhood.
        /// 
        /// Sample calcuations can be found in the Monthly Expenses and Annual Expenses tabs in \docs\media\COLC\Latest-COLC-Data-Mapping-Sheet.xlsx
        /// </summary>
        /// <param name="request">A list of inputs for the calculator. One item is for a city or neighbourhood.</param>
        /// <returns>A list of calculation results. One item is for a city or neighbourhood. </returns>
        public IEnumerable<CalculatorResponseModels> Calculate(IEnumerable<CalculatorRequestModels> request)
        {

            List<CalculatorInputModels> listCalculatorInput = new List<CalculatorInputModels>();
            IEnumerable<CalculatorOutputModels> listCalculatorOutput = new List<CalculatorOutputModels>();
            List<CalculatorResponseModels> listCalcResponses = new List<CalculatorResponseModels>();

            foreach (CalculatorRequestModels r in request)
            {
                CalculatorInputModels calculatorInput = Mapper.Map<CalculatorInputModels>(r);
                listCalculatorInput.Add(calculatorInput);
            }

            using (var colcBusinessLayerService = new ColcBusinessLayerService())
            {
                // Pass inputs from the front-end to the business layer.
                listCalculatorOutput = colcBusinessLayerService.Calculate(listCalculatorInput);

                foreach (CalculatorOutputModels calculatorOutput in listCalculatorOutput)
                {
                    CalculatorResponseModels calcResponse = new CalculatorResponseModels();

                    calcResponse.LocationID = calculatorOutput.LocationID;
                    calcResponse.LocationName = calculatorOutput.LocationName;
                                       
                    // Monthly Amounts
                    decimal incomeByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.TotalIncome);
                                        
                    decimal housingExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.HousingExpense);
                    decimal propertyTaxExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.PropertyTaxExpense);
                    decimal houseMaintenanceExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.HouseMaintenanceExpense);
                    decimal homeInsuranceExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.HomeInsuranceExpense);
                    decimal transportationExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.TransportationExpense);
                    decimal carInsuranceExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.CarInsuranceExpense);
                    decimal housingAndTransportationExpenseByMonth = housingExpenseByMonth +
                                                                     propertyTaxExpenseByMonth +
                                                                     houseMaintenanceExpenseByMonth +
                                                                     homeInsuranceExpenseByMonth +
                                                                     transportationExpenseByMonth +
                                                                     carInsuranceExpenseByMonth;

                    decimal consumablesExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.ConsumablesExpense);
                    decimal healthExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.HealthExpense);
                    decimal foodExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.FoodExpense);
                    decimal entertainmentExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.EntertainmentExpense);
                    decimal lifeInsuranceExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.LifeInsuranceExpense);
                    decimal petsExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.PetsExpense);
                    decimal clothingExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.ClothingExpense);
                    decimal fitnessExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.FitnessExpense);
                    decimal groomingExpenseByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.GroomingExpense);
                    decimal livingAndPersonalExpenseByMonth = consumablesExpenseByMonth +
                                                              healthExpenseByMonth +
                                                              foodExpenseByMonth +
                                                              entertainmentExpenseByMonth +
                                                              lifeInsuranceExpenseByMonth +
                                                              petsExpenseByMonth +
                                                              clothingExpenseByMonth +
                                                              fitnessExpenseByMonth +
                                                              groomingExpenseByMonth;
                    
                    decimal outstandingLoanPaymentsByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.OutstandingLoanPayments);
                    decimal retirementSavingsPlanByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.RetirementSavingsPlan);
                    decimal registeredEducationSavingsPlanByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.RegisteredEducationSavingsPlan);
                    decimal savingsByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.Savings);
                    decimal investmentByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.Investment);
                    decimal savingsAndFinanceByMonth = outstandingLoanPaymentsByMonth +
                                                       retirementSavingsPlanByMonth +
                                                       registeredEducationSavingsPlanByMonth +
                                                       savingsByMonth +
                                                       investmentByMonth;

                    decimal basicTaxByMonth = PresentationHelper.ConvertToMonthly(calculatorOutput.BasicTaxForIncome1) +  PresentationHelper.ConvertToMonthly(calculatorOutput.BasicTaxForIncome2);
                    decimal expensesByMonth = housingAndTransportationExpenseByMonth +
                                              livingAndPersonalExpenseByMonth +
                                              savingsAndFinanceByMonth +
                                              basicTaxByMonth;
                    decimal balanceByMonth = incomeByMonth - expensesByMonth;

                    calcResponse.IncomeByMonth = PresentationHelper.ConvertAmountToString(incomeByMonth);

                    calcResponse.HousingAndTransportationExpenseByMonth = PresentationHelper.ConvertAmountToString(housingAndTransportationExpenseByMonth);
                    calcResponse.HousingExpenseByMonth = PresentationHelper.ConvertAmountToString(housingExpenseByMonth);
                    calcResponse.PropertyTaxExpenseByMonth = PresentationHelper.ConvertAmountToString(propertyTaxExpenseByMonth);
                    calcResponse.HouseMaintenanceExpenseByMonth= PresentationHelper.ConvertAmountToString(houseMaintenanceExpenseByMonth);
                    calcResponse.HomeInsuranceExpenseByMonth = PresentationHelper.ConvertAmountToString(homeInsuranceExpenseByMonth);
                    calcResponse.TransportationExpenseByMonth = PresentationHelper.ConvertAmountToString(transportationExpenseByMonth);
                    calcResponse.CarInsuranceExpenseByMonth = PresentationHelper.ConvertAmountToString(carInsuranceExpenseByMonth);
                    
                    calcResponse.LivingAndPersonalExpenseByMonth = PresentationHelper.ConvertAmountToString(livingAndPersonalExpenseByMonth);
                    calcResponse.ConsumablesExpenseByMonth = PresentationHelper.ConvertAmountToString(consumablesExpenseByMonth);
                    calcResponse.HealthExpenseByMonth = PresentationHelper.ConvertAmountToString(healthExpenseByMonth);
                    calcResponse.FoodExpenseByMonth = PresentationHelper.ConvertAmountToString(foodExpenseByMonth);
                    calcResponse.EntertainmentExpenseByMonth = PresentationHelper.ConvertAmountToString(entertainmentExpenseByMonth);
                    calcResponse.LifeInsuranceExpenseByMonth = PresentationHelper.ConvertAmountToString(lifeInsuranceExpenseByMonth);
                    calcResponse.PetsExpenseByMonth = PresentationHelper.ConvertAmountToString(petsExpenseByMonth);
                    calcResponse.ClothingExpenseByMonth = PresentationHelper.ConvertAmountToString(clothingExpenseByMonth);
                    calcResponse.FitnessExpenseByMonth = PresentationHelper.ConvertAmountToString(fitnessExpenseByMonth);
                    calcResponse.GroomingExpenseByMonth = PresentationHelper.ConvertAmountToString(groomingExpenseByMonth);
                    
                    calcResponse.SavingsAndFinanceByMonth = PresentationHelper.ConvertAmountToString(savingsAndFinanceByMonth);
                    calcResponse.OutstandingLoanPaymentsByMonth = PresentationHelper.ConvertAmountToString(outstandingLoanPaymentsByMonth);
                    calcResponse.RetirementSavingsPlanByMonth = PresentationHelper.ConvertAmountToString(retirementSavingsPlanByMonth);
                    calcResponse.RegisteredEducationSavingsPlanByMonth = PresentationHelper.ConvertAmountToString(registeredEducationSavingsPlanByMonth);
                    calcResponse.SavingsByMonth = PresentationHelper.ConvertAmountToString(savingsByMonth);
                    calcResponse.InvestmentByMonth = PresentationHelper.ConvertAmountToString(investmentByMonth); 

                    calcResponse.BasicTaxByMonth = PresentationHelper.ConvertAmountToString(basicTaxByMonth);
                    calcResponse.ExpensesByMonth = PresentationHelper.ConvertAmountToString(expensesByMonth);
                    calcResponse.BalanceByMonth = PresentationHelper.ConvertAmountToString(balanceByMonth);

                    // Yearly Amounts
                    decimal incomeByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.TotalIncome);
                    
                    decimal housingAndTransportationExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.HousingAndTransportationExpense);
                    decimal housingExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.HousingExpense);
                    decimal propertyTaxExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.PropertyTaxExpense);
                    decimal houseMaintenanceExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.HouseMaintenanceExpense);
                    decimal homeInsuranceExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.HomeInsuranceExpense);
                    decimal transportationExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.TransportationExpense);
                    decimal carInsuranceExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.CarInsuranceExpense);
                    
                    decimal livingAndPersonalExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.LivingAndPersonalExpense);
                    decimal consumablesExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.ConsumablesExpense);
                    decimal healthExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.HealthExpense);
                    decimal foodExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.FoodExpense);
                    decimal entertainmentExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.EntertainmentExpense);
                    decimal lifeInsuranceExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.LifeInsuranceExpense);
                    decimal petsExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.PetsExpense);
                    decimal clothingExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.ClothingExpense);
                    decimal fitnessExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.FitnessExpense);
                    decimal groomingExpenseByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.GroomingExpense);                     
                    
                    decimal savingsAndFinanceByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.SavingsAndFinance);
                    decimal outstandingLoanPaymentsByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.OutstandingLoanPayments);
                    decimal retirementSavingsPlanByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.RetirementSavingsPlan);
                    decimal registeredEducationSavingsPlanByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.RegisteredEducationSavingsPlan);
                    decimal savingsByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.Savings);
                    decimal investmentByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.Investment); 
                    
                    decimal basicTaxByYear = PresentationHelper.RoundYearlyAmount(calculatorOutput.BasicTaxForIncome1) + PresentationHelper.RoundYearlyAmount(calculatorOutput.BasicTaxForIncome2);
                    decimal expensesByYear = housingAndTransportationExpenseByYear +
                                              livingAndPersonalExpenseByYear +
                                              savingsAndFinanceByYear +
                                              basicTaxByYear;
                    decimal balanceByYear = incomeByYear - expensesByYear;

                    calcResponse.IncomeByYear = PresentationHelper.ConvertAmountToString(incomeByYear);
                    
                    calcResponse.HousingAndTransportationExpenseByYear = PresentationHelper.ConvertAmountToString(housingAndTransportationExpenseByYear);
                    calcResponse.HousingExpenseByYear = PresentationHelper.ConvertAmountToString(housingExpenseByYear);
                    calcResponse.PropertyTaxExpenseByYear = PresentationHelper.ConvertAmountToString(propertyTaxExpenseByYear);
                    calcResponse.HouseMaintenanceExpenseByYear = PresentationHelper.ConvertAmountToString(houseMaintenanceExpenseByYear);
                    calcResponse.HomeInsuranceExpenseByYear = PresentationHelper.ConvertAmountToString(homeInsuranceExpenseByYear);
                    calcResponse.TransportationExpenseByYear = PresentationHelper.ConvertAmountToString(transportationExpenseByYear);
                    calcResponse.CarInsuranceExpenseByYear = PresentationHelper.ConvertAmountToString(carInsuranceExpenseByYear);                    
                    
                    calcResponse.LivingAndPersonalExpenseByYear = PresentationHelper.ConvertAmountToString(livingAndPersonalExpenseByYear);
                    calcResponse.ConsumablesExpenseByYear = PresentationHelper.ConvertAmountToString(consumablesExpenseByYear);
                    calcResponse.HealthExpenseByYear = PresentationHelper.ConvertAmountToString(healthExpenseByYear);
                    calcResponse.FoodExpenseByYear = PresentationHelper.ConvertAmountToString(foodExpenseByYear);
                    calcResponse.EntertainmentExpenseByYear = PresentationHelper.ConvertAmountToString(entertainmentExpenseByYear);
                    calcResponse.LifeInsuranceExpenseByYear = PresentationHelper.ConvertAmountToString(lifeInsuranceExpenseByYear);
                    calcResponse.PetsExpenseByYear = PresentationHelper.ConvertAmountToString(petsExpenseByYear);
                    calcResponse.ClothingExpenseByYear = PresentationHelper.ConvertAmountToString(clothingExpenseByYear);
                    calcResponse.FitnessExpenseByYear = PresentationHelper.ConvertAmountToString(fitnessExpenseByYear);
                    calcResponse.GroomingExpenseByYear = PresentationHelper.ConvertAmountToString(groomingExpenseByYear);

                    calcResponse.SavingsAndFinanceByYear = PresentationHelper.ConvertAmountToString(savingsAndFinanceByYear);
                    calcResponse.OutstandingLoanPaymentsByYear = PresentationHelper.ConvertAmountToString(outstandingLoanPaymentsByYear);
                    calcResponse.RetirementSavingsPlanByYear = PresentationHelper.ConvertAmountToString(retirementSavingsPlanByYear);
                    calcResponse.RegisteredEducationSavingsPlanByYear = PresentationHelper.ConvertAmountToString(registeredEducationSavingsPlanByYear);
                    calcResponse.SavingsByYear = PresentationHelper.ConvertAmountToString(savingsByYear);
                    calcResponse.InvestmentByYear = PresentationHelper.ConvertAmountToString(investmentByYear); 

                    calcResponse.BasicTaxByYear = PresentationHelper.ConvertAmountToString(basicTaxByYear);
                    calcResponse.ExpensesByYear = PresentationHelper.ConvertAmountToString(expensesByYear);
                    calcResponse.BalanceByYear = PresentationHelper.ConvertAmountToString(balanceByYear); 

                    listCalcResponses.Add(calcResponse);
                }                
            }

            return listCalcResponses;
        }

        /// <summary>
        /// Gets regional details for BC regions.
        /// </summary>
        /// <param name="request">An array of regional IDs</param>
        /// <returns>A list of regional details. One item is for one region. </returns>
        public IEnumerable<RegionalDetailsModels> GetRegionalDetails([FromUri] int[] request)
        {
            List<RegionalDetailsModels> listRegionalDetailsResponses = new List<RegionalDetailsModels>();

            // If the array of RegionIDs are the same, then just use one to return one region of data 
            if (request.Distinct().Count() != request.Count())
            {
                request = new int[1] { request[0] };
            }

            using (var colcBusinessLayerService = new ColcBusinessLayerService())
            {
                foreach (int regionID in request)
                {
                    RegionalDetailModels detail = colcBusinessLayerService.GetRegionalDetailsByRegion(regionID);

                    if (detail != null)
                    {
                        RegionalDetailsModels regionDetailsResponse = new RegionalDetailsModels();

                        regionDetailsResponse.RegionID = detail.LocationID;
                        regionDetailsResponse.RegionName = detail.LocationName;
                        regionDetailsResponse.KeyCities = detail.KeyCities;
                        regionDetailsResponse.ForecastedAnnualEmploymentGrowth = Math.Round(detail.ForecastedAnnualEmploymentGrowth * 100, 1, MidpointRounding.AwayFromZero);
                        regionDetailsResponse.DataYearStart = detail.DataYearStart;
                        regionDetailsResponse.DataYearMidpoint = detail.DataYearMidpoint;
                        regionDetailsResponse.DataYearEnd = detail.DataYearEnd;
                        regionDetailsResponse.EmploymentGrowthStartOfOutlook = (int)PresentationHelper.RoundToNearest(detail.EmploymentGrowthStartOfOutlook, 100);
                        regionDetailsResponse.EmploymentGrowthMidpointOfOutlook = (int)PresentationHelper.RoundToNearest(detail.EmploymentGrowthMidpointOfOutlook, 100);
                        regionDetailsResponse.EmploymentGrowthEndOfOutlook = (int)PresentationHelper.RoundToNearest(detail.EmploymentGrowthEndOfOutlook, 100);
                        regionDetailsResponse.TotalEmploymentIncrease = (int)PresentationHelper.RoundToNearest(detail.TotalEmploymentIncrease, 100);
                        regionDetailsResponse.TopNOCCode1 = detail.TopNOCCode1;
                        regionDetailsResponse.TopOccupation1 = detail.TopOccupation1;
                        regionDetailsResponse.TopNOCCode2 = detail.TopNOCCode2;
                        regionDetailsResponse.TopOccupation2 = detail.TopOccupation2;
                        regionDetailsResponse.TopNOCCode3 = detail.TopNOCCode3;
                        regionDetailsResponse.TopOccupation3 = detail.TopOccupation3;

                        listRegionalDetailsResponses.Add(regionDetailsResponse);
                    }
                }                
            }

            return listRegionalDetailsResponses;
                        
        }        
    }
}
