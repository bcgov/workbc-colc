define(['ODC', 'jquery', 'underscore'], function (ODC, $, _) {
  'use strict';

  return ODC.define({
    config: {
      resizeThrottle: 100,
      fallback: 'lg'
    },

    currentBp: null,
    previousBp: null,

    initialize: function () {
      this.getCurrent()
      var eventName = ('onorientationchange' in window) ? 'orientationchange' : 'resize';
      $(window).on(eventName + '.breakpoints',
        _.throttle(this.detect.bind(this), this.config.resizeThrottle));
    },

    detect: function () {
      this.getCurrent()

      if (this.currentBp !== this.previousBp) {
        console.log('bp change', [this.currentBp, this.previousBp])
        this.trigger('change', [this.currentBp, this.previousBp])
      }
    },

    getCurrent: function () {
      this.previousBp = this.currentBp
      this.currentBp = window.getComputedStyle ? 
        getComputedStyle(document.body, ':after').content :
        this.config.fallback
      return this.currentBp
    },

    onChange: function (callback) {
      this.on('change', callback)
      callback({}, this.currentBp, this.previousBp)
    }
  })

})
