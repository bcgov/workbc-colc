using ColcDataLayerWcfService.Controllers;
using ColcDataLayerWcfService.CustomExceptions;
using ColcDataLayerWcfService.Models.Calculator;
using ColcDataLayerWcfService.Models.ExternalLinks;
using ColcDataLayerWcfService.Models.Locations;
using ColcDataLayerWcfService.Models.Occupation;
using ColcDataLayerWcfService.Models.RegionalDetail;
using ColcDataLayerWcfService.Models.SalaryLevel;
using ColcDataLayerWcfService.Models.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ColcDataLayerWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ColcDataLayerService : ColcDataLayerIService
    {

        /// <summary>
        /// Gets values for consumable expense, health expense, housing expense, transportation expense, and basic taxes that must be retrieved from the database.
        /// </summary>
        /// <param name="calculatorInputModels">A list of inputs for the calculator. One item is for a city or neighbourhood.</param>
        /// <returns>A list of outputs containing consumable expense, health expense, housing expense, transportation expense, and basic taxes. One item is for a city or neighbourhood.</returns>
        public IEnumerable<CalculatorDataOutputModels> GetCOLCData(IEnumerable<CalculatorDataInputModels> calculatorDataInputModels)
        {
            CalculatorController cc = new CalculatorController();

            return cc.GetCOLCData(calculatorDataInputModels);
        }


        /// <summary>
        /// Gets a list of occupations with salaries.
        /// </summary>
        /// <returns>List of occupations with salaries</returns>
        public IEnumerable<OccupationModels> GetOccupations()
        {
            OccupationController oc = new OccupationController();
            IEnumerable<OccupationModels> occupationsList = oc.GetOccupations();
            
            return occupationsList;
        }


        /// <summary>
        /// Gets regional details from all BC regions in the database.
        /// </summary>
        /// <returns>Regional details from all BC regions</returns>
        public IEnumerable<RegionalDetailModels> GetRegionalDetails()
        {
            RegionalDetailController rd = new RegionalDetailController();
            IEnumerable<RegionalDetailModels> regionalDetailsList = rd.GetRegionalDetails();
            
            return regionalDetailsList;            
        }


        /// <summary>
        /// Gets a flat list of locations with regions, cities, and neighbourhoods from the database.
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
