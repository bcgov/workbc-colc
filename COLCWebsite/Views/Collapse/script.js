define(['ODC', 'jquery'], function (ODC, $) {
  'use strict';

  return ODC.define({
    hook: 'toggle',
    config: {
      collapsed: true,
      breakpoints: false
    },

    instantiate: function ($el, data) {
      var self = this,
        enabled = false
      this.$el = $el
      $.extend(this.config, data)
      this.$toggle = this.$el
      this.$container = this.$toggle.next()

      if (!this.config.breakpoints) {
        this.enable()
      }
      // else {
      //   intent.on('width:', $.proxy(this.onBreakpointChange, this))
      //   this.onBreakpointChange()
      // }
    },

    // onBreakpointChange: function () {
    //   var breakpoint = intent.current('width')

    //   if ($.inArray(breakpoint, this.config.breakpoints) >= 0) {
    //     this.enable()
    //   }
    //   else {
    //     this.disable()
    //   }
    // },

    enable: function () {
      if (!this.enabled) {
        this.enabled = true
        //this.$toggle.attr('data-added-button', true)

        this.collapsed = this.config.collapsed

        if (this.collapsed) {
          this.$toggle.addClass('collapsed-toggle')
          this.$container.addClass('is-collapsed')
        }
        else {
          this.$container.addClass('not-collapsed')
        }

        this.onToggleClickProxy = $.proxy(this.onToggleClick, this)
        this.$toggle.on('click', this.onToggleClickProxy)
      }
    },

    onToggleClick: function (e) {
      e.preventDefault()

      var action = this.$toggle.hasClass('collapsed-toggle') ? 'expand' : 'collapse'
      this[action]()
    },

    collapse: function () {
      this.$toggle.addClass('collapsed-toggle')
      this.$container.addClass('is-collapsed')
      this.$container.removeClass('not-collapsed')
      this.trigger('toggle', ['collapse'])
    },

    expand: function () {
      this.$toggle.removeClass('collapsed-toggle')
      this.$container.removeClass('is-collapsed')
      this.$container.addClass('not-collapsed')
      this.trigger('toggle', ['expand'])
    }

  })
})
