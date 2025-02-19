using ColcBusinessLayerWcfService.Controllers;
using ColcBusinessLayerWcfService.Models.Calculator;
using ColcBusinessLayerWcfService.Models.ExternalLinks;
using ColcBusinessLayerWcfService.Models.Locations;
using ColcBusinessLayerWcfService.Models.Occupation;
using ColcBusinessLayerWcfService.Models.RegionalDetail;
using ColcDataLayerWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ColcBusinessLayerWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ColcBusinessLayerService : ColcBusinessLayerIService
    {
        /// <summary>
        /// Calculates the yearly Cost of Living for each city or neighbourhood.
        /// </summary>
        /// <param name="calculatorInputModels">A list of calculation results. One item is for a city or neighbourhood.</param>
        /// <returns></returns>
        public IEnumerable<CalculatorOutputModels> Calculate(IEnumerable<CalculatorInputModels> calculatorInputModels)
        {
            CalculatorController cc = new CalculatorController();

            return cc.Calculate(calculatorInputModels);
        }

        /// <summary>
        /// Gets a list of occupations with salaries from the database layer.
        /// </summary>
        /// <returns>List of occupations with salaries</returns>
        public IEnumerable<OccupationModels> GetOccupations()
        {
            OccupationController oc = new OccupationController();
            IEnumerable<OccupationModels> occupationsList = oc.GetOccupations();
            
            return occupationsList;
        }


        /// <summary>
        /// Gets regional details by region ID from the database layer.
        /// </summary>
        /// <param name="regionID"></param>
        /// <returns>Regional details data for a region</returns>
        public RegionalDetailModels GetRegionalDetailsByRegion(int regionID)
        {
            RegionalDetailController rdc = new RegionalDetailController();
            RegionalDetailModels regionalDetails = rdc.GetRegionalDetailsByRegion(regionID);
                      
            return regionalDetails;
        }


        /// <summary>
        /// Gets a flat list of locations with regions, cities, and neighbourhoods from the database layer
        /// </summary>
        /// <returns>Flat list of locations with regions, cities, and neighbourhoods</returns>
        public IEnumerable<LocationsModels> GetLocations()
        {
            LocationsController lc = new LocationsController();
            IEnumerable<LocationsModels> locationsList = lc.GetLocations();
            
            return locationsList;
            
        }

        /// <summary>
        /// Gets external links from the database.
        /// </summary>
        /// <param name="skin">visual style for a particular site (e.g. welcomebc)</param>
        /// <returns>List of external links for the skin</returns>
        public IEnumerable<ExternalLinksModels> GetExternalLinks(string skin)
        {
            ExternalLinksController ec = new ExternalLinksController();
            IEnumerable<ExternalLinksModels> externalLinksList = ec.GetExternalLinks(skin);

            return externalLinksList;
        }

        public void Dispose() { }
    }
}
