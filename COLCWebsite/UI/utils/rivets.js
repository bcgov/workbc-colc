define([
  'jquery',
  'underscore',
  'rivets.backbone',
  'utils/rivets.binders.odc',
  'utils/rivets.formatters'
], function ($, _, rivets) {
  'use strict';

  rivets.adapters['.'] = {
    observe: function(obj, keypath, callback) {
    },
    unobserve: function(obj, keypath, callback) {
    },
    get: function(obj, keypath) {
      return obj[keypath]
    },
    set: function(obj, keypath, value) {
      obj[keypath] = value
    }
  }

  rivets.configure({
    // rootInterface: ':',
    // configure rivets to call event handlers in the context of the original event handler
    adapter: {
      observe: function(obj, keypath, callback) {
        // watch(obj, keypath, callback)
      },
      unobserve: function(obj, keypath, callback) {
        // unwatch(obj, keypath, callback)
      },
      read: function(obj, keypath) {
        return obj[keypath]
      },
      publish: function(obj, keypath, value) {
        obj[keypath] = value
      }
    },
    handler: function (target, event, binding) {
      var keypath = binding.keypath.split('.'),
        len = keypath.length,
        view = binding.view.models;

      _.each(keypath, function (namespace, index) {
        if (index < len - 1 && view[namespace]) {
          view = view[namespace]
        }
      })

      this.call(view, event, binding.view.models)
    }
  })

  var liveValue = Object.create(rivets.binders.value);

  liveValue.bind = function (el) {
      this.handler = this.handler || this.publish.bind(this);
      $(el).on('change paste', this.handler);
  };

  liveValue.unbind = function (el) {
      // if (this.handler) {
      //     $(el).on('keyup', this.handler);
      // }
  };

  rivets.binders['live-value'] = liveValue;

  _.each(rivets.binders, function (binder) {
    var oldRoutine = binder.routine
    binder.routine = function (el) {      
      oldRoutine.apply(this, arguments)
      setTimeout(function() {
        $.uniform.update()
      });
    }
  })

  return rivets
})

