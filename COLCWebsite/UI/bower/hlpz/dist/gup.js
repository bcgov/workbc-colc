(function (root, factory) {
  if (typeof exports === 'object') {
    module.exports = factory();
  }
  else if (typeof define === 'function' && define.amd) {
    define('hlpz/gup', [], factory);
  }
  else {
    root.hlpz = root.hlpz || {};
    root.hlpz.gup = factory();
  }
}(this, function () {
  'use strict';

  /**
   * @method gup
   * Get URL parameter
   * @param {String} name The name of the parameter
   * @param {String} url=window.location The URL to search for the parameter
   */
  function gup(name, url) {
    var regex, regexS, results;
    name = name.replace(/[\[]/, '\\[').replace(/[\]]/, '\\]');
    regexS = '[\\?&]' + name + '=([^&#]*)';
    regex = new RegExp(regexS);
    results = regex.exec(url || window.location);
    if (results === null || results[1] === '') {
      return false;
    }
    else {
      return results[1];
    }
  }


  return gup;

}));
