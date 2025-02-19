define([
  'ODC',
  'jquery',
  'vendor/jquery.scrollLock'
], function (ODC, $) {
  'use strict';

  var $doc = $(document),
    $body = $('body')

  return ODC.define({
    hook: 'overlay',

    config: {
      fixed: false
    },

    instantiate: function ($el, data) {
      this.$el = $el
      this.$el.removeClass('is-visible')
      $.extend(this.config, data)

      this.$el.on('click', '[data-action="overlay-close"]', $.proxy(this.close, this))

      $(this.$el).on('click', $.proxy(this.onClick, this))

      if (this.config.fixed) {
        this.$el.addClass('is-fixed')
      }

      this.proxyOnKeyUp = $.proxy(this.onKeyUp, this)
    },

    onClick: function (e) {
      if (e.target === this.$el[0]) {
        this.close()
      }
    },

    onKeyUp: function (e) {
      if (e.keyCode === 27) { // esc
        this.close()
      }
    },

    open: function () {

      this.$el.addClass('is-visible')

      if (this.config.fixed) {
        $.scrollLock(true)
      }
      this.$el.scrollTop(0)
      $doc.on('keyup', this.proxyOnKeyUp);
    },

    close: function () {

      this.$el.removeClass('is-visible')

      if (this.config.fixed) {
        $.scrollLock(false)
      }

      $doc.off('keyup', this.proxyOnKeyUp);
    }
  })
})
