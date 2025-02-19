define([
  'ODC',
  'jquery',
  'Views/Overlay/script'
], function (ODC, $, Overlay) {
  'use strict';

  return ODC.define({

    instantiate: function ($el) {
      var self = this

      this.$el = $el

      this.overlay = ODC.create(Overlay, {
        fixed: true
      }, [this.$el])
    },

    show: function () {
      this.overlay.open()
    }
  })
})
