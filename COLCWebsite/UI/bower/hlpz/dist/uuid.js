(function (root, factory) {
  if (typeof exports === 'object') {
    module.exports = factory();
  }
  else if (typeof define === 'function' && define.amd) {
    define('hlpz/uuid', [], factory);
  }
  else {
    root.hlpz = root.hlpz || {};
    root.hlpz.uuid = factory();
  }
}(this, function () {
  'use strict';

  /**
   * @method uuid
   * Generate Universally unique identifier
   */
  var uuid = (function () {
    function s4() {
      return Math.floor((1 + Math.random()) * 0x10000)
        .toString(16)
        .substring(1)
    }
    return function () {
      return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
        s4() + '-' + s4() + s4() + s4()
    };
  })()


  return uuid;

}));
