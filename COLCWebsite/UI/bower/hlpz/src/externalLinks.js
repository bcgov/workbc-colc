/* umd { "objectToExport": "externalLinks", "deps": { "default": ["jquery"], "global": ["jQuery"] } } */
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
