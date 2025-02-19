define(['backbone', 'data/location/model'], function (Backbone, LocationModel) {
  'use strict';

  var DetailsModel = Backbone.Model.extend({
    defaults: {
    }
  })

  var detailsDefaults = {
    CarInsuranceAmount: 0,
    ClothingAmount: 0,
    DownPaymentLevelID: 1,
    EntertainmentAmount: 0,
    FitnessAmount: 0,
    FoodAmount: 0,
    GroomingAmount: 0,
    HomeInsuranceAmount: 0,
    HouseMaintainanceAmount: 0,
    InvestmentAmount: 0,
    LifeInsuranceAmount: 0,
    MileagePerYearID: 1,
    NumAdults: 1,
    NumChildren: 0,
    NumVehicles: 1,
    OutstandingLoanPaymentsAmount: 0,
    OwnIndicatorID: 1,
    PetsAmount: 0,
    PropertyTaxAmount: 0,
    RESP: 0,
    RRSPAmount: 0,
    Salary2: 0,
    SavingsAmount: 0,
    SqFtID: 5,
    TransportationType: 1,
  }

  return Backbone.Model.extend({
    defaults: $.extend({
      location: new LocationModel(),
      Salary1: 0,
      RegionID: 0,
      LocationID: 0,
      isRenting: true,
      isOneAdult: true,
      hasNoCar: false
    }, detailsDefaults),

    initialize: function () {
      this.resetDetails()
    },

    resetDetails: function () {
      var self = this
      // this.unset('details')
      this.set(detailsDefaults)
      this.on('change:OwnIndicatorID', $.proxy(this.isRenting, this))
      this.on('change:TransportationType', $.proxy(this.hasNoCar, this))
      this.on('change:NumAdults', $.proxy(this.isOneAdult, this))
      this.isRenting()
      this.hasNoCar()
      this.isOneAdult()
    },

    isRenting: function () {
      var DownPaymentLevelID;
      this.set('isRenting', parseInt(this.get('OwnIndicatorID'), 10) === 1)
      // need to add an extra level of logic for the initial copy from first location to stop the DPL ID get reset
      if (this.get('OwnIndicatorID') === 1) {
          DownPaymentLevelID = 1;
        } else {
          DownPaymentLevelID = this.get('DownPaymentLevelID') === 1 ? 2 : this.get('DownPaymentLevelID')
        }
      this.set('DownPaymentLevelID', DownPaymentLevelID)

      this.set('PropertyTaxAmount', this.get('isRenting') ? 0 : this.get('PropertyTaxAmount'))
      this.set('HouseMaintainanceAmount', this.get('isRenting') ? 0 : this.get('HouseMaintainanceAmount'))
    },

    hasNoCar: function () {
      this.set('hasNoCar', parseInt(this.get('TransportationType'), 10) !== 1)
      this.set('NumVehicles', this.get('hasNoCar') ? 0 : this.get('NumVehicles'))
      this.set('CarInsuranceAmount', this.get('hasNoCar') ? 0 : this.get('CarInsuranceAmount'))
    },

    isOneAdult: function () {
      this.set('isOneAdult', parseInt(this.get('NumAdults'), 10) === 1)
      this.set('Salary2', this.get('isOneAdult') ? 0 : this.get('Salary2'))
    },

    toJSON: function () {
      var attributes = $.extend({}, this.attributes)
      // delete attributes.details
      delete attributes.location
      return attributes
    },

    getDetails: function () {
      var details = {}
      $.each(this.attributes, function (key, attribute) {
        if (detailsDefaults.hasOwnProperty(key)) {
          details[key] = attribute
        }
      })
      return details
    }
  })
})