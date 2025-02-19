/*
- Author: Callum Jefferies (callum@callumj.co.uk)
- License: MIT-style
- Version: 1.1.2
*/

(function() {

    var SwipeNav = function(element, options) {
        options = options || {};

        this.element = element;
        this.callback = function() {};

        if (typeof options.callback === "function") {
            this.callback = options.callback;
        }

        options.callback = bindFunction(this.swipeCallback, this);

        this.swipe = new Swipe(this.element, options);
        this.createIndicators();

        if (this.nav.addEventListener) {
            this.nav.addEventListener("click",
                bindFunction(this.onIndicatorClick, this), false);
        }

        if (this.nav.attachEvent) {
            this.nav.attachEvent("onclick",
                bindFunction(this.onIndicatorClick, this));
        }
    };

    SwipeNav.prototype.swipeCallback = function() {
        this.callback.apply(this, arguments);
        this.setActiveIndicator.apply(this, arguments);
    };

    SwipeNav.prototype.createIndicators = function() {
        this.nav = document.createElement("ol");
        this.nav.className = "swipe-nav";

        var indicator, anchor;

        for (var i = 0; i < this.swipe.getNumSlides(); i++) {
            anchor = document.createElement("a");
            anchor.setAttribute("data-key", i);
            anchor.href = "#";
            anchor.innerHTML = i + 1;

            indicator = document.createElement("li");
            indicator.appendChild(anchor);

            this.nav.appendChild(indicator);
        }

        this.element.appendChild(this.nav);
        this.indicators = this.nav.getElementsByTagName("li");
        this.setActiveIndicator(0);
    };

    SwipeNav.prototype.setActiveIndicator = function(index) {
        var i = this.indicators.length;
        var indicator;

        while (i--) {
            indicator = this.indicators[i];
            indicator.className = indicator.className.replace(/\bactive\b/, "");
        }

        this.indicators[index].className = "active";
    };

    SwipeNav.prototype.onIndicatorClick = function(e) {
        var target = e.target || e.srcElement;

        if (target && target.tagName === "A") {
            this.swipe.slide(target.getAttribute("data-key"));
            e.preventDefault ? e.preventDefault() : e.returnValue = false;
            e.stopPropagation ? e.stopPropagation() : e.cancelBubble = true;
        }
    };

    function bindFunction(func, context) {
        return function() {
            return func.apply(context, arguments);
        };
    }

    window.SwipeNav = SwipeNav;



var SwipeNav2 = function(element, options) {
    options = options || {};

    this.element = element;
    this.callback = function() {};

    if (typeof options.callback === "function") {
        this.callback = options.callback;
    }

    options.callback = bindFunction2(this.swipeCallback, this);

    this.swipe = new Swipe(this.element, options);
    this.createIndicators();

    if (this.nav.addEventListener) {
        this.nav.addEventListener("click",
            bindFunction2(this.onIndicatorClick, this), false);
    }

    if (this.nav.attachEvent) {
        this.nav.attachEvent("onclick",
            bindFunction2(this.onIndicatorClick, this));
    }
};

SwipeNav2.prototype.swipeCallback = function() {
    this.callback.apply(this, arguments);
    this.setActiveIndicator.apply(this, arguments);
};

SwipeNav2.prototype.createIndicators = function() {
    this.nav = document.createElement("ol");
    this.nav.className = "swipe-nav";

    var indicator, anchor;

    for (var i = 0; i < this.swipe.getNumSlides(); i++) {
        anchor = document.createElement("a");
        anchor.setAttribute("data-key", i);
        anchor.href = "#";
        anchor.innerHTML = i + 1;

        indicator = document.createElement("li");
        indicator.appendChild(anchor);

        this.nav.appendChild(indicator);
    }

    this.element.appendChild(this.nav);
    this.indicators = this.nav.getElementsByTagName("li");
    this.setActiveIndicator(0);
};

SwipeNav2.prototype.setActiveIndicator = function(index) {
    var i = this.indicators.length;
    var indicator;

    while (i--) {
        indicator = this.indicators[i];
        indicator.className = indicator.className.replace(/\bactive\b/, "");
    }

    this.indicators[index].className = "active";
};

SwipeNav2.prototype.onIndicatorClick = function(e) {
    var target = e.target || e.srcElement;

    if (target && target.tagName === "A") {
        this.swipe.slide(target.getAttribute("data-key"));
        e.preventDefault ? e.preventDefault() : e.returnValue = false;
        e.stopPropagation ? e.stopPropagation() : e.cancelBubble = true;
    }
};

function bindFunction2(func, context) {
    return function() {
        return func.apply(context, arguments);
    };
}

window.SwipeNav2 = SwipeNav2;

})();