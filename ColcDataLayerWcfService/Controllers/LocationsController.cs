using ColcDataLayerWcfService.Caching;
using ColcDataLayerWcfService.Models.Locations;
using EDMEntities;
using EDMEntities.COLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcDataLayerWcfService.Controllers
{
    public class LocationsController
    {
        public ICacheProvider Cache { get; set; }

        public LocationsController()
            : this(new DefaultCacheProvider())
        { }

        public LocationsController(ICacheProvider cacheProvider)
        {
            this.Cache = cacheProvider;
        }

        /// <summary>
        /// Gets a flat list of locations with regions, cities, and neighbourhoods from the database layer
        /// </summary>
        /// <returns>Flat list of locations with regions, cities, and neighbourhoods</returns>
        public IEnumerable<LocationsModels> GetLocations()
        {
            List<LocationsModels> locationsList = null;
            locationsList = Cache.Get(Constants.LOCATIONS) as List<LocationsModels>;

            if (locationsList == null)
            {
                using (var db = new WorkBC_EDMContext())
                {
                    IQueryable<COLC_Location> query = from l in db.COLC_Locations.AsNoTracking()
                                                      where l.LocationID != 1 // exclude British Columbia
                                                      select l;
                    if (query.Any())
                    {
                        locationsList = new List<LocationsModels>();
                        foreach (COLC_Location location in query)
                        {
                            locationsList.Add(new LocationsModels()
                            {
                                LocationID = location.LocationID,
                                LocationName = location.LocationName,
                                ParentLocationID = location.ParentLocationID,
                                LocationTypeID = location.LocationTypeID
                            });
                        }
                        Cache.Set(Constants.LOCATIONS, locationsList, Constants.DATA_CACHE_MINUTES);
                    }
                }
            }

            return locationsList;
        }
    }
}