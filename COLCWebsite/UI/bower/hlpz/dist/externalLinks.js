(function (root, factory) {
  if (typeof exports === 'object') {
    module.exports = factory(require('jquery'));
  }
  else if (typeof define === 'function' && define.amd) {
    define('hlpz/externalLinks', ['jquery'], factory);
  }
  else {
    root.hlpz = root.hlpz || {};
    root.hlpz.externalLinks = factory(root.jQuery);
  }
}(this, function (jquery) {
  'use strict';

  /* global jquery */
  var $ = jquery;

  var hostname = window.location.hostname;
  var upperLevelDomain = hostname.replace(/([^.]+\.[^.]+)$/, '$1');

  function externalLinks() {
    $('a')
      .not('[href*="' + upperLevelDomain + '"]')
      .not('[href="#"]')
      .not('[href^="#"]')
      .not('[href^="/"]')

    .add('a[href^="//"]')
      .add('a[href$=".pdf"]')

    .attr('target', '_blank');
  }

  $(function () {
    externalLinks();
  });


  return externalLinks;

}));
