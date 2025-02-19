define(['backbone', 'data/regionalDetails/model'], function (Backbone, RegionalDetailsModel) {
  'use strict'

  return Backbone.Collection.extend({
    model: RegionalDetailsModel,

    fetch: function (scenarios, callback) {
      var self = this
      var ids = scenarios.map(function (scenario) {
        return scenario.get('location').get('RegionID')
      })
      $.ajax({
        type: 'GET',
        dataType: 'json',
        url: '/api/calculator/regionaldetails',
        data: {
          '': ids
        },
        success: function (data) {
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