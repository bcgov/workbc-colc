define([
  'ODC',
  'jquery',
  'utils/rivets',
  'jquery-tiny-pubsub',
  'data/regionalDetails/collection'
], function (ODC, $, rivets, PubSub, RegionalDetailsCollection) {
  'use strict';

  return ODC.define({
    hook: 'regional-details',
    config: {},

    model: new Backbone.Model({
      regionalDetails: new RegionalDetailsCollection()
    }),

    instantiate: function ($el) {

      var self = this
      this.$el = $el

      this.view = rivets.bind(this.$el, {
        view: this,
        model: this.model
      })

      PubSub.subscribe('calculate', function (scenarios) {
        var regionalDetails = self.model.get('regionalDetails')

        regionalDetails.fetch(scenarios, function (data) {
          self.updateBars()
        })
      })

      PubSub.subscribe('removeLocationSet', function () {
        var regionalDetails = self.model.get('regionalDetails')
        if (regionalDetails.length > 1) {
          regionalDetails.pop()
        }
      })

    },

    updateBars: function () {
      this.model.get('regionalDetails').each(function () {

      })

      //loop through the regional Details

      //console.log('boo')
      //console.log(this.model.get('locations'));

      // $(window).bind("debouncedresize", function () {
      //   console.log('debounced resize event');
      //   setStatBarWidths();
      // });

      // function getregionaldata() {
      //   var request = [4, 8];

      //   var uri = 'api/calculator/regionaldetails';

      //   // jQuery.ajax({
      //   //   type: "GET",
      //   //   dataType: "json",
      //   //   url: uri,
      //   //   data: {
      //   //     '': request
      //   //   },
      //   //   success: function (data) {

      //   //     //console.log(data);

      //   //     // for (var i = 0; i < data.length; i++) {
      //   //     //   var object = data[i];
      //   //     //   for (var property in object) {
      //   //     //     //console.log('item ' + i + ': ' + property + '=' + object[property]);
      //   //     //   }
      //   //     //   // If property names are known beforehand, you can also just do e.g.
      //   //     //   // alert(object.id + ',' + object.Title);
      //   //     // }

      //   //     // var
      //   //     //   employmentStatFirstLabel = $('#regional-stat1').find('.regional-details__employment_stat-label'),
      //   //     //   employmentStatSecondLabel = $('#regional-stat2').find('.regional-details__employment_stat-label'),
      //   //     //   employmentStatThirdLabel = $('#regional-stat3').find('.regional-details__employment_stat-label'),
      //   //     //   employmentStatFirstValue = $('#regional-stat1').find('.regional-details__employment_stat-value'),
      //   //     //   employmentStatSecondValue = $('#regional-stat2').find('.regional-details__employment_stat-value'),
      //   //     //   employmentStatThirdValue = $('#regional-stat3').find('.regional-details__employment_stat-value'),
      //   //     //   employmentStatFirstNum = $('#regional-stat1').find('.regional-details__employment_stat-num'),
      //   //     //   employmentStatSecondNum = $('#regional-stat2').find('.regional-details__employment_stat-num'),
      //   //     //   employmentStatThirdNum = $('#regional-stat3').find('.regional-details__employment_stat-num'),
      //   //     //   employmentStatFirstNumber = addCommas(object.EmploymentGrowthStartOfOutlook),
      //   //     //   employmentStatSecondNumber = addCommas(object.EmploymentGrowthMidpointOfOutlook),
      //   //     //   employmentStatThirdNumber = addCommas(object.EmploymentGrowthEndOfOutlook);


      //   //     // // Add values to graph elements
      //   //     // employmentStatFirstLabel.html(object.DataYearStart);
      //   //     // employmentStatSecondLabel.html(object.DataYearMidpoint);
      //   //     // employmentStatThirdLabel.html(object.DataYearEnd);
      //   //     // $('.regional-details__employment_stat-label').addClass('ajax-loaded');
      //   //     // employmentStatFirstValue.attr('data-stat', object.EmploymentGrowthStartOfOutlook);
      //   //     // employmentStatSecondValue.attr('data-stat', object.EmploymentGrowthMidpointOfOutlook);
      //   //     // employmentStatThirdValue.attr('data-stat', object.EmploymentGrowthEndOfOutlook);
      //   //     // employmentStatFirstNum.html(employmentStatFirstNumber);
      //   //     // employmentStatSecondNum.html(employmentStatSecondNumber);
      //   //     // employmentStatThirdNum.html(employmentStatThirdNumber);

      //$('.regional-details__map').addClass('ajax-loaded');

      //   //     // Add other regional values
      //   //     // $('#region-name').html(object.RegionName);
      //   //     // $('#region-name').addClass('ajax-loaded');
      //   //     // $('#key-cities').html(object.KeyCities);
      //   //     // $('.regional-details__stat').addClass('ajax-loaded');
      //   //     // $('#forecasted-annual-growth-title').append('(' + object.DataYearStart + '-' + object.DataYearEnd + ')');
      //   //     // $('#forecasted-annual-growth').html(object.ForecastedAnnualEmploymentGrowth + '%');
      //   //     // $('#employment-increase-range').append('(' + object.DataYearStart + '-' + object.DataYearEnd + ')');
      //   //     // $('#total-employment-increase').html(addCommas(object.TotalEmploymentIncrease));
      //   //     // $('#top-occupations-title').append(' to ' + object.DataYearEnd);
      //   //     // $('#top-occupation-group1').html(object.TopOccupationGroup1.trim() + '&nbsp;(NOC ' + object.TopNOCCode1 + ')');
      //   //     // $('#top-occupation-group2').html(object.TopOccupationGroup2.trim() + '&nbsp;(NOC ' + object.TopNOCCode2 + ')');
      //   //     // $('#top-occupation-group3').html(object.TopOccupationGroup3.trim() + '&nbsp;(NOC ' + object.TopNOCCode3 + ')');
      //   //     // $('#top-occupation-group1').attr('title', 'Go to ' + object.TopOccupationGroup1.trim() + ' detail page');
      //   //     // $('#top-occupation-group2').attr('title', 'Go to ' + object.TopOccupationGroup2.trim() + ' detail page');
      //   //     // $('#top-occupation-group3').attr('title', 'Go to ' + object.TopOccupationGroup3.trim() + ' detail page');
      //   //     // $('.regional-details__top-occupations').addClass('ajax-loaded');

      //   //     // Add Regional map image
      //   //     // $('#region-map').attr('map-data-src', object.RegionID);
      //   //     // if ($('#region-map').attr('map-data-src') == '8') {
      //   //     //   $('#region-map').attr('src', '../UI/Images/regions/map-region-8.png');
      //   //     // }
      //   //     // if ($('#region-map').attr('map-data-src') == '7') {
      //   //     //   $('#region-map').attr('src', '../UI/Images/map-region-7.png');
      //   //     // }
      //   //     // if ($('#region-map').attr('map-data-src') == '6') {
      //   //     //   $('#region-map').attr('src', '../UI/Images/map-region-6.png');
      //   //     // }
      //   //     // if ($('#region-map').attr('map-data-src') == '5') {
      //   //     //   $('#region-map').attr('src', '../UI/Images/map-region-5.png');
      //   //     // }
      //   //     // if ($('#region-map').attr('map-data-src') == '4') {
      //   //     //   $('#region-map').attr('src', '../UI/Images/map-region-4.png');
      //   //     // }
      //   //     // if ($('#region-map').attr('map-data-src') == '3') {
      //   //     //   $('#region-map').attr('src', '../UI/Images/map-region-3.png');
      //   //     // }
      //   //     // if ($('#region-map').attr('map-data-src') == '2') {
      //   //     //   $('#region-map').attr('src', '../UI/Images/map-region-2.png');
      //   //     // }
      //   //     // $('.regional-details__map').addClass('ajax-loaded');

      //   //     // function setStatBarWidths() {
      //   //     //   var regionStats = [$('.regional-details__employment_stat')],
      //   //     //     fullBarWidth = Math.max(regionStats[0].first().find('.regional-details__employment_stat-value').width(), regionStats[0].first().next().find('.regional-details__employment_stat-value').width(), regionStats[0].last().find('.regional-details__employment_stat-value').width());

      //   //     //   $(function () {
      //   //     //     var startValue = parseFloat(object.EmploymentGrowthStartOfOutlook),
      //   //     //       midValue = parseFloat(object.EmploymentGrowthMidpointOfOutlook),
      //   //     //       endValue = parseFloat(object.EmploymentGrowthEndOfOutlook),
      //   //     //       allValues = [startValue, midValue, endValue],
      //   //     //       highestValue = Math.max(startValue, midValue, endValue),
      //   //     //       lowestValue = Math.min(startValue, midValue, endValue),
      //   //     //       medianValue = findMedian(allValues),
      //   //     //       lowestValueElement = $('[data-stat="' + lowestValue + '"]'),
      //   //     //       medianValueElement = $('[data-stat="' + medianValue + '"]'),
      //   //     //       highestValueElement = $('[data-stat="' + highestValue + '"]'),
      //   //     //       lowValueComparedToHigh = parseFloat(lowestValue / highestValue),
      //   //     //       lowValueWidth = lowValueComparedToHigh.toFixed(2) * 100,
      //   //     //       medianValueComparedToHigh = parseFloat(medianValue / highestValue),
      //   //     //       medianValueWidth = medianValueComparedToHigh.toFixed(2) * 100,
      //   //     //       lastBar = $('.regional-details__employment_stat:last-of-type .regional-details__employment_stat-value');

      //   //     //     //console.log('lowValueComparedToHigh: ' + lowValueComparedToHigh);

      //   //     //     lowestValueElement.css('width', Math.floor(lowValueWidth) + '%');
      //   //     //     medianValueElement.css('width', Math.floor(medianValueWidth) + '%');
      //   //     //     lastBar.addClass('ajax-loaded');
      //   //     //   });
      //   //     // }

      //   //     // setStatBarWidths();

      //   //   },
      //   //   error: function (error) {
      //   //     jsonValue = jQuery.parseJSON(error.responseText);

      //   //   }
      //   // });

      // }

      // getregionaldata()

      // function addCommas(intNum) {
      //   return (intNum + '').replace(/(\d)(?=(\d{3})+$)/g, '$1,');
      // }

      // function findMedian(values) {
      //   values.sort(function (a, b) {
      //     return a - b;
      //   });
      //   var half = Math.floor(values.length / 2);
      //   if (values.length % 2)
      //     return values[half];
      //   else
      //     return (values[half - 1] + values[half]) / 2.0;
      // }
    }


  })
})
