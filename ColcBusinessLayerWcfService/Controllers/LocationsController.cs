//using ColcDataLayerWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ColcDataLayerWcfService.Models.Locations;
using ColcDataLayerWcfService;

namespace ColcBusinessLayerWcfService.Controllers
{
    public class LocationsController
    {
        /// <summary>
        /// Gets a flat list of locations with regions, cities, and neighbourhoods from the database layer
        /// </summary>
        /// <returns>Flat list of locations with regions, cities, and neighbourhoods</returns>
        public IEnumerable<Models.Locations.LocationsModels> GetLocations()
        {
            using (var colcDataLayerService = new ColcDataLayerService())
            {
                IEnumerable<LocationsModels> locationsList = colcDataLayerService.GetLocations();
                List<Models.Locations.LocationsModels> list = null;

                if (locationsList != null)
                {
                    list = new List<Models.Locations.LocationsModels>();

                    foreach (var item in locationsList)
                    {
                        Models.Locations.LocationsModels location = new Models.Locations.LocationsModels();

                        location.LocationID = item.LocationID;
                        location.LocationName = item.LocationName;
                        location.ParentLocationID = item.ParentLocationID;
                        location.LocationTypeID = item.LocationTypeID;

                        list.Add(location);
                    }                   
                }

                return list;
            }
        }
    }
}