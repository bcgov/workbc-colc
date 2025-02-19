define(['backbone', 'jquery', 'data/location/model'], function (Backbone, $, LocationModel) {
  'use strict'

  return Backbone.Collection.extend({
    model: LocationModel,

    fetch: function () {
      var self = this
      this.add($('#locationsData').data('locations-data'))
      this.each(function (location) {
        var ParentLocationID = location.get('ParentLocationID')
        var parent = self.findWhere({ LocationID: parseInt(ParentLocationID, 10) })
        var RegionID = parent && parent.get('ParentLocationID') !== 1 ?
          parent.get('ParentLocationID') :
          (ParentLocationID ? ParentLocationID : null)
        location.set('RegionID', RegionID)
      })
    }
  })
})