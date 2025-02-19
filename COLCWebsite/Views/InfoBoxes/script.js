define([
  'ODC',
  'jquery',
  'jquery-tiny-pubsub',
  'breakpoints',
  'debounced-resize',
  'swipe'
], function (ODC, $, PubSub, breakpoints) {
  'use strict';

  return ODC.define({
    hook: 'bc-newcomers-and-residents',
    config: {},
    initialized: false,
    initialize: function ($el) {
      var self = this,
        $swipeNav = $('.swipe-nav:eq(0)'),
        $swipeNav2 = $('.swipe-nav:eq(1)');
      PubSub.subscribe('calculate', function () {
        breakpoints.onChange(function (e, current, previous) {
          equalizeInfoBlocks('#bc-resident-info');
          equalizeInfoBlocks('#bc-newcomer-info');

          if ((current === 'sm') || (current === "'sm'")) {

            if (!self.initialized) {

              setTimeout(function () {
                // Initialize carousel when on mobile
                window.mySwipe = Swipe(carouselNewcomer, {
                  startSlide: 0,
                  callback: function (index, element) {
                    var $nav = $(element).parent().next();

                    //loop through the li's to add an on class
                    $nav.find('.active').removeClass('active');
                    $nav.find('li:eq(' + index + ')').addClass('active');
                  }
                });

                window.mySwipe2 = Swipe(carouselResidents, {
                  startSlide: 0,
                  callback: function (index, element) {
                    var $nav = $(element).parent().next();
                    //loop through the li's to add an on class
                    $nav.find('.active').removeClass('active');
                    $nav.find('li:eq(' + index + ')').addClass('active');
                  }
                });
                $('.swipe-nav').find('.active').removeClass('active').end().find('li:eq(0)').addClass('active');
                self.initialized = true;
                $swipeNav.on('click touchstart', 'li', function () {
                  window.mySwipe.slide($(this).index());
                });
                $swipeNav2.on('click touchstart', 'li', function () {
                  window.mySwipe2.slide($(this).index());
                });
              }, 50);
            }
          }
          else {
            self.initialized = true;
          }

        }.bind(this))

      })

      function equalizeInfoBlocks(element) {

        function applyValues() {
          var infoBlocks = [$(element).find('.bc-newcomers-and-residents__info-item .wrapper')],
            tallestBlock = Math.max(infoBlocks[0].first().height(), infoBlocks[0].first().next().height(), infoBlocks[0].last().height());

          // apply tallest block paragraph height to all others
          $(element).find('.bc-newcomers-and-residents__info-item .wrapper').css('height', tallestBlock + 'px');

        }

        $(element).find('.bc-newcomers-and-residents__info-item .wrapper').removeAttr('style');
        setTimeout(function () {
          applyValues();
        }, 50);


      }

      var carouselNewcomer = document.getElementById('bc-newcomer-info'),
        carouselResidents = document.getElementById('bc-resident-info');



      $(window).bind("debouncedresize", function () {

        // Initialize carousel when window resized to mobile width
        if ($(window).width() < 600) {
          var carouselPresent = $('.swipe-wrap[style]');



          if (self.initialized) {

            window.mySwipe = Swipe(carouselNewcomer, {
              startSlide: 0,
              callback: function (index, element) {
                var $nav = $(element).parent().next();

                //loop through the li's to add an on class
                $nav.find('.active').removeClass('active');
                $nav.find('li:eq(' + index + ')').addClass('active');
              }
            });
            window.mySwipe2 = Swipe(carouselResidents, {
              startSlide: 0,
              callback: function (index, element) {
                var $nav = $(element).parent().next();

                //loop through the li's to add an on class
                $nav.find('.active').removeClass('active');
                $nav.find('li:eq(' + index + ')').addClass('active');
              }
            });
            $('.swipe-nav').find('.active').removeClass('active').end().find('li:eq(0)').addClass('active');
            $swipeNav.on('click touchstart', 'li', function () {
              window.mySwipe.slide($(this).index());
            });
            $swipeNav2.on('click touchstart', 'li', function () {
              window.mySwipe2.slide($(this).index());
            });
          }



        }

        // When window is mobile sized, equalize heights of info blocks
        if ($(window).width() < 600) {
          $('.bc-newcomers-and-residents__info-item .wrapper').removeAttr('style');
          //console.log('Remove height attributes');

          equalizeInfoBlocks('#bc-newcomer-info');
          equalizeInfoBlocks('#bc-resident-info');

        }


        if ($(window).width() >= 600) {
          $('.bc-newcomers-and-residents__info-item .wrapper').removeAttr('style');

        }

        // Kill carousel when on tablet or desktop
        if ($(window).width() >= 600) {
          var carouselPresent = $('.swipe-wrap[style]');
          if (carouselPresent.length) {

            $swipeNav.off('click');
            $swipeNav2.off('click');
            window.mySwipe.kill();
            window.mySwipe2.kill();


          }
        }

        //When window is desktop, equalize heights of info blocks
        if ($(window).width() >= 980) {

          equalizeInfoBlocks('#bc-newcomer-info');
          equalizeInfoBlocks('#bc-resident-info');

        }

      });



    }

  })
})
