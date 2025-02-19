define(['backbone'], function (Backbone) {
  'use strict'

  return Backbone.Model.extend({
    defaults: {
      LocationID: 0,
      LocationName: '',
      LocationTypeID: 0,
      ParentLocationID: 0,
      RegionID: 0,
      isRenting: true,
      isOneAdult: true,
      hasNoCar: false
    }
  })
})