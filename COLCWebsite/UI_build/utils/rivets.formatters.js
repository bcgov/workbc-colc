define(['underscore', 'rivets'], function (_, rivets) {
  'use strict';

  /*
  Compare 2 values for equality
  Usage:
  <div rv-if="user:country | eq 'Canada'">Lovely day, eh?</div>"
   */

  rivets.formatters.eq = function (value, compare) {

    return value == compare
  }
  rivets.formatters.neq = function (value, compare) {
    return value != compare
  }
  rivets.formatters.gt = function (value, compare) {
    value = parseInt(value, 10)
    compare = parseInt(compare, 10)
    return value > compare
  }
  rivets.formatters.lt = function (value, compare) {
    value = parseInt(value, 10)
    compare = parseInt(compare, 10)
    return value < compare
  }
  rivets.formatters.annual = function (value, isAnnual) {  
    //return isAnnual ? this.get('BasicTaxByMonth') : value
  }
  rivets.formatters.propertyBy = function (model, property, period, currency) {
    if(parseFloat(model.get(property + 'By' + period)) < 0){
      return '-' + currency + model.get(property + 'By' + period).replace(/\-/g, '')
    }else{
      return currency + model.get(property + 'By' + period)
    }
  }
  rivets.formatters.expenseNeqZero = function (model, property, period) {
    // check if property is an array
    if (property.indexOf(',') > -1) { 
      var arrayList = property.split(',');
      var valuePresent = false;
      //need to loop through expenses
      for(var i=0;i < arrayList.length; i++){
        var expenseValue = parseFloat(model.get(arrayList[i] + 'By' + period));
        if(expenseValue !== 0){
            valuePresent = true;
        }
      }
      if(valuePresent){
        return false;
      }else{
        return true;
      }

    }else{
      var expenseValue = parseFloat(model.get(property + 'By' + period));
      if(expenseValue == 0){
        return true;
      }else{
        return false;
      }
    }
  }  
  rivets.formatters.thousandDelimiter = function (value, delimiter) {
    delimiter = delimiter || ','
    return (value + '').replace(/(\d)(?=(\d{3})+$)/g, '$1,');
  }

  rivets.formatters.currency = {

    read: function(value,hideZeroCurrency) {

      var currency = '$'
      currency = hideZeroCurrency && !value ? '' : currency
      if(typeof value === 'undefined'){value = 0}  
       var parts = value.toString().replace(/\,/g, '').replace(/\$/g, '')      
       parts = parts.split(".");

       parts[0] = parts[0].replace(/^0+(?!\.|$)/, '');
       parts[0] = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, ",");
       
       //if(){
          return currency+parts.join(".");
       //}else{
        //console.log(parts.join("."))
        //return parts.join(".");
        //console.log('read')
        //return value

       //} 
       
      // return (value / 100).toFixed(2)
    },
    publish: function(value, currency) {
      return value.replace(/\,/g, '').replace(/\$/g, '');
      // return Math.round(parseFloat(value) * 100)
    }
  }

  rivets.formatters.currencyHack = function () {
     //var selector = self.$salary;
     var parts = $(this).val().replace(/\,/g, '').replace(/\$/g, '')
     parts = parts.toString().split(".");
     parts[0] = parts[0].replace(/^0+(?!\.|$)/, '');
     parts[0] = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, ",");
      //parts[0] = parts[0].replace(/(\d)(?=(\d{3})+$)/g, '$1,')     
     $(this).val(parts.join("."));

  }

  /*
  Simple string interpolation, pass in the string as value and any number of paramaters to fill in
  Usage:
    Assuming you have a model for `user` with the `name` set to 'Max'
      { 'Hello {0}{1}' | format user:name '!' }
      -> 'Hello Max!'
   */
  rivets.formatters.format = function (string) {
    string = string || '{0}'
    var params = _.toArray(arguments).slice(1)

    _.each(params, function (param, index) {
      var regEx = new RegExp('\\{' + index + '\\}', 'gm');
      string = string.replace(regEx, param);
    })

    return string;
  }

  return rivets
})
