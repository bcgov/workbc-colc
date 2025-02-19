// @version 0.3.3



// AMD module definition
define(['jquery'], function ($) {
  'use strict';

  // ## Baseline setup

  // Object.create polyfill
  if (typeof Object.create !== 'function') {
    Object.create = function (o) {
      function Obj() {}
      Obj.prototype = o
      return new Obj()
    }
  }

  // Define objects for ODC framework, `ODC` is exported, `my` is for private functions.
  var ODC = {}
  var my = {}

  // Registry for objects with a `hook` property, these will be automatically bound to the DOM
  my.hooks = {}



  // ## ODC functions


  // ### ODC.emptyFn
  // A simple no-op function to be used for example as a default for a callback parameter.
  ODC.emptyFn = function () {}


  // ### ODC.create
  // Creates a new object (instance) from `proto`, extends the `config` and executes `instantiate` with `params`.
  // It also adds a `$el` property referencing the element it is instantiated on before running `instantiate` if the first parameter in `params` is a jQuery object (which it always is when using `applyHook`/`applyHooks`.
  // The second and third parameter can be swapped around, `config` has to be an `object` and `params` has to be an `array`.
  ODC.create = function (proto, configOrParams, paramsOrConfig) {
    var obj, config, params

    $.each(arguments, function (key, value) {
      if (key > 0 && key < 3) {
        params = $.type(value) === 'array' ? value : params || []
        config = $.type(value) === 'object' ? value : config || {}
      }
    })

    obj = my.inherit(proto, config)

    if (obj.instantiate) {
      if (params[0] instanceof $) {
        obj.$el = params[0]
      }
      obj.instantiate.apply(obj, params)
    }

    return obj
  }


  // ### ODC.define
  // Creates a new object from `definition` where `definition`
  // can be an `object` or a `function` which returns an object.
  //
  // How the object is created and behaves is changed by a few special properties:
  //
  // - `extend` : String|Object
  //
  //   The object or the class name of the class that is to be extend.
  //   Set to `false` to start with a clean object.
  //
  //   Defaults to: `ODC.Base`
  //
  // - `mixin` : Object[]
  //
  //   An array of objects to be mixed in before initialization/instantiation.
  //
  //   This should be used to extend a class with reusable functionality;
  //   properties that exist already or aren't functions will be ignored.
  //
  // - `instantiate` : Function
  //
  //   If an `instantiate` method is found you get an object that has to instantiated to work as intended.
  //
  // - `initialize` : Function
  //
  //   Pass an `initialize` function to enable auto-initialization for your object.
  //
  // - `hook` : String
  //
  //   The object is bound to the DOM using this hook if provided.
  //   See the `ODC.applyHook` function for details.
  //
  // - `hookSelector` : String
  //
  //   Selector to be used to bind the object to the DOM when `hook` is set.
  //   See the `ODC.applyHook` function for details.
  //
  //   Defaults to: `.' + hook + ', [data-' + hook + '], [data-hook="' + hook + '"]`
  //
  // - `awaitDOMReady` : Boolean
  //
  //   If `true`, the hooking and auto-initialization will be done after jQuery's `ready`.
  //
  //   Usually this shouldn't be necessary,
  //   since the scripts should be at the bottom of the page and take a while to load,
  //   but if you want to be on the safe side - especially with our beloved Internet Explorer in mind -
  //   you can use this option.
  //
  //   Defaults to: `false`
  ODC.define = function (definition) {
    if (typeof definition === 'function') {
      definition = definition()
    }
    definition = definition || {}

    var obj = {}

    // If the definition's `extend` property is not `false` use it as prototype for the new object (use `ODC.Base` if `undefined`).
    // Rename `extend` property to `parent`.
    // Delete `config` from definition so it is not overriden.
    if (definition.extend !== false) {
      definition.extend = definition.extend || ODC.Base
      obj = my.inherit(definition.extend, definition.config)

      definition.parent = definition.extend
      delete definition.extend

      delete definition.config
    }

    // Apply mixins.
    if (definition.mixin && definition.mixin.length) {
      definition.mixin.forEach(function (mixin) {
        my.mixin(definition, mixin)
      })
    }

    // Write properties from definition to new object.
    $.each(definition, function (key, value) {
      obj[key] = value
    })

    // If `hook` was passed in definition, store prototype in hooks registry and automatically hook objects into DOM nodes.
    // Wait for document ready if `awaitDOMReady` was set in definition.
    if (obj.hook &&
      (obj.initialize || obj.instantiate)) {
      obj.hookSelector = obj.hookSelector ||
        '.' + obj.hook + ' ,[data-' + obj.hook + '], [data-hook="' + obj.hook + '"]'
      my.hooks[obj.hook] = obj
      my.DOMReady(obj.awaitDOMReady, function () {
        ODC.applyHook(obj)
      })
    }

    // If there is no `hook`, but an `initialize` function, it is called here.
    // Wait for document ready if `awaitDOMReady` was set in definition.
    else if (obj.initialize) {
      my.DOMReady(obj.awaitDOMReady, function () {
        obj.initialize.call(obj)
      })
    }

    return obj
  }


  // ### ODC.applyHook
  // Binds an object to the DOM using its hook. The hook can be added to an element in 3 ways:
  // `<div class="{hook}"">`, `<div data-{hook}>` or `<div data-hook="{hook}">`
  // Additionally you can overwrite the default selector by defining the `hookSelector` property.
  //
  // The value of `data-{hook}` is read, parsed as JSON and passed to the object as `config`.
  // A hook for a collapse plugin could look like this: `<div data-collapse='{"breakpoints": ["sm", "md"]}'>`
  //
  // If the passed object (`proto`) can be instantiated, an instance is created for every matching DOM element unless it already has an instance applied.
  // However if it is a singleton, the `initialize` function is called for the first match.
  // In both cases 2 parameters are passed to the object:
  // the element as jQuery object and the config read from the data attribute.
  // The parameter `context` limits the jQuery selection to a context, default is `document`.
  ODC.applyHook = function (proto, context) {
    context = context || document
    $(context).filter(proto.hookSelector).add($(proto.hookSelector, context)).each(function (index) {
      var $this = $(this),
        data = $this.data(proto.hook) || {},
        instantiate = !proto.isPrototypeOf(data) && proto.hasOwnProperty('instantiate'),
        initialize = index === 0 && proto !== data && proto.hasOwnProperty('initialize'),
        obj;

      if (instantiate || initialize) {
        obj = instantiate ? ODC.create(proto, [$this, data]) : proto
        initialize && proto.initialize.call(proto, $this, data)
        $this.attr('data-' + obj.hook, '').data(obj.hook, obj)
      }
    })
  }


  // ### ODC.applyHooks
  // Loops through all registered objects with a `hook` and applies them.
  // By default it applies all objects to the default context of `applyHook`.
  // This can be limited with the `context` parameter.
  // The hooks that are applied can be filtered with the `filter` parameter. It expects an `array` of strings.
  //
  // __Important:__ Use this after adding new DOM elements, for example after an AJAX call.
  ODC.applyHooks = function (context, filter) {
    $.each(my.hooks, function (hook, obj) {
      if (!$.isArray(filter) || $.inArray(hook, filter) !== -1) {
        ODC.applyHook(obj, context)
      }
    })
  }



  // ## Private functions

  // Creates a new object from a prototype (`proto`) and merges `config` into the new object's `config` property.
  my.inherit = function (proto, config) {
    var obj = Object.create(proto)
    obj.config = $.extend(true, {}, proto.config, config)

    return obj
  }

  // Find a registered hook object by hook name
  my.getProto = function (hook) {
    if (my.hooks.hasOwnProperty(hook)) {
      return my.hooks[hook]
    }
    else {
      throw new Error('No hook object found for "' + hook + '", make sure it is registered before trying to find it.')
    }
  }


  // Adds every function from `mixin` to `proto` unless it already exists
  my.mixin = function (proto, mixin) {
    for (var property in mixin) {
      if (mixin.hasOwnProperty(property) &&
        typeof mixin[property] === 'function' &&
        !proto.hasOwnProperty(property)) {
        proto[property] = mixin[property]
      }
    }
  }


  // Runs `fn`
  // if `wait` is `true` it is wrapped in jQuery's `ready` function
  my.DOMReady = function (wait, fn) {
    wait && $(fn) || fn()
  }



  // ## Base object


  // The `Base` object is extended by default for every object defined by `ODC.define`.
  //
  // It provides an event emitter, helpers to find hooks and a function to call functions up the inheritance tree.
  ODC.Base = ODC.define(function () {
    var Base = {}

    // This object should not extend anything since it itself is the default to be extended.
    Base.extend = false

    // Set up a jQuery element to be used for the event functions. It has to be created on first use, because all objects would share the same events if we would set a default jQuery element here.
    // That is why the `_events` function is used to reference `_e` and create the jQuery element the first time it is used.
    Base._e = null
    Base._events = function () {
      if (this._e === null) {
        this._e = $({})
      }

      return this._e
    }


    // ### Event functions

    // Event functions work like jQuery's with the addition of `once` as alias for `one`.
    Base.on = function () {
      this._events().on.apply(this._events(), arguments)
    }

    Base.one = Base.once = function () {
      this._events().one.apply(this._events(), arguments)
    }

    Base.off = function () {
      this._events().off.apply(this._events(), arguments)
    }

    Base.trigger = function () {
      this._events().trigger.apply(this._events(), arguments)
    }


    // ### Hook functions
    //
    // Note that all these function use `[data-{hook}]` as selectors, this works because ODC adds that attribute even if you use a different hook like a class in your template.
    // Make sure though, if you rely on another hook, to `require` it in your component to ensure the right initialization order.


    //  Find all elements inside of this one that have a certain hook applied
    Base.findHooks = function (hook) {
      return this.getHooks(hook, this.$el)
    }

    //  Find the first element inside of this one that has a certain hook applied
    Base.findHook = function (hook) {
      return this.getHook(hook, this.$el)
    }

    //  Find all elements with a certain ODC hook applied
    Base.getHooks = function (hook, context) {
      var hooks = []
      $(my.getProto(hook).hookSelector, context || document).each(function () {
        hooks.push($(this).data(hook) || $(this))
      })
      return hooks
    }

    //  Find the first element with a certain ODC hook applied
    Base.getHook = function (hook, context) {
      var hooks = this.getHooks(hook, context)
      return hooks.length ? hooks[0] : false
    }

    //  Find the closest parent element that has a certain ODC hook applied
    Base.closestHook = function (hook) {
      return this.$el.closest(my.getProto(hook).hookSelector).data(hook)
    }


    // ### Super function


    // `Base.uber` and its alias `Base.callParent` call the "parent" method with the name of `method` passing `args` as arguments.
    Base.uber = Base.callParent = function (method, args) {
      method = method || ''
      if (!(method in this.parent)) {
        throw new Error('The method `' + method + '` could not be found in the parent object')
      }
      else {
        return this.parent[method].apply(this, args)
      }
    }

    // Return definition object
    return Base
  })

  // Export `ODC`
  return ODC

});
