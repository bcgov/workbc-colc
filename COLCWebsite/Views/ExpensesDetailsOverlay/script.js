define([
  'ODC',
  'jquery',
  'backbone',
  'utils/rivets',
  'data/location/model',
  'data/scenario/model',
  'data/scenario/collection',
  'jquery-tiny-pubsub',
  'Views/Overlay/script',
  'jquery.uniform',
  'jquery.validate',
  'utils/tooltip',
], function (ODC, $, Backbone, rivets, LocationModel, ScenarioModel, ScenarioCollection, PubSub, Overlay) {
  'use strict';

  return ODC.define({
    hook: 'expenses-details',

    model: new Backbone.Model({
      scenarios: new ScenarioCollection(),
      scenariosCount: 0,
      selectedScenarioIndex: -1,
      location: new LocationModel(),
      scenario: new ScenarioModel()
    }),

    instantiate: function ($el) {

      var self = this

      this.$el = $el
      this.overlay = this.findHook('overlay')
      this.$toggle = $('.expenses-details__expand', this.$el)
      this.$tooltipLabel = $('.tooltip-label', this.$el)
      this.$select = $('select', this.$el)
      this.$form = $('.expenses-details__form', this.$el)
      this.$inputs = $('.expenses-details__form input', this.$el)

      this.$tooltip = $('[data-tooltip]', this.$el)
      this.$reset = $('.expenses-details__reset', this.$el)
      this.$calculate = $('.expenses-details__submit', this.$el)

      this.$tooltip.tooltip()

      $.validator.addMethod(
        'mincomma',
        function (value, element, param) {
          return this.optional(element) || value.replace(/\,/g, '').replace(/\$/g, '') >= param;
        },
        'Please check'
      )

      this.validator = this.$form.validate({
        invalidHandler: function (form, validator) {
          $(validator.invalidElements()[0]).focus();
        },
        focusInvalid: false
      })

      this.$form.keypress(function (event) {
        if (event.which == 13) {
          if (self.validator.form()) {
            self.$inputs.trigger("blur").trigger("change")
            self.calculate()
          }
        }
      });


      //$('.expenses-details__form select:first').focus();

      // document.onkeypress = function keypressed(e) {
      //   var keyCode = (window.event) ? e.which : e.keyCode;
      //   if (keyCode == 13) {
      //     this.$inputs.trigger("change")
      //     self.calculate()
      //   }
      // }

      //if the form is visible then let enter key submit the form

      rivets.bind($el, {
        model: this.model,
        view: this
      })


      //this.$inputs.on('keyup change paste', rivets.formatters.currencyHack)


      this.model.on('change:selectedScenarioIndex', function (model) {
        self.updateScenario(model)

        $.uniform.update()
      })

      PubSub.subscribe('scenariosChange', function (scenarios, scenario) {


        self.model.get('scenarios').reset()

        self.model.set('scenariosCount', scenarios.length)

        var index = scenarios.indexOf(scenario)
        //var index = self.model.get('selectedScenarioIndex')
        index = index === -1 ? 0 : index // set to first scenario if second one was removed
        index = index > scenarios.length - 1 ? scenarios.length - 1 : index // if changed scenario was actually removed, switch to previous city


        if (scenarios.length) {
          self.model.get('scenarios').add(scenarios.models)

          if (self.model.get('selectedScenarioIndex') !== index) {
            self.model.set('selectedScenarioIndex', index)
          }
          else {
            self.updateScenario(self.model);
          }
        }

        $.uniform.update()
      })

      this.initUniform()

      this.$toggle.on('click', $.proxy(this.onToggleClickAll, this))

      this.$reset.on('click', $.proxy(this.resetAll, this))

      this.$calculate.on('click', $.proxy(this.calculate, this))

    },

    updateScenario: function (model) {
      var scenarios = model.get('scenarios')
      var scenario = scenarios.at(model.get('selectedScenarioIndex'))
      model.unset('scenario')
      model.set('scenario', scenario)
    },

    initUniform: function () {
      this.$select.uniform({
        selectClass: 'form-select icon-select',
        selectAutoWidth: false
      })
    },

    calculate: function () {
      if (this.validator.form()) {
        this.overlay.close()
        PubSub.publish('updateScenarios')
        PubSub.publish('calculate', [this.model.get('scenarios')])
        this.calculated = true
        $('.results').show()

        $('html, body').animate({
          scrollTop: $('.results').offset().top
        }, 400);


        $('.expenses-charts .is-active').each(function () {
          $(this).addClass('unresolved')
        })
        $('.loader').show()
      }
    },

    show: function () {
      this.overlay.open()

    },

    copyDetails: function () {
      var scenarios = this.model.get('scenarios')
      var currentIndex = scenarios.indexOf(this.model.get('scenario'))
      PubSub.publish('copyDetails', [currentIndex, currentIndex === 0 ? 1 : 0])
    },

    onToggleClickAll: function (e) {
      e.preventDefault()
      var action = this.$toggle.hasClass('expand-all') ? 'collapseAll' : 'expandAll'
      this[action]()
    },

    collapseAll: function () {
      this.$toggle.removeClass('expand-all')
      $.each(this.findHooks('toggle'), function (i, toggle) {
        toggle.collapse()
      })
    },

    expandAll: function () {
      this.$toggle.addClass('expand-all')
      $.each(this.findHooks('toggle'), function (i, toggle) {
        toggle.expand()
      })
    },

    resetAll: function (location) {
      this.model.get('scenario').resetDetails()
      $.uniform.update()
    }
  })
})
