// @version 0.3.5

define(['ODC', 'jquery', 'underscore'], function (ODC, $, _) {
  'use strict';

  return ODC.define({
    config: {
      resizeThrottle: 100
    },

    currentBp: null,
    previousBp: null,

    initialize: function () {
      this.getCurrent()
      var eventName = ('onorientationchange' in window) ? 'orientationchange' : 'resize';
      $(window).on(eventName + '.breakpoints',
        _.throttle(this.detect.bind(this), this.config.resizeThrottle));
    },

    // Detect the current breakpoint and trigger the `change` event if necessary.
    detect: function () {
      this.getCurrent()

      if (this.currentBp !== this.previousBp) {
        this.trigger('change', [this.currentBp, this.previousBp])
      }
    },

    // Get the name of the current breakpoint
    getCurrent: function () {
      this.previousBp = this.currentBp
      if (window.getComputedStyle) {
          this.currentBp = getComputedStyle(document.body, ':after').content.replace(/["']/g, '')
      }
      else if (document.documentElement.currentStyle) {
          this.currentBp = document.documentElement.currentStyle.fontFamily
      }
      return this.currentBp
    },

    // Alias for `.on('change', callback)`, but runs the callback once right away.
    onChange: function (callback) {
      this.on('change', callback)
      callback({}, this.currentBp, this.previousBp)
    }
  })

})
