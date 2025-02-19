define([
  'ODC',
  'jquery',
  'jquery-tiny-pubsub',
  'breakpoints',
  'async'

], function (ODC, $, PubSub, breakpoints) {
  'use strict';

  return ODC.define({
    hook: 'google-map',
    cityIndex: 0,
    mapZoomLevel: 4,
    labelFontSize: 8,
    isMobile: false,
    isZoomByClick: false,
    cityZoomLevel: 4,
    cityTableId: '1pn9v9AdaI9G1CgV6DKOsrlHrJxwyQznVAPyhLLLn',
    instantiate: function ($el) {
      var self = this

      this.$el = $el
      breakpoints.onChange(function (e, current, previous) {
        if (current === 'sm') {
          self.mapZoomLevel = 4;
          self.cityZoomLevel = 4;
          self.labelFontSize = 9;
          self.isMobile = true;
        }
        else {
          self.mapZoomLevel = 5;
          self.cityZoomLevel = 5;
          self.labelFontSize = 12;
          self.isMobile = false;
        }
      }.bind(this))

    },
    showMap: function (index, cityLocation) {
      var that = this;

      if (cityLocation === undefined) {
        this.initMap(index)
      }
      else {
        this.initCity(cityLocation)
      }

      //
      that.cityIndex = index;



    },

    getAPI: function (callback) {
      require(['async!https://maps.google.com/maps/api/js?client=gme-ministryofjobstourism'], function () {
        require(['vendor/maplabel-compiled'], callback)
      })
    },

    initCity: function (cityLocation) {
      var that = this;
      that.getAPI(function () {
        $('.reset-google-map__map-btn').on('click', function () {
          resetGoogleMap();
        });

        var map,
          layer_city,
          map = new google.maps.Map(that.$el[0], {
            center: new google.maps.LatLng(54.71510205751845, -125.39794921875),
            zoom: that.cityZoomLevel
          });

        var style = [{
          featureType: 'all',
          elementType: 'all',
          stylers: [{
            saturation: 0
          }]

        }];

        var styledMapType = new google.maps.StyledMapType(style, {
          map: map,
          name: 'Styled Map'
        });

        map.mapTypes.set('map-style', styledMapType);
        map.setMapTypeId('map-style');

        layer_city = new google.maps.FusionTablesLayer({
          query: {
            select: 'Lat',
            from: that.cityTableId,
            where: 'CITYOPTIONVALUE =' + cityLocation.id
          },
          options: {
            styleId: 2,
            suppressInfoWindows: true
          }
        });

        layer_city.setMap(map);

        google.maps.event.addListener(layer_city, 'click', function (e) {
          map.setZoom(7);
          map.panTo(e.latLng);

        });

        var resetGoogleMap = function () {
          map.setZoom(that.mapZoomLevel);
          map.panTo(new google.maps.LatLng(54.71510205751845, -125.39794921875));
        }
      });

    },
    initMap: function (index) {
      var that = this;

      this.getAPI(function () {

        var map,
          layer_region,
          layer_city,
          POIwindow,
          regionTableId = '1eHcJTPtU7VYTW484rLE2HGfxCdQ4Cs0w4DNeA-xb',
          regionlable = {
            "regions": [{
              "location": "North Coast & Nechako",
              "lat": 54.92714186454648,
              "long": -127.24365234375
            }, {
              "location": "Northeast",
              "lat": 57.39762405500045,
              "long": -123.06884765625
            }, {
              "location": "Cariboo",
              "lat": 52.85586417785402,
              "long": -122.62939453125
            }, {
              "location": "Thompson-Okanagan",
              "lat": 51.36375465718821,
              "long": -119.42138671875
            }, {
              "location": "Vancouver Island/Coast",
              "lat": 50.51375465718821,
              "long": -126.84814453125
            }, {
              "location": "Kootenay",
              "lat": 49.89463439573421,
              "long": -116.60888671875
            }, {
              "location": "Mainland/Southwest",
              "lat": 49.89463439573421,
              "long": -122.27783203125
            }]
          },
          regionPenAndZoom = {
            "regions": [{
              "deskzoomlevel": 7,
              "mobilezoomlevel": 6,
              "lat": 49.04720490139267,
              "long": -124.094580078125
            }, {
              "deskzoomlevel": 8,
              "mobilezoomlevel": 6,
              "lat": 49.05447918871303,
              "long": -122.552490234375
            }, {
              "deskzoomlevel": 7,
              "mobilezoomlevel": 6,
              "lat": 50.70863440082825,
              "long": -119.33349609375
            }, {
              "deskzoomlevel": 7,
              "mobilezoomlevel": 6,
              "lat": 49.837982453084834,
              "long": -116.707763671875
            }, {
              "deskzoomlevel": 7,
              "mobilezoomlevel": 6,
              "lat": 52.16045455774706,
              "long": -122.640380859375
            }, {
              "deskzoomlevel": 7,
              "mobilezoomlevel": 6,
              "lat": 54.77534585936447,
              "long": -127.584228515625
            }, {
              "deskzoomlevel": 7,
              "mobilezoomlevel": 6,
              "lat": 56.01066647040695,
              "long": -121.322021484375
            }]

          },

          selectAction = '.googleMap__selectedCity .googleMap__selectedCity__btn';
        $('.reset-google-map__map-btn').on('click', function () {
          resetGoogleMap();
        });

        that.$el.off('click', selectAction);
        that.$el.on('click', selectAction, function () {
          var cityObj = {};
          $.extend(cityObj, {
            location: $(selectAction).attr('data-location')
          }, {
            locationVal: $(selectAction).attr('data-locationVal')
          }, {
            cityIndex: that.cityIndex
          });
          PubSub.publish('updateDropdown', [
            cityObj, index
          ]);
        });
        map = new google.maps.Map(that.$el[0], {
          center: new google.maps.LatLng(54.71510205751845, -125.39794921875),
          zoom: that.mapZoomLevel
        });
        var style = [{
          featureType: 'all',
          elementType: 'all',
          stylers: [{
            saturation: 0
          }]

        }];
        var styledMapType = new google.maps.StyledMapType(style, {
          map: map,
          name: 'Styled Map'
        });
        map.mapTypes.set('map-style', styledMapType);
        map.setMapTypeId('map-style');

        layer_region = new google.maps.FusionTablesLayer({
          query: {
            select: 'geometry',
            from: regionTableId


          },
          options: {
            styleId: 2,
            suppressInfoWindows: true
          }



        });
        layer_city = new google.maps.FusionTablesLayer({
          query: {
            select: 'Lat',
            from: that.cityTableId

          },
          options: {
            styleId: 2,
            suppressInfoWindows: true
          }



        });
        var resetGoogleMap = function () {
          map.setZoom(that.mapZoomLevel);
          map.panTo(new google.maps.LatLng(54.71510205751845, -125.39794921875));
        }
        var loadCityByRegion = function (regionNum) {
          layer_city.setOptions({
            query: {
              select: 'Lat',
              from: that.cityTableId,
              where: 'DRNUM = ' + regionNum
            }
          });
          layer_region.setOptions({
            query: {
              select: 'geometry',
              from: regionTableId,
              where: 'DRNUM = ' + regionNum
            }
          });
          layer_region.setMap(map);
          layer_city.setMap(map);
          that.isZoomByClick = true;
        };


        layer_region.setMap(map);

        var clickon = function () {
          google.maps.event.addListener(layer_region, 'click', function (e) {
            var arryLatLong = e.row['DRNUM'].value - 1
            map.panTo(new google.maps.LatLng(regionPenAndZoom.regions[arryLatLong].lat, regionPenAndZoom.regions[arryLatLong].long));
            if (that.isMobile) {
              map.setZoom(regionPenAndZoom.regions[arryLatLong].mobilezoomlevel);
            }
            else {
              map.setZoom(regionPenAndZoom.regions[arryLatLong].deskzoomlevel);
            }

            loadCityByRegion(e.row['DRNUM'].value);
          });
        };
        clickon();
        google.maps.event.addListener(map, 'zoom_changed', function () {
          var zoomLevel = map.getZoom();
          if (zoomLevel >= 6) {
            layer_region.setOptions({
              styles: [{
                polygonOptions: {
                  fillOpacity: 0.05,
                  strokeWeight: 2
                }

              }]
            });
            if (that.isZoomByClick) {
              layer_city.setMap(map);
            }
          }
          else {
            that.isZoomByClick = false;
            layer_city.setMap(null);
            layer_region.setOptions({
              query: {
                select: 'geometry',
                from: regionTableId
              },
              styles: [{
                polygonOptions: {
                  fillOpacity: 1.0,
                  strokeWeight: 1
                }

              }]
            });
          }

        });

        google.maps.event.addListener(layer_city, 'click', function (e) {

          var POIwindowContent = '<div class="googleMap__selectedCity"><p> You have chosen</p>  <p>Region: <span>' + e.row['DRNAMES'].value + '</span></p><p>City: <span>' + e.row['CITYNAME'].value + '</span> </p><button type="button" class="orange googleMap__selectedCity__btn" data-action="overlay-close" data-location="' + e.row['CITYNAME'].value + '" data-locationVal="' + e.row['CITYOPTIONVALUE'].value + '"><span class="icon-map-pin-google icon-left"></span>Click here to select</button></div>';
          if (POIwindow) {
            POIwindow.close();
          }
          POIwindow = new google.maps.InfoWindow({
            content: POIwindowContent,
            position: e.latLng,
            zIndex: 0
          });

          POIwindow.open(map);

          map.panTo(e.latLng);

        });


        for (var i = 0; i < regionlable.regions.length; i++) {

          var maplabel = "mapLabel_" + i;
          maplabel = new MapLabel({
            text: regionlable.regions[i].location,
            position: new google.maps.LatLng(regionlable.regions[i].lat, regionlable.regions[i].long),
            map: map,
            fontSize: that.labelFontSize,
            align: 'center',
            minZoom: 4,
            maxZoom: 5,
            fontFamily: 'sans-serif'

          });
        }

      })

    }
  })
})
