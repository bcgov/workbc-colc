(function (root, factory) {
  if (typeof exports === 'object') {
    module.exports = factory(require('jquery'));
  }
  else if (typeof define === 'function' && define.amd) {
    define('hlpz/getOnce', ['jquery'], factory);
  }
  else {
    root.hlpz = root.hlpz || {};
    root.hlpz.getOnce = factory(root.jQuery);
  }
}(this, function (jquery) {
  'use strict';

  /* global jquery */

  var $ = jquery,
    my = {
      cache: {}
    };


  /**
   * @method  getOnce
   * Helper function for retrieving information asynchronously,
   * but making sure it is only retrieved once and then cached.
   *
   * If a retrieval is in progress the callbacks will be queued.
   * To indicate that a retrieval is done you have to call the `done` function in your `callback`.
   *
   * @param {String} id Retrieval id
   *
   * @param {Function} callback The function to be called as soon as the retrieved information is available
   * @param {Function} callback.done The function to be called in your retrieval function
   * @param {Object} callback.done.results
   * Pass the results of your retrieval function so it can be cached and used in the callbacks.
   *
   * @param {Function} retrieve The function that retrieves the information
   */
  function getOnce(id, callback, retrieve) {
    var cacheExists = id in my.cache,
      cache = cacheExists ? my.cache[id] : undefined;

    // queue callbacks until information is retrieved
    if (cacheExists && cache.inProgress) {
      cache.callbacks.push(callback);
    }

    // execute callback if information is available
    else if (cacheExists && typeof cache.results !== 'undefined') {
      callback(cache.results);
    }

    // retrieve information for first time or again if it failed before
    else {
      my.retrieveInformation(id, callback, retrieve);
    }
  }


  my.retrieveInformation = function (id, callback, retrieve) {
    var cache, done;

    my.cache[id] = {
      inProgress: true,
      callbacks: [callback]
    };

    cache = my.cache[id];

    // function to be called when information is retrieved, has to be manually invoked
    done = function (results) {
      cache.inProgress = false;
      cache.results = results;
      cache.callbacks = $.map(cache.callbacks, function (cb) {
        cb(cache.results);
      });
    };

    retrieve(done);
  };


  return getOnce;

}));
