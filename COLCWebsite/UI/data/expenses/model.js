define(['backbone'], function (Backbone) {
  'use strict'

  return Backbone.Model.extend({
    defaults: {
      LocationID: 0,
      LocationName: '',
      IncomeByMonth: 0,
      IncomeByYear: 0,
      HousingAndTransportationExpenseByMonth: 0,
      LivingAndPersonalExpenseByMonth: 0,
      SavingsAndFinanceByMonth: 0,
      HousingAndTransportationExpenseByYear: 0,
      LivingAndPersonalExpenseByYear: 0,
      SavingsAndFinanceByYear: 0,
      BasicTaxByMonth: 0,
      ExpensesByMonth: 0,
      BalanceByMonth: 0,
      BasicTaxByYear: 0,
      ExpensesByYear: 0,
      BalanceByYear: 0
    }
  })
})