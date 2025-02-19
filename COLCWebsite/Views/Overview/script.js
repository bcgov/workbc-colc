define([
  'ODC',
  'jquery',
  'backbone',
  'utils/rivets',
  'jquery-tiny-pubsub',
  'data/locationSet/collection',
  'data/locationSet/model',
  'data/scenario/collection',
  'Views/MapOverlay/script',
  'Views/ExpensesCharts/script',
  'Views/ExpensesDetailsOverlay/script',
  'jquery.validate'

], function (ODC, $, Backbone, rivets, PubSub, LocationSetCollection, LocationSetModel, ScenarioCollection, MapOverlay) {
  'use strict';



  return ODC.define({
    hook: 'overview',
    config: {},

    model: new Backbone.Model({
      occupation: '',
      salary: '',
      locationSets: new LocationSetCollection(),
      locationSetsCount: 0,
      scenarios: new ScenarioCollection(),
      noNeighbourhoodLayout: false
    }),

    initialize: function ($el) {

      var self = this
      this.$el = $el
      this.$form = $('.overview__form', $el)
      this.$salary = $('.overview__form #salary', $el)

      $.validator.addMethod(
        'mincomma',
        function (value, element, param) {
          //return this.optional( element ) || value >= param;
          return this.optional(element) || value.replace(/\,/g, '').replace(/\$/g, '') >= param;
        },
        'Please check'
      )

      this.validator = this.$form.validate();
      this.$form.keypress(function (event) {
        if (event.which == 13) {
          self.$salary.trigger("change");
          self.enterExpenses()
        }
      });

      this.model.on('change:salary change:occupation', $.proxy(this.updateScenarios, this))

      this.model.get('scenarios').on('add', $.proxy(this.addPreservedDetails, this))

      this.model.get('scenarios').on('remove', $.proxy(this.storePreservedDetails, this))

      this.model.get('locationSets').on('add remove change:location', $.proxy(this.updateScenarios, this))
      this.model.get('locationSets').on('add remove', function (e) {
        PubSub.publish('locationSetsCountChange', [self.model.get('locationSets').length])
        PubSub.publish('scenarioCountChange', [self.model.get('scenarios').length])
      })

      PubSub.subscribe('updateScenarios', $.proxy(this.updateScenarios, this))
      PubSub.subscribe('addLocationSet', $.proxy(this.addLocationSet, this))
      PubSub.subscribe('removeLocationSet', $.proxy(this.onRemoveLocationSet, this))

      PubSub.subscribe('copyDetails', $.proxy(this.onCopyDetails, this))

      PubSub.subscribe('calculate', $.proxy(this.updateExpenseButtons, this))

      this.expensesOverlay = this.getHook('expenses-details')

      this.addLocationSet()

      rivets.bind($el, {
        model: this.model,
        view: this
      })

      this.$el.removeClass('unresolved')

      $(this).on('updateNeighbourhoodLayout', this.updateNeighbourhoodLayout)
    },

    addLocationSet: function () {
      this.model.get('locationSets').add(new LocationSetModel())
      //PubSub.unsubscribe(PubSub.subscribe('addLocationSet', $.proxy(this.addLocationSet, this)))
    },

    onRemoveLocationSet: function (index) {
      this.model.get('locationSets').pop()
    },

    removeLocationSet: function (index) {
      PubSub.publish('removeLocationSet')
      //PubSub.subscribe('addLocationSet', $.proxy(this.addLocationSet, this))
    },

    addPreservedDetails: function (scenario, scenarios) {
      var locationSets = this.model.get('locationSets').at(scenarios.length - 1)
      var details = locationSets.get('details')
      if (details) {
        scenario.set(details)
      }
      // else if (scenarios.length > 1) {
      //   this.copyDetailsFromTo(0, 1)
      // }
    },

    storePreservedDetails: function (scenario, scenarios) {
      var locationSet = this.model.get('locationSets').at(scenarios.length)
      if (locationSet) {
        locationSet.set('details', scenario.getDetails())
      }
    },

    updateScenarios: function () {

      var self = this
      var locationSets = this.model.get('locationSets')

      this.model.set('locationSetsCount', locationSets.length)

      locationSets.each(function (locationSet, index) {
        var location = locationSet.get('location')
        var salary = self.model.get('salary')
        var scenario = self.model.get('scenarios').at(index)
        var data = {}
        var parentLocation

        if (location && salary) {
          data.location = location
          data.Salary1 = salary
          data.RegionID = location.get('RegionID')
          data.LocationID = location.get('LocationID')
          data.LocationName = location.get('LocationName')
          data.LocationTypeID = location.get('LocationTypeID')
          data.ParentLocationID = location.get('ParentLocationID')

          if (data.LocationTypeID === 3) {
            parentLocation = locationSet.get('locations').findWhere({
              LocationID: data.ParentLocationID
            })
            data.LocationName = parentLocation.get('LocationName') + ' - ' + data.LocationName
          }
          // $.extend(data, location.get('details').toJSON())
          if (scenario) {
            scenario.set(data)
          }
          else {
            self.model.get('scenarios').add(data)
          }

        }
        else if (scenario) {
          self.model.get('scenarios').remove(scenario)
        }
      })

      if (this.model.get('scenarios').length > locationSets.length) {
        this.model.get('scenarios').pop()
      }
    },

    onCopyDetails: function (from, to) {
      this.copyDetailsFromTo(0, 1)
    },

    copyDetailsFromTo: function (from, to) {
      var self = this
      var fromScenarioDetails = self.model.get('scenarios').at(from).getDetails()
      self.model.get('scenarios').at(to).set(fromScenarioDetails)
    },

    showMap: function (e, view) {
      this.getHook('map-overlay').show(view.index)
    },

    /**
     * Called when CTA is clicked
     * Finds the currently clicked location's model and pass it off with 'scenariosChange'
     * @param  {object} event  event object
     * @param  {object} view  holds rivets index/backbone models etc
     */
    enterExpenses: function (event, view) {
      var self = this;

      if (self.validator.form()) {
        var index = view.index;
        var scenario = self.model.get('scenarios').at(index);

        PubSub.publish('scenariosChange', [self.model.get('scenarios'), scenario])

        self.expensesOverlay.show()
        if ($('html').hasClass('no-touch')) {
          $('.expenses-details__form select:first').focus();
        }
      }

    },

    /**
     * Updates the model's noNeighbourhoodLayout property based an event
     * fired from Locations
     *
     * @param  {event} e  Holds an overview property that points to the Overview
     * object as well as a neighbourhoodVisible property
     */
    updateNeighbourhoodLayout: function (e) {
      var self = this;
      self.model.set('noNeighbourhoodLayout', !e.neighbourhoodVisible);
    },

    /**
     * Updates the expense buttons' lables
     * This only affects buttons that are currently visible
     */
    updateExpenseButtons: function () {
      var self = this;
      var $btns = $('.overview__submit', self.$el);

      $btns.each(function () {
        $('.add', this).hide().next().show();
      })
    }

  })
})
