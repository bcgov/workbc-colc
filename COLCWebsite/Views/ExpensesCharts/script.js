define([
  'ODC',
  'jquery',
  'underscore',
  'backbone',
  'utils/rivets',
  'jquery-tiny-pubsub',
  'data/expenses/collection',
  'breakpoints',
  'Views/MapOverlay/script',
  'Views/ExpensesDetailsOverlay/script',
  'flot/jquery.flot.pie',
  'flot/jquery.flot.categories',
  'flot.orderbars',
  'flot/excanvas',
  'utils/tooltip',
], function (ODC, $, _, Backbone, rivets, PubSub, ExpensesCollection, Breakpoints, MapOverlay) {
  'use strict';

  return ODC.define({
    hook: 'expenses-charts',
    config: {},

    model: new Backbone.Model({
      expenses: new ExpensesCollection(),
      locationSetsCount: 0,
      expensesCount: 0,
      tab: 0,
      isAnnual: false,
      period: "Month"
    }),

    instantiate: function ($el) {
      var self = this

      this.$el = $el
      this.expensesOverlay = this.getHook('expenses-details')

      //find the colors needed for the charts

      this.view = rivets.bind(this.$el, {
        view: this,
        model: this.model
      })


      /**
       * This gets fired off from ExpenseDetailsOverlay passing the chosen scenarios data to the charts
       * We will fire this off to the backend in order to fetch the needed expense data
       * We are also extracting the location type/parent ID from scenarios to do a check for neighbourhoods.
       */
      PubSub.subscribe('calculate', function (scenarios) {
        // Save the scenarios for later use
        self.scenarios = scenarios;
        var expenses = self.model.get('expenses');
        expenses.fetch(scenarios, function () {
          self.updateCharts()
        })
      })

      PubSub.subscribe('removeLocationSet', function () {
        var expenses = self.model.get('expenses')
        if (expenses.length > 1) {
          expenses.pop()
          self.updateCharts()
        }
      })

      PubSub.subscribe('locationSetsCountChange', function (count) {
        self.model.set('locationSetsCount', count)
      })

      // window.onresize = function (event) {
      //   self.loadPieCharts()
      // }


    },

    /**
     * Copy the parent location ID from scenarios into our model if our current
     * location has a type ID of 3 (is a neighbourhood)
     */
    checkForNeighbourhood: function (index) {
      var self = this;
      var locationTypeID = self.scenarios.at(index).get('LocationTypeID');
      var parentLocationID = self.scenarios.at(index).get('ParentLocationID');

      if (locationTypeID === 3) {
        self.model.get('expenses').at(index).set('ParentLocationID', parentLocationID);
      }
    },

    /** 
     * check if id is number or not 
     */
    checkIDval: function (id) {
      if (isNaN(parseInt(id)) || !id) {
        return false;
      }
      else {
        return true;
      }
    },

    /**
     * Need to dynamically create labels for parts of the expenses form 
     * 
     */

    createExpenseLabels: function (index) {
      var self = this;
      var arrSelectors = [];
      var arrVals = [];
      var selectedVal = "";
      var isRented = 0;
      var hasCar = 0;
      var familySize = 0;
      var adultnum = 0;
      var childnum = 0;
      var financeFactor = 5;
      // all selector names and id based array
      arrSelectors = [{
          OwnIndicatorID: 'rent-or-own'
        },
        {
          SqFtID: 'home-size'
        },
        {
          DownPaymentLevelID: 'down-payment'
        },
        {
          NumAdults: 'number-of-adults'
        },
        {
          NumChildren: 'number-of-children'
        },
        {
          TransportationType: 'transportation-type'
        },
        {
          NumVehicles: 'no-of-vehicles'
        },
        {
          MileagePerYearID: 'travel-day'
        },
        {
          SavingsAmount: 'savings'
        },
        {
          InvestmentAmount: 'investment'
        }
      ];

      for (var key in arrSelectors) {
        for (var selectors in arrSelectors[key]) {
          var arrObjSel = arrSelectors[key];
          var selname = selectors;
          var selid = arrObjSel[selectors];
          var selectedID = self.scenarios.at(index).get(selname);
          var selector = document.getElementById(selid);
          // special cases for labels
          switch (selname) {

          case 'NumAdults':
            if (self.checkIDval(selectedID)) {
              adultnum = parseInt(selectedID);
            }
            else {
              adultnum = 0;
            }

            break;

          case 'NumChildren':
            if (self.checkIDval(selectedID)) {
              childnum = parseInt(selectedID);
            }
            else {
              childnum = 0;
            }
            break;

          case 'OwnIndicatorID':
            selectedVal = selector.options[selectedID - 1].text;
            if (selectedVal == "Rent") {
              isRented = 1;
            }
            arrVals[selname] = selectedVal;
            break;
          case 'DownPaymentLevelID':
            if (isRented) {
              arrVals[selname] = "";
            }
            else {
              if ((selectedID - 1) >= 0) {
                selectedVal = selector.options[selectedID - 2].text;
                selectedVal = "(" + selectedVal + " Down payment) ";
              }
              else {
                selectedVal = selector.options[selectedID].text;
              }
              arrVals[selname] = selectedVal;
            }
            break;
          case 'TransportationType':
            selectedVal = selector.options[selectedID - 1].text;
            // $('#input1 option').size(); 

            if (selectedVal == "Car") {
              hasCar = 1;
            }
            arrVals[selname] = selectedVal;
            break;
          case 'NumVehicles':
            var sizeOpts = 0;
            // get selector options to handle errors
            sizeOpts = $('#' + selid + ' option').size();
            if (hasCar) {
              // Exception 1: 2nd cycle when 2 cities added and one city has no car selected
              if (sizeOpts > 2) {
                selectedVal = selectedID;
                // console.log("Exc1: When cycle breaks and size opts > 2 " + selectedID);
              }
              else {
                if ((selectedID) > 0) {
                  selectedVal = selector.options[selectedID - 1].text;
                }
                else {
                  // Exception 2
                  selectedVal = selector.options[selectedID].text;
                  // console.log(" Exc 2 with id >" + selectedID + " value " + selectedVal);
                }
              }
              if (selectedVal == "0") {
                // Exception 3
                selectedVal = 1;
              }
            }
            else {
              selectedVal = "";
            }
            arrVals[selname] = selectedVal;
            break;


          case 'InvestmentAmount':
            if (selectedID > 0) {
              selectedVal = selector.options[selectedID / financeFactor].text;
            }
            else {
              selectedVal = selector.options[selectedID].text;
            }
            arrVals[selname] = selectedVal;
            break;
          case 'SavingsAmount':
            if (selectedID > 0) {
              selectedVal = selector.options[selectedID / financeFactor].text;
            }
            else {
              selectedVal = selector.options[selectedID].text;
            }
            arrVals[selname] = selectedVal;
            break;
          default:
            if ((selectedID - 1) >= 0) {
              selectedVal = selector.options[selectedID - 1].text;
            }
            else {
              selectedVal = selector.options[selectedID].text;
            }
            arrVals[selname] = selectedVal;
            break;
          }

          familySize = adultnum + childnum;
          arrVals['familySize'] = familySize;
        }
      }
      // console.log(arrVals);
      return arrVals;
    },


    updateCharts: function () {
      var self = this;
      var labelArray = [];
      // Check each scenario to see if it is a neighbourhood
      for (var i = 0; i < self.model.get('expenses').length; i++) {
        self.checkForNeighbourhood(i);
      }

      // logic to update the expense labels
      for (var i = 0; i < self.model.get('expenses').length; i++) {
        var arrTest = self.createExpenseLabels(i);
        labelArray[i] = arrTest;
      }

      self.model.set('expensesCount', self.model.get('expenses').length)
      var tab = self.model.get('tab')
      if (tab === 0) {
        self.loadPieCharts()
      }
      else if (tab === 1) {
        self.loadBarChart()
      }
      $('[data-tooltip]', self.$el).tooltip()

      // function to add a wordwrap around a span

      var spanWrap = function (event) {
        var $target = $(event);
        var targetText = $target.text();
        //remove text
        var regExp = /\([^)]*\)/;
        //remove
        var matches = regExp.exec(targetText);
        var newText = targetText.replace(matches[0], '<span class="no-wrap">' + matches[0] + '</span>');
        $target.html(newText);
      }

      // get noc value form input
      var nocValue = document.getElementById("occupation").value;
      $('.print-noc-title').text(nocValue);
      // update HTML labels for expenses
      for (var index1 in labelArray) {
        if (Array.isArray(labelArray[index1])) {
          var childIndex = parseInt(index1) + 1;
          for (var indexselname in labelArray[index1]) {
            var finalArr = labelArray[index1];
            var labelval = finalArr[indexselname];
            //var childIndex = parseInt(index1) + 1;
            $('.parentCharts .expenses-charts__pie:nth-child(' + childIndex + ') .' + indexselname).text(labelval);
          }
          spanWrap('.parentCharts .expenses-charts__pie:nth-child(' + childIndex + ') .SqFtID');
          spanWrap('.parentCharts .expenses-charts__pie:nth-child(' + childIndex + ') .MileagePerYearID');
        }
      }



      // spanWrap('.SqFtID');
      // spanWrap('.MileagePerYearID');

    },

    toggleAnnual: function () {
      this.model.set('isAnnual', !this.model.get('isAnnual'))
      if (this.model.get('tab') === 1) {
        this.loadBarChart()
      }
      if (this.model.get('period') === "Month") {
        this.model.set('period', "Year")
      }
      else {
        this.model.set('period', "Month")
      }
    },

    printEx: function () {
      //var printContent = $(".expenses-charts panel");
      //printContent.print();
      window.print();

    },

    addLocationSet: function () {
      var chk = $(".page-content-main .expenses-charts");
      //add breakpoint

      var bp = Breakpoints.getCurrent()
      var scrollEl

      Breakpoints.onChange(function (e, current, previous) {
        if ((current === 'sm') || (current === 'md')) {
          scrollEl = ".overview__compare__btn"
        }
        else {
          scrollEl = ".overview"
        }
      })

      $('body,html').animate({
        scrollTop: $(scrollEl).offset().top
      }, 400)
      setTimeout(function () {
        PubSub.publish('addLocationSet')
      }, 500);


    },

    removeLocationSet: function () {
      PubSub.publish('removeLocationSet')
    },

    switchTab: function (e) {
      var index = $(e.currentTarget).index()
      this.model.set('tab', index)
      this.updateCharts()
    },

    loadPieCharts: function () {
      var self = this
      this.model.get('expenses').each(function (scenario, index) {
        self.loadPieChart(index)
      })
    },


    loadPieChart: function (index) {
      var self = this
      var isAnnual = this.model.get('isAnnual');
      var expensesModel = this.model.get('expenses').at(index)

      var bp = Breakpoints.getCurrent()
      // if (isAnnual) {
      //   var housing = expensesModel.get('HousingAndTransportationExpenseByYear')
      //   var living = expensesModel.get('LivingAndPersonalExpenseByYear')
      //   var savings = expensesModel.get('SavingsAndFinanceByYear')
      //   var tax = expensesModel.get('BasicTaxByYear')
      //   var balance = expensesModel.get('BalanceByYear')
      // }
      // else {

      //function to remove commas

      function removeComma(value) {
        return parseFloat(value.replace(/,/g, ''))
      }

      var housing = removeComma(expensesModel.get('HousingAndTransportationExpenseByMonth'))
      var living = removeComma(expensesModel.get('LivingAndPersonalExpenseByMonth'))
      var savings = removeComma(expensesModel.get('SavingsAndFinanceByMonth'))
      var tax = removeComma(expensesModel.get('BasicTaxByMonth'))
      var balance = removeComma(expensesModel.get('BalanceByMonth'))
      //}

      var colors = this.$el.data('colors');

      var dataSet = [{
        label: 'Housing & Transportation',
        data: housing,
        color: colors.housing
      }, {
        label: 'Living & Personal',
        data: living,
        color: colors.living
      }, {
        label: 'Savings & Finance',
        data: savings,
        color: colors.savings
      }, {
        label: 'Basic tax',
        data: tax,
        color: colors.tax
      }];

      var optionsPie = {
        series: {
          pie: {
            show: true,
            stroke: {
              color: "" + colors.label + ""
            },
            innerRadius: 0.4,
            label: {
              show: true,
              formatter: function (label, point) {
                return (point.percent.toFixed() + '%');
              },
              radius: 9 / 10
            }
          }
        },
        legend: {
          show: false
        }
      };

      $.plot($('.flot-pie-placeholder').eq(index), dataSet, optionsPie);

      window.onresize = function (event) {
        self.loadPieCharts()
      }

    },
    showMap: function (e, view) {

      var cityLocationObj = {},
        index = view.index,
        parentLocationID = view.expenses.attributes.ParentLocationID;

      if (typeof parentLocationID !== 'undefined') {
        cityLocationObj.id = view.expenses.attributes.ParentLocationID;
      }
      else {
        cityLocationObj.id = view.expenses.attributes.LocationID;
      }

      cityLocationObj.cityName = view.expenses.attributes.LocationName;
      this.getHook('map-overlay').show(index, cityLocationObj)
    },
    toggleExpenses: function (e) {
      var self = this;

      var $toggle = $(e.currentTarget);
      var $container = $toggle.next()

      var collapse = function () {
        $toggle.addClass('collapsed-toggle')
        $container.addClass('is-collapsed')
        $container.removeClass('not-collapsed')
        $toggle.trigger('toggle', ['collapse'])
      }

      var expand = function () {
        $toggle.removeClass('collapsed-toggle')
        $container.removeClass('is-collapsed')
        $container.addClass('not-collapsed')
        $toggle.trigger('toggle', ['expand'])
      }

      var action = $toggle.hasClass('collapsed-toggle') ? 'expand' : 'collapse'
      if (action == 'collapse') {
        collapse();
      }
      else {
        expand();
      }


    },
    loadBarChart: function () {
      var self = this
      var expenses = this.model.get('expenses');
      var data = []
      var hasNegativeValue = false
      var isAnnual = this.model.get('isAnnual');

      $('#flot-bar-placeholder').children().remove()

      var colors = this.$el.data('colors');

      function removeComma(value) {
        return parseFloat(value.replace(/,/g, ''))
      }



      expenses.each(function (expenses, index) {

        if (isAnnual) {
          var housing = removeComma(expenses.get('HousingAndTransportationExpenseByYear'))
          var living = removeComma(expenses.get('LivingAndPersonalExpenseByYear'))
          var savings = removeComma(expenses.get('SavingsAndFinanceByYear'))
          var tax = removeComma(expenses.get('BasicTaxByYear'))
          var balance = removeComma(expenses.get('BalanceByYear'))
        }
        else {
          var housing = removeComma(expenses.get('HousingAndTransportationExpenseByMonth'))
          var living = removeComma(expenses.get('LivingAndPersonalExpenseByMonth'))
          var savings = removeComma(expenses.get('SavingsAndFinanceByMonth'))
          var tax = removeComma(expenses.get('BasicTaxByMonth'))
          var balance = removeComma(expenses.get('BalanceByMonth'))
        }


        if (balance) {
          data.push([
            [balance, 0],
            [tax, 1],
            [savings, 2],
            [living, 3],
            [housing, 4]
          ])
          if (balance < 0) {
            hasNegativeValue = true
          }
        }



        // $.each(data[0], function (index, item) {
        //   item[0] = rivets.formatters.annual(item[0], self.model.get('isAnnual'))
        // })

      })


      if (data.length === 1) {

        //if one city

        var data1 = [{
          label: 'Product 1',
          data: data[0],
          bars: {
            show: true,
            barWidth: 0.8,
            horizontal: true,
            fillColor: colors.bar1,
            order: 1,
            lineWidth: 1,
            align: 'center'
          },
          color: colors.bar1
        }]
      }
      else if (data.length === 2) {
        var data1 = [{
          label: 'Product 1',
          data: data[0],
          bars: {
            show: true,
            barWidth: 0.4,
            horizontal: true,
            fillColor: colors.bar1,
            order: 2,
            lineWidth: 0
          },
          color: colors.bar1
        }, {
          label: 'Product 2',
          data: data[1],
          bars: {
            show: true,
            barWidth: 0.4,
            horizontal: true,
            fillColor: colors.bar2,
            order: 1,
            lineWidth: 0
          },
          color: colors.bar2
        }]
      }

      //both use this

      var ticks = [
        [0, 'Remaining'],
        [1, 'Basic tax <span class="icon-right icon-info" data-tooltip="" data-placement="top" title="" data-original-title="Basic tax is calculated based on the federal and provincial income tax rates provided by Canada Revenue Agency."></span>'],
        [2, 'Savings & Finance'],
        [3, 'Living & Personal'],
        [4, 'Housing & Transportation']
      ];

      //used to add the labels into the bar charts
      function delimitNumbers(str) {
        return (str + "").replace(/\b(\d+)((\.\d+)*)\b/g, function (a, b, c) {
          return (b.charAt(0) > 0 && !(c || ".").lastIndexOf(".") ? b.replace(/(\d)(?=(\d{3})+$)/g, "$1,") : b) + c;
        });
      }

      var dsHook = function (somePlot, canvascontext, series) {

        var bp = Breakpoints.getCurrent()

        // after initial plot draw, then loop the data, add the labels
        // I'm drawing these directly on the canvas, NO HTML DIVS!
        // code is un-necessarily verbose for demonstration purposes



        for (var i = 0; i < series.data.length; i++) {
          var ctx = somePlot.getCanvas().getContext('2d'); // get the context
          var allSeries = somePlot.getData(); // get your series data
          var xaxis = somePlot.getXAxes()[0]; // xAxis
          var yaxis = somePlot.getYAxes()[0]; // yAxis
          var offset = somePlot.getPlotOffset(); // plots offset
          var dP = series.data[i];
          var x = dP[0];
          var y = dP.slice(-1).pop();
          ctx['font-size'] = '14px';
          var xText = x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
          var text = '$' + xText;
          var metrics = ctx.measureText(text);
          var leftXPos = (somePlot.p2c({
            x: 0,
            y: 0
          }).left)
          // var xPos = xaxis.p2c(x) + offset.left - metrics.width; // place at end of bar
          var xPos = (xaxis.p2c(x) - (somePlot.p2c({
            x: 0,
            y: 0
          }).left)) / 2 + (somePlot.p2c({
            x: 0,
            y: 0
          }).left) + offset.left - metrics.width / 2; // place at end of bar          
          //var xPos = xaxis.p2c(x)

          var negativeText;
          var barHeight;
          if (dP.length > 2) {
            barHeight = 32;
            negativeText = 0;
          }
          else {
            barHeight = 12;
            negativeText = 16;
          }

          var yPos = yaxis.p2c(y) + offset.top - barHeight;

          //some logic if the bar width is smaller than the text
          var barWidth = (xaxis.p2c(x) - (somePlot.p2c({
            x: 0,
            y: 0
          }).left));

          var textColor, leftXpos, innerValue, chars, labelWidth, xAxis;
          var align = 'center'
          if (metrics.width + 20 > Math.abs(barWidth)) {
            textColor = colors.labelOutside
            if ((dP[0]) == 0) {
              leftXpos = barWidth + xPos + metrics.width
              innerValue = '$' + xText
              labelWidth = metrics.width;
            }
            else if ((dP[0]) >= 0) {
              align = 'left'
              leftXpos = offset.left + leftXPos + barWidth + 10;
              innerValue = '$' + xText
              labelWidth = metrics.width;
            }
            else {
              if (bp === 'sm') {
                align = 'left'
                leftXpos = offset.left + leftXPos + 15
              }
              else {
                align = 'left';

                if (-(barWidth) < xaxis.p2c(0)) {
                  leftXpos = xaxis.p2c(0) + offset.left + barWidth - metrics.width - 30;
                }
                else {
                  leftXpos = offset.left - metrics.width - 30;
                }
              }
              chars = xText.toString().split('');
              chars.shift();
              innerValue = '-$' + chars.join('')
              labelWidth = metrics.width + 30;
              //yPos = yPos + negativeText;
            }
          }
          else {
            textColor = colors.label

            if ((dP[0]) > 0) {
              leftXpos = xPos - 8
              innerValue = '$' + xText
              labelWidth = metrics.width + 15;
            }
            else {
              leftXpos = xPos - 15
              chars = xText.toString().split('');
              chars.shift();
              innerValue = '-$' + chars.join('')
              labelWidth = metrics.width + 35;
            }
          }

          var aDiv = $('<div class="barLabel"></div>').css({
            'width': labelWidth,
            'height': 20,
            'color': textColor,
            'text-align': align,
            'position': 'absolute',
            'left': leftXpos,
            'top': yPos
          }).text(innerValue).appendTo('#flot-bar-placeholder');

        }

      }

      //if there is a -ve value then need to draw a different grid so create function that
      //if +ve include border if negative remove border and add markings

      // var value = -1;

      // loadbarchart()
      var chartConfig = {
        yaxis: {
          color: "" + colors.axis + "",
          ticks: ticks,
          tickColor: "transparent",
          tickLength: 0,
          labelWidth: 180,
        },
        xaxis: {
          ticks: 4,
          color: "" + colors.axis + "",
          position: 'top',
          tickFormatter: function (num, point) {
            if ((num) < 0) {
              num = Math.abs(num)
              return '-$' + (num > 999 ? (num / 1000) + 'k' : num)
            }
            else {
              return '$' + (num > 999 ? (num / 1000) + 'k' : num)
            }
          }
        },
        grid: {
          labelMargin: 30,
          clickable: false,
          borderWidth: {
            top: 0,
            right: 0,
            bottom: 0,
            left: 1
          },
          borderColor: {
            left: "" + colors.axisLabel + ""
          },

          markings: [{
            xaxis: {
              from: -3,
              to: 3
            },
            yaxis: {
              from: -1,
              to: 5
            },
            color: "" + colors.axisLabel + ""
          }]
        },
        legend: {
          show: false
        },
        hooks: {
          drawSeries: [dsHook]
        }
      }

      if (hasNegativeValue) {
        $.extend(true, chartConfig, {
          grid: {
            borderWidth: 0
          }
        })
      }

      //need to add a change on small att.

      Breakpoints.onChange(function (e, current, previous) {
        if (current === 'sm') {
          $.extend(true, chartConfig, {
            yaxis: {
              tickLength: 0,
              labelWidth: null
            },
            xaxis: {
              ticks: 2
            },
            grid: {
              labelMargin: 10
            }
          })
        }
        else {
          $.extend(true, chartConfig, {
            yaxis: {
              tickLength: 0,
              labelWidth: 180
            },
            grid: {
              labelMargin: 30
            }
          })
        }

      }.bind(this))


      $.plot($('#flot-bar-placeholder'), data1, chartConfig);
      $('[data-tooltip]', self.$el).tooltip()
      // window.onresize = function (event) {
      //   $.plot($('#flot-bar-placeholder'), data1, chartConfig);
      // }
      window.onresize = function (event) {
        self.loadBarChart();
      }

    }

  })
})
