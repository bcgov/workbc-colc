define(['backbone', 'jquery', 'data/expenses/model'], function (Backbone, $, ExpensesModel) {
  'use strict'

  return Backbone.Collection.extend({
    model: ExpensesModel,

    fetch: function (scenarios, callback) {
      var self = this
      $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/api/calculator/calculate',
        data: {
          '': scenarios.toJSON()
        },
        success: function (data) {                  
          $('.loader').hide()
          $('.expenses-charts .is-active').each(function() {
            $(this).removeClass('unresolved') 
          })
          self.reset()
          self.add(data)
          callback(data)
        },
        error: function (error) {
          callback(error)
        }
      });
    }
  })
})