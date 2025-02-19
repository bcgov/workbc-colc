 define([
   'ODC',
   'jquery',
   'underscore',
   'typeahead',
   'Views/Overview/script',
   'jquery-placeholder/jquery.placeholder',
   'utils/tooltip',
 ], function (ODC, $, _) {
   'use strict';

   return ODC.define({
     hook: 'nocs',

     config: {},

     instantiate: function ($el, data) {
       var self = this
       this.$el = $el
       this.data = data
       this.$occupations = $('#occupation', this.$el)
       this.$salary = $('#salary', this.$el)
       this.overview = this.closestHook('overview')
       this.$tooltip = $('[data-tooltip]', this.$el)
       this.$tooltip.tooltip()
       this.$occupations.placeholder();
       this.$salary.placeholder();

       this.resultsLimit = 40;
       this.AlternateHeader = '<h3>Other related options</h3>';
       this.noTitleMatch = '<h4>No match found in titles</h4>';
       this.noAlternateMatch = '<h4>No related items found</h4>';

       this.initTypeahead()

       // this.$salary.on('keyup', function () {
       //   var selector = self.$salary;
       //   var strLength = $(this).val().length;
       //   selector.focus();
       //   selector[0].setSelectionRange(strLength, strLength);
       // })

       //this.$salary.on('change paste', rivets.formatters.currencyHack)

       // this.$salary.on('keyup change paste', function () {
       //   //var selector = self.$salary;
       //   var parts = $(this).val().replace(/\,/g, '').replace(/\$/g, '')
       //   parts = parts.toString().split(".");
       //   parts[0] = parts[0].replace(/^0+(?!\.|$)/, '');
       //   parts[0] = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, ",");
       //   $(this).val(parts.join("."));
       //   conso
       // })


     },

     initTypeahead: function () {
       var self = this
       var defaultSalary = 50000
       // constructs the suggestion engine
       var occupations = new Bloodhound({
         datumTokenizer: Bloodhound.tokenizers.obj.whitespace('value'),
         queryTokenizer: Bloodhound.tokenizers.whitespace,
         limit: this.resultsLimit,

         local: $.map(this.data, function (occupation) {
           occupation.value = 'NOC ' + occupation.NOCCode + ' - ' + occupation.NameEnglish
           return occupation
         })
       });

       var alternateTitles = new Bloodhound({
         datumTokenizer: Bloodhound.tokenizers.obj.whitespace('AlternativeJobTitles'),
         queryTokenizer: Bloodhound.tokenizers.whitespace,
         limit: this.resultsLimit,

         local: $.map(this.data, function (occupation) {
           occupation.value = 'NOC ' + occupation.NOCCode + ' - ' + occupation.NameEnglish
           return occupation
         })
       });

       // kicks off the loading/processing of `local` and `prefetch`
       occupations.initialize();
       alternateTitles.initialize();

       this.$occupations.typeahead({
         hint: false,
         highlight: true,
         minLength: 1
       }, {
         name: 'titles',
         displayKey: 'value',
         templates: {
           empty: this.noTitleMatch
         },
         // `ttAdapter` wraps the suggestion engine in an adapter that
         // is compatible with the typeahead jQuery plugin
         source: occupations.ttAdapter()
       }, {
         name: 'alternate-titles',
         displayKey: 'value',
         templates: {
           empty: this.noAlternateMatch,
           header: this.AlternateHeader
         },
         source: alternateTitles.ttAdapter()
       });

       // close suggestions when suggestion was selected or autocompleted
       this.$occupations.on('typeahead:selected typeahead:autocompleted', $.proxy(function (e, datum) {
         // self.$occupations.trigger('input')
         //populate the salary textfield - if job has no salary then set a default value
         if (datum.AvgSalary !== 0) {
           // self.$salary.val(datum.AvgSalary).trigger('change')
           self.overview.model.set('salary', datum.AvgSalary)
         }
         else {
           // self.$salary.val(defaultSalary).trigger('change')
           self.overview.model.set('salary', defaultSalary)
         }
       }, this))

     }

   })

 })
