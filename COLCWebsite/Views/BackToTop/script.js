define([
  'ODC',
  'jquery'
], function (ODC, $) {
  'use strict';

  return ODC.define({
    hook: 'back-to-top',

    initialize: function ($el, data) {
      var self = this;
      this.$el = $el

      var duration = 500;

      this.$el.click(function (e) {
        e.preventDefault();
        $('html, body').animate({
          scrollTop: 0
        }, duration);
        return false;
      })

    }
  })
})
