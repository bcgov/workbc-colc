define([
  'ODC',
  'jquery',
  'backbone',
  'utils/rivets',
  'Views/Overlay/script',
  'Views/GoogleMap/script'
], function (ODC, $, Backbone, rivets, Overlay, GoogleMap) {
  'use strict';

  return ODC.define({
    hook: 'map-overlay',
    model: new Backbone.Model({
      isCityLocation: '',
      cityName: ''
    }),
    instantiate: function ($el) {
      var self = this

      this.$el = $el

      this.overlay = this.findHook('overlay')
      this.googlemap = this.findHook('google-map')
      rivets.bind($el, {
        model: this.model,
        view: this
      })
    },

    show: function (index, cityLocation) {
      if (cityLocation === undefined) {
        this.model.set('isCityLocation', 0);
      }
      else {
        this.model.set('isCityLocation', 1);
        this.model.set('cityName', cityLocation.cityName);
      }

      this.overlay.open()
      this.googlemap.showMap(index, cityLocation)
    }
  })
})
