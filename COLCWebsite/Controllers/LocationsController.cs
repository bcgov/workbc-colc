using ColcBusinessLayerWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace COLC.COLCWebsite.Controllers
{
    public class LocationsController : Controller
    {

        /// <summary>
        /// Displays a flat list of locations with regions, cities, and neighbourhoods
        /// </summary>
        /// <returns>Partial view containing a flat list of locations with regions, cities, and neighbourhoods</returns>
        public PartialViewResult LocationsPartial()
        {
            List<COLCWebsite.Models.Locations.LocationsModels> model = new List<Models.Locations.LocationsModels>();

            using (var colcBusinessLayerService = new ColcBusinessLayerService())
            {
                IEnumerable<ColcBusinessLayerWcfService.Models.Locations.LocationsModels> locationsList = colcBusinessLayerService.GetLocations();

                if (locationsList != null)
                {
                    model = new List<COLCWebsite.Models.Locations.LocationsModels>();

                    foreach (var item in locationsList)
                    {
                        COLCWebsite.Models.Locations.LocationsModels location = new COLCWebsite.Models.Locations.LocationsModels();

                        location.LocationID = item.LocationID;
                        location.LocationName = item.LocationName;
                        location.ParentLocationID = item.ParentLocationID;
                        location.LocationTypeID = item.LocationTypeID;

                        model.Add(location);
                    }
                }
            }

            return PartialView("~/Views/Locations/view.cshtml", model);
        }

    }
}
