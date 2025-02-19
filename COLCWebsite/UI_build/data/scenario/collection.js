define(['backbone', 'data/scenario/model'], function (Backbone, ScenarioModel) {
  'use strict'

  return Backbone.Collection.extend({
    model: ScenarioModel,

    toJSON: function () {
      var scenarios = []
      this.each(function (scenario) {
        scenarios.push(scenario.toJSON())
      })
      return scenarios
    }
  })
})