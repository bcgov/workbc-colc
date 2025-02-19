define([
  'backbone',
  'data/location/model',
  'data/location/collection'
], function (Backbone, LocationModel, LocationsCollection) {
  'use strict'

  return Backbone.Model.extend({
    defaults: {
      locations: new LocationsCollection(),
      region: '',
      cityName: '',
      city: '',
      neighbourhood: '',
      location: false // LocationModel
    },

    initialize: function () {
      this.get('locations').fetch()
      this.on('change:city change:neighbourhood', function (model) {
        var location = model.get('locations').findWhere({
          LocationID: parseInt(model.get('neighbourhood') || model.get('city'), 10)
        })
        model.set('location', location || model.defaults.location)
      })
    }
  })
})