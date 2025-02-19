requirejs.config({

  baseUrl: '/UI',

  paths: {
    'Views': '../Views',
    // jquery: '//ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min',
    'jquery': 'bower/jquery/dist/jquery',
    'jquery-global': 'vendor/jquery-global',
    'jquery-private': 'vendor/jquery-private',
    'underscore': 'bower/underscore/underscore',
    'backbone': 'bower/backbone/backbone',
    'typeahead': 'bower/typeahead.js/dist/typeahead.bundle',

    'hlpz': 'bower/hlpz/dist',
    'ODC': 'bower/odcjs/src/ODC',
    'breakpoints': 'bower/breakpoints-sass/src/breakpoints',

    'jquery-tiny-pubsub': 'bower/jquery-tiny-pubsub/dist/ba-tiny-pubsub',
    'jquery.uniform': 'bower/jquery.uniform/jquery.uniform',
    'jquery.validate': 'bower/jquery.validate/dist/jquery.validate',
    'imagesLoaded': 'bower/imagesloaded/imagesloaded.pkgd',
    'flot': 'bower/flot',
    'flot-axislabels': 'bower/flot-axislabels/jquery.flot.axislabels',
    'flot.orderbars': 'bower/flot.orderbars/js/jquery.flot.orderBars',
    'jquery-placeholder': 'bower/jquery-placeholder',
    'sightglass': 'bower/sightglass/index',
    'rivets': 'bower/rivets/dist/rivets',
    'rivets.backbone': 'bower/rivets-backbone-adapter/rivets-backbone',
    'debounced-resize': 'vendor/debouncedresize',
    'swipe': 'vendor/swipe',
    'swipe-nav': 'vendor/swipe-nav',
    'async': 'bower/requirejs-plugins/src/async',
  },



  // Dependencies for scripts that are not wrapped as AMD modules.
  shim: {
    'jquery-tiny-pubsub': ['jquery'],
    'jquery.uniform': ['jquery'],
    'typeahead': ['jquery'],
    'flot/jquery.flot': ['jquery'],
    'flot/jquery.flot.pie': ['jquery', 'flot/jquery.flot'],
    'flot/jquery.flot.categories': ['jquery', 'flot/jquery.flot'],
    'flot/jquery.flot.resize': ['jquery', 'flot/jquery.flot'],
    'flot/excanvas': ['flot/jquery.flot.categories'],
    'flot-axislabels': ['jquery', 'flot/jquery.flot'],
    'flot.orderbars': ['jquery', 'flot/jquery.flot'],
    'debounced-resize': ['jquery'],
    'utils/tooltip': ['jquery']
  },



  // define how RequireJS Optimizer is supposed to bundle files
  modules: [{
    name: 'main'
  }],



  map: {
    /**
     * Uncomment this if you have to make sure that no other jQuery instance that might be on the page
     * is used in any of the AMD modules.
     */
    // // '*' means all modules will get 'jquery-private'
    // // for their 'jquery' dependency.
    // '*': {
    //   'jquery': 'jquery-private'
    // },

    // // 'jquery-private' wants the real jQuery module
    // // though. If this line was not here, there would
    // // be an unresolvable cyclic dependency.
    // 'jquery-private': {
    //   'jquery': 'jquery'
    // }

    /**
     * Uncomment this if you want to use an existing instance of jQuery from the global namespace
     */
    // '*' means all modules will get 'jquery-global'
    // for their 'jquery' dependency.
    // '*': {
    //   'jquery': 'jquery-global'
    // },
  }
})

// Define what should be loaded on every page

require([
  'jquery',
  'Views/Locations/script',
  'Views/OccupationSalary/script',
  'Views/ExpensesCharts/script',
  'Views/Overview/script',
  'Views/RegionalDetails/script',
  'Views/Collapse/script',
  'Views/InfoBoxes/script',
  'Views/BackToTop/script',
  'Views/Menu/script',
  'Views/GoogleMap/script',
  'Views/MapOverlay/script'
], function ($) {
  'use strict';
})
