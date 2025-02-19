 define([
   'ODC',
   'jquery',
   'underscore',
   'jquery-tiny-pubsub',
   'jquery.uniform',
   'Views/Overview/script'
 ], function (ODC, $, _, PubSub) {
   'use strict';

   return ODC.define({
     hook: 'locations',

     config: {},

     instantiate: function ($el, data) {
       var self = this

       this.$el = $el
       this.data = $('#locationsData').data('locations-data')
       this.$select = $('select', this.$el)
       this.$locationId = $('.location-id', this.$el)
       this.$locationName = $('.location-name', this.$el)
       this.overview = this.closestHook('overview')

       this.locations = {
         location: {
           typeID: 1,
           $dropdown: $('.locations-region', this.$el)
         },
         city: {
           typeID: 2,
           $dropdown: $('.locations-city', this.$el)
         },
         nbhd: {
           typeID: 3,
           $dropdown: $('.locations-neighbourhood', this.$el)
         }
       }

       _.each(this.locations, function (location, type) {
         location.data = location.currentData = _.where(self.data, {
           LocationTypeID: self.locations[type].typeID
         })
       })

       this.populateDropdown('city')
       this.populateDropdown('nbhd')

       this.setChangeListener()

       this.initUniform()
       PubSub.subscribe('updateDropdown', $.proxy(self.updateDropdown, self));

       //initially call Vancouver as default City
       // var cityDefault = {
       //   location: "Vancouver",
       //   locationVal: "133",
       //   cityIndex: 0
       // }
       // this.updateDropdown(cityDefault, 0);
     },

     updateDropdown: function (city, index) {
       // console.log(city, index, this.$el.data('index'))
       if (index === this.$el.data('index')) {
         this.locations.location.$dropdown.val('').trigger('change')
         this.locations.city.$dropdown.val(city.locationVal).trigger('change')
         // this.overview.model.get('locationSets').at(index).set('city', city.locationVal)
       }
     },

     setChangeListener: function () {
       var self = this
       _.each(this.locations, function (location, type) {
         location.$dropdown.on('change', function () {
           if (!self.preventChange) {

             // The Android native browser seems to lose the selected value in cases
             // where the dropdown is too long. Do a check here and grab the previous
             // value if null is returned from the dropdown
             if ($(this).val() !== null) {
               $(this).data('previous', $(this).val());
             }
             else {
               var prev = $(this).data('previous');
               if (typeof prev !== 'undefined') {
                 $(this).val(prev);
               }
             }
             self.onChange(type)
           }
         })
       })
     },

     initUniform: function () {
       this.$select.uniform({
         selectClass: 'form-select icon-select',
         selectAutoWidth: false
       })
     },


     onChange: function (type) {
       var self = this
       var val = this.locations[type].$dropdown.val()
       self.preventChange = true

       if (type === 'location') {
         self.populateDropdown('city')
         self.populateDropdown('nbhd')
       }
       else if (type === 'city') {
         self.populateDropdown('nbhd')
         this.selectByParent(val, 'location')

         self.populateDropdown('city', true)
       }
       else if (type === 'nbhd') {
         this.selectByParent(val, 'city')
         this.selectByParent(this.locations.city.$dropdown.val(), 'location')
         self.populateDropdown('city', true)
         self.populateDropdown('nbhd', true)
       }

       self.preventChange = false

       //add in value for the hidden fields for the json to use
       //add in the city name
       this.$locationName.val(this.locations.city.$dropdown.find('option:selected').text()).trigger('input');
       //add in the ID either for city or nbhd if valid
       if (this.locations.nbhd.$dropdown.prop('disabled')) {
         this.$locationId.val(this.locations.city.$dropdown.val()).trigger('input')
       }
       else {
         this.$locationId.val(this.locations.nbhd.$dropdown.val()).trigger('input')
       }

     },


     selectByParent: function (val, type) {
       if (val !== '') {
         var parentID = _.findWhere(this.data, {
           LocationID: parseInt(val, 10)
         }).ParentLocationID
         this.locations[type].$dropdown.val(parentID).trigger('change')
       }
     },

     populateDropdown: function (type, reselect) {
       var self = this
       var data = this.locations[type].data
       var val = this.locations[type].$dropdown.val()

       if (type === 'city' || type === 'nbhd') {
         var parentType = type === 'city' ? 'location' : 'city'
         var parentVal = this.locations[parentType].$dropdown.val()

         if (parentVal !== '') {
           data = _.where(data, {
             ParentLocationID: parseInt(parentVal, 10)
           })
         }
         else {
           data = _.filter(data, function (location) {
             return _.pluck(self.locations[parentType].currentData, 'LocationID').indexOf(location.ParentLocationID) !== -1
           })
         }
       }

       /**
        * Fire off an event to the overview object if the current selected city
        * contains no neighbourhood data
        */
       if (type === 'nbhd') {
         var $locationsContainer = $('.locations-container__nbhd', self.$el);

         if (data.length === 0) {
           $locationsContainer.hide();
         }
         else {
           $locationsContainer.show();
         }

         if (self.$el.data('index') === 0) {
           // Only fire off the event if we're on the first city
           if (typeof self.overview !== undefined) {
             $(self.overview).trigger({
               type: 'updateNeighbourhoodLayout',
               neighbourhoodVisible: $locationsContainer.is(":visible")
             });
           }
         }
       }

       this.locations[type].currentData = data

       var $dropdown = this.locations[type].$dropdown
       $dropdown.find('option:not(:first)').remove()
       _.each(data, function (location) {
         $dropdown.append('<option value="' + location.LocationID + '">' + location.LocationName + '</option>')
       })
       $dropdown.prop('disabled', data.length === 0)

       if (reselect) {
         this.locations[type].$dropdown.val(val)
       }
       this.locations[type].$dropdown.trigger('change')

       $.uniform.update(this.locations[type].$dropdown)
       $.uniform.update(this.locations.location.$dropdown)
     }
   })
 })
