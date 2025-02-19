define(['ODC', 'rivets'], function (ODC, rivets) {
  'use strict';

  rivets.binders['odc-*'] = function (el, value) {
    var hook = this.args[0]
    rivets.binders['class-*'].call(this, el, value);
    ODC.applyHooks(el, [hook])
  }

  return rivets
})
