define(['backbone', 'data/locationSet/model'], function (Backbone, LocationSetModel) {
  'use strict'

  return Backbone.Collection.extend({
    model: LocationSetModel
  })
})