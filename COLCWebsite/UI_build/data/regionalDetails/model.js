define(['backbone'], function (Backbone) {
  'use strict'

  return Backbone.Model.extend({
    defaults: {
      RegionID: 0,
      RegionName: '',
      KeyCities: '',
      ForecastedAnnualEmploymentGrowth: 0,
      DataYearStart: 0,
      DataYearMidpoint: 0,
      DataYearEnd: 0,
      EmploymentGrowthStartOfOutlook: 0,
      EmploymentGrowthStartOfOutlookPerCent: 0,
      EmploymentGrowthMidpointOfOutlook: 0,
      EmploymentGrowthMidpointOfOutlookPerCent: 0,
      EmploymentGrowthEndOfOutlook: 0,
      EmploymentGrowthEndOfOutlookPerCent: 0,
      TotalEmploymentIncrease: 0,
      TopNOCCode1: 0,
      TopOccupation1: '',
      TopNOCCode2: 0,
      TopOccupation2: '',
      TopNOCCode3: 0,
      TopOccupation3: ''
    },

    initialize: function () {
      var self = this
      var values = [{
        key: 'EmploymentGrowthStartOfOutlook',
        value: this.get('EmploymentGrowthStartOfOutlook')
      }, {
        key: 'EmploymentGrowthMidpointOfOutlook',
        value: this.get('EmploymentGrowthMidpointOfOutlook')
      }, {
        key: 'EmploymentGrowthEndOfOutlook',
        value: this.get('EmploymentGrowthEndOfOutlook')
      }]
      var maxValue = _.max(values, function (obj) {
        return obj.value
      })
      this.set(maxValue.key + 'PerCent', 100)
      _.each(values, function (obj) {
        if (obj !== maxValue) {
          self.set(obj.key + 'PerCent', Math.round((obj.value / maxValue.value) * 100))
        }
      })      
    }
  })
})