using ColcDataLayerWcfService.CustomExceptions;
using ColcDataLayerWcfService.Helpers;
using ColcDataLayerWcfService.Models.Calculator;
using ColcDataLayerWcfService.Models.SalaryLevel;
using EDMEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ColcDataLayerWcfService.Controllers
{
    public class CalculatorController
    {
        WorkBC_EDMContext _dbContext = null;
        decimal _grossIncome = 0;
        int _locationID = 0;
        int _salaryLevelID = 0;
        int _familySize = 0;
        int _ownIndicatorID = 0;
        int _sqFtLevelID = 0;
        int _downPaymentLevelID = 0;
        int _transportationType = (int)TransportionType.Car;
        int _numOfAutos = 0;
        int _mileagePerYearID = 0;


        /// <summary>
        /// Gets values for consumable expense, health expense, housing expense, transportation expense, and basic taxes that must be retrieved from the database.
        /// </summary>
        /// <param name="calculatorDataInputModels">A list of inputs for the calculator. One item is for a city or neighbourhood.</param>
        /// <returns>A list of outputs containing consumable expense, health expense, housing expense, transportation expense, and basic taxes. One item is for a city or neighbourhood.</returns>
        public IEnumerable<CalculatorDataOutputModels> GetCOLCData(IEnumerable<CalculatorDataInputModels> calculatorDataInputModels)
        {
            List<CalculatorDataOutputModels> listOutput = new List<CalculatorDataOutputModels>();

            using (_dbContext = new WorkBC_EDMContext())
            {
                foreach (CalculatorDataInputModels input in calculatorDataInputModels)
                {
                    CalculatorDataOutputModels output = new CalculatorDataOutputModels();
                    
                    _grossIncome = input.Salary1 + input.Salary2.GetValueOrDefault();
                    _locationID = input.LocationID;
                    _salaryLevelID = GetSalaryLevelID();
                    _familySize = input.NumAdults + input.NumChildren;
                    _ownIndicatorID = input.OwnIndicatorID;
                    _sqFtLevelID = input.SqFtID;
                    _downPaymentLevelID = input.DownPaymentLevelID;
                    _transportationType = input.TransportationType;
                    _numOfAutos = GetNumberOfVehicles(input);
                    _mileagePerYearID = input.MileagePerYearID;

                    output.LocationID = input.LocationID;
                    output.LocationName = input.LocationName;
                    output.TotalIncome = _grossIncome;                    
                    output.ConsumableExpense = GetConsumableExpense();
                    output.HealthExpense = GetHealthExpense();
                    output.HousingExpense = GetHousingExpense();
                    output.TransportationExpense = GetTransportationExpense();
                    output.BasicTaxForIncome1 = GetBasicTax(input.Salary1); 
                    output.BasicTaxForIncome2 = GetBasicTax(input.Salary2.GetValueOrDefault());
                  
                    listOutput.Add(output);
                }
            }           

            return listOutput;
        }

        private int GetNumberOfVehicles(CalculatorDataInputModels input)
        {
            if (input.TransportationType != (int)TransportionType.Car)
                return 0;

            return input.NumVehicles > 0 ? input.NumVehicles : 1;
        }

        /// <summary>
        /// Gets salary level ID.
        /// 
        /// The salary is based on levels.  For any salary that is greater than or equal to the mean of any salary range as defined in the data file, 
        /// the salary to be picked for calculation of expenses will be the upper limit of that particular range.  
        /// For any salary that is less than the mean of any salary range as defined in the data file, 
        /// the salary to be picked for calculation of expenses will be the lower limit of that particular range.  
        /// For example, for a salary of $28,500, the income falls between $25,000 and less than $30,000, so the salary level is $30,000.  
        /// For a salary of $26,000, the income falls between $25,000 and less than $30,000, so the salary level is $25,000. 
        /// </summary>
        /// <returns>SalaryLevelID</returns>
        private int GetSalaryLevelID()
        {
            int salaryID = 0;

            SalaryLevelController slc = new SalaryLevelController();

            List<SalaryLevelModels> salaryLevelsList = slc.GetSalaryLevels();

            SalaryLevelModels lowerSalary = salaryLevelsList
                                            .Where(x => x.Salary < _grossIncome)
                                            .OrderByDescending(x => x.Salary).FirstOrDefault();

            SalaryLevelModels upperSalary = salaryLevelsList
                                            .Where(x => x.Salary >= _grossIncome)
                                            .OrderBy(x => x.Salary).FirstOrDefault();

            if (lowerSalary != null && upperSalary != null)
            {
                decimal mean = (lowerSalary.Salary + upperSalary.Salary) / 2;

                if (_grossIncome >= mean)
                {
                    salaryID = upperSalary.SalaryLevelID;
                }
                else
                {
                    salaryID = lowerSalary.SalaryLevelID;
                }
            }
            else
            {
                if (lowerSalary == null)
                {
                    salaryID = upperSalary.SalaryLevelID;
                }
                else
                {
                    salaryID = lowerSalary.SalaryLevelID;
                }
            }
            

            return salaryID;
        }        

        /// <summary>
        /// Gets annual consumable expense from the database.
        /// </summary>
        /// <returns>Consumable expense</returns>
        private decimal GetConsumableExpense()
        {
            decimal consumable = 0;

            var query = _dbContext.COLC_ConsumableHealthExpenses
                        .Where(x => x.LocationID == _locationID && x.SalaryLevelID == _salaryLevelID && x.FamilySize == _familySize)
                        .Select(x => new { x.ConsumerablesCost }).SingleOrDefault();

            if (query != null)
            {
                consumable = query.ConsumerablesCost;
                return consumable;
            }
            else
            {
                throw new CalculatorDataInputException("Consumable expenses value is not found using the specified data inputs.");
            }

        }

        /// <summary>
        /// Gets annual housing expense from the database.
        /// </summary>
        /// <returns>Housing expense</returns>
        private decimal GetHousingExpense()
        {
            decimal housingExpense = 0;
            
            housingExpense = _dbContext.COLC_HousingExpenses
                            .Where(x => x.LocationID == _locationID && x.SalaryLevelID == _salaryLevelID
                                && x.OwnIndicatorID == _ownIndicatorID && x.SqFtLevelID == _sqFtLevelID
                                && x.FamilySize == _familySize && x.DownPaymentLevelID == _downPaymentLevelID)
                            .Select(x => x.AnnualHousingCost).SingleOrDefault();
           
            if (housingExpense == 0)
            {
                throw new CalculatorDataInputException("Housing expense value is not found using the specified data inputs.");
            }
            else
            {
                return housingExpense;
            }
        }

        /// <summary>
        /// Gets annual health expense from the database.
        /// </summary>
        /// <returns>Health expense</returns>
        private decimal GetHealthExpense()
        {
            decimal health = 0;

            var query = _dbContext.COLC_ConsumableHealthExpenses
                        .Where(x => x.LocationID == _locationID && x.SalaryLevelID == _salaryLevelID && x.FamilySize == _familySize)
                        .Select(x => new { x.HealthCost }).SingleOrDefault();

            if (query != null)
            {
                health = query.HealthCost;
                return health;
            }
            else
            {
                throw new CalculatorDataInputException("Health expense value is not found using the specified data inputs.");
            }

        }

        /// <summary>
        /// Gets annual transportation expense from the database.
        /// </summary>
        /// <returns>Transportation expense</returns>
        private decimal GetTransportationExpense()
        {
            decimal transportationExpense = -1;

            // Query the database to get the transportation expense for car or public transportation. (FB 55833)
            if (_transportationType == (int)TransportionType.Car || _transportationType == (int)TransportionType.PublicTransportation)
            {
                transportationExpense = _dbContext.COLC_TransportationExpenses
                                        .Where(x => x.LocationID == _locationID && x.SalaryLevelID == _salaryLevelID
                                            && x.NumOfAutos == _numOfAutos && x.MileagePerYearID == _mileagePerYearID)
                                        .Select(x => x.TransportationCost).SingleOrDefault();
            }
            else // Do not query the database to get the transportation expense for walk or bike and set the expense to 0. (FB 55833)
            {
                transportationExpense = 0;
            }
            

            if (transportationExpense == -1)
            {
                throw new CalculatorDataInputException("Transportation expense's value is not found using the specified data inputs.");
            }
            else
            {
                return transportationExpense;
            }
        }

        /// <summary>
        ///  Gets annual basic taxes for one income.
        /// </summary>
        /// <param name="income">Income amount</param>
        /// <returns>Sum of federal and BC taxes for one income</returns>
        private decimal GetBasicTax(decimal income)
        {
            decimal basicTax = 0;

            if (income > 0)
            {
                decimal federalTax = 0;
                decimal bcTax = 0;

                TaxController tc = new TaxController();

                var queryFederalTax = tc.GetTaxes()
                                      .Where(x => x.TaxTypeID == (int)TaxType.Federal && x.LowerIncomeAmount <= income)
                                      .OrderByDescending(x => x.LowerIncomeAmount)
                                      .Select(x => new { x.BaseIncomeAmount, x.TaxRate, x.CumulativeTaxAmount }).First();

                var queryBCTax = tc.GetTaxes()
                                .Where(x => x.TaxTypeID == (int)TaxType.BritishColumbia && x.LowerIncomeAmount <= income)
                                .OrderByDescending(x => x.LowerIncomeAmount)
                                .Select(x => new { x.BaseIncomeAmount, x.TaxRate, x.CumulativeTaxAmount }).First();

                federalTax = ((income - queryFederalTax.BaseIncomeAmount) * queryFederalTax.TaxRate) + queryFederalTax.CumulativeTaxAmount;
                bcTax = ((income - queryBCTax.BaseIncomeAmount) * queryBCTax.TaxRate) + queryBCTax.CumulativeTaxAmount;

                basicTax = Math.Round(federalTax, 2, MidpointRounding.AwayFromZero) + Math.Round(bcTax, 2, MidpointRounding.AwayFromZero);                
            }

            return basicTax;
        }
    }
}