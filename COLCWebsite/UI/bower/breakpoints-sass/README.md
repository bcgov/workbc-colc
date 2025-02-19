# Breakpoints.Sass

@version 0.3.5

A mixin for dealing with media queries.

## Usage

### Initialization

First of all you need to import the mixin and define your breakpoints:

```scss
@import "path/to/breakpoints";

$bps: (xs: 0px, sm: 600px, md: 960px, lg: 1200px);
```
    
### Using the `bp` mixin

Now you can use the `bp` mixin to write your media queries. The mixin takes these parameters:

* `$bp-min`: The name of the breakpoint
* `$mode` (optional): Determines if a max-width should be used.

    Possible values:  
    - `up` means there is no max-width (this is the default)  
    - `only` means the max-width is set to the next breakpoint minus 1px
    - `to` means the max-width is set to the next breakpoint after `$bp-max` minus 1px
* `$bp-max` (optional): The name of the maximum breakpoint

#### A simple example

```scss
.container {
  width: 100%;
  
  @include bp(xs, only) {
    font-size: 11px;
  }
  
  @include bp(xs, to, sm) {
    padding: 0 20px;
  }
  
  @include bp(sm) {
    max-width: 580px;
  }
  
  @include bp(sm, to, md) {
    font-size: 16px;
  }
  
  @include bp(md) {
    max-width: 980px;
    padding: 0 40px;
  }
  
  @include bp(lg) {
    font-size: 20px;
  }
}
```

will result in:

```css
.container {
  width: 100%;
}
@media (max-width: 599px) {
  .container {
    font-size: 11px;
  }
}
@media (max-width: 959px) {
  .container {
    padding: 0 20px;
  }
}
@media (min-width: 600px) {
  .container {
    max-width: 580px;
  }
}
@media (min-width: 600px) and (max-width: 1199px) {
  .container {
    font-size: 16px;
  }
}
@media (min-width: 960px) {
  .container {
    max-width: 980px;
    padding: 0 40px;
  }
}
@media (min-width: 1200px) {
  .container {
    font-size: 20px;
  }
}
```
    
### The `bp-detect` helper mixin

This mixin allows JavaScript to read the current breakpoint from the DOM dynamically.
You have to pass it your defined breakpoints map as the first parameter and can optionally turn on IE8 support with the second parameter.

__Warning: If you use legacy support you have to make sure to include the mixin after `normalize` and don't set the `font-family` on the `html` element, use `body` instead.__

```scss
/* HELPER FOR BREAKPOINT DETECTION IN JS */
@include bp-detect($bps,$legacy:true);
```

results in:

```css
/* HELPER FOR BREAKPOINT DETECTION IN JS */

// legacy start

html {
  font-family: "xs";
}
@media (min-width: 600px) {
  html {
    font-family: "sm";
  }
}
@media (min-width: 960px) {
  html {
    font-family: "md";
  }
}
@media (min-width: 1200px) {
  html {
    font-family: "lg";
  }
}

body {
  font-family: sans-serif;
}

// legacy end

body:before {
  display: none;
  content: "xs, sm, md, lg";
}
body:after {
  display: none;
  content: "xs";
}
@media (min-width: 600px) {
  body:after {
    content: "sm";
  }
}
@media (min-width: 960px) {
  body:after {
    content: "md";
  }
}
@media (min-width: 1200px) {
  body:after {
    content: "lg";
  }
}
```
    
The `bp-detect` mixin is meant to be used with the `ODC.js` module included in this repository or your own custom JS detection. Here is a simple example how it could be used:

```js
var bp = document.querySelector('h1')

function getBreakpoint() {
  bp.textContent = 'Breakpoint: ' + getComputedStyle(document.body, ':after').content
}

window.onresize = getBreakpoint
window.onresize()
```

-----

# ODC.breakpoints

With this module you can react to breakpoint changes and retrieve the current breakpoint at any time.  
Have a look at the console while running and resizing the demo.

## Usage

```js
define(['breakpoints'], function (breakpoints) {

  // listen for breakpoint changes
  breakpoints.on('change', function (e, current, previous) {})

  // listen for breakpoint changes and run callback once right away (`previous` will be `null`)
  // use this if you have to do something to a component on initialization and breakpoint change
  breakpoints.onChange(function (e, current, previous) {})

  // retrieve current breakpoint
  var currentBreakpoint = breakpoints.getCurrent()
})
```

# Contribute

For development you have to work on the `develop` or a feature branch.

Run `npm install` and `grunt dev` to make the demo work.

When done with a feature or bugfix create a release branch (with gitflow) run `grunt version:set:{version}`, commit the version update and finish the release. Make sure to tag that commit with the new version number.