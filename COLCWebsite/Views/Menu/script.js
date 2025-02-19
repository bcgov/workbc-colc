define([
  'ODC',
  'jquery'
], function (ODC, $) {
  'use strict';

  return ODC.define({
    hook: 'head-container',
    config: {},

    initialize: function ($el) {
      var self = this;

      var pull = $('.collapsed'),
        menu = $('.navbar-collapse'),
        menuHeight = menu.height();

      $(pull).on('click', function (e) {
        e.preventDefault();
        //menu.toggleClass('in');
        menu.slideToggle();
      });

    }

  })
})
