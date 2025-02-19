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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ColcDataLayerIService: IDisposable
    {
        /// <summary>
        /// Operation contract to gets values for consumable expense, health expense, housing expense, transportation expense, and basic taxes that must be retrieved from the database.
        /// </summary>
        /// <param name="calculatorInputModels">A list of inputs for the calculator. One item is for a city or neighbourhood.</param>
        /// <returns>A list of outputs containing consumable expense, health expense, housing expense, transportation expense, and basic taxes. One item is for a city or neighbourhood.</returns>
        [OperationContract]
        IEnumerable<CalculatorDataOutputModels> GetCOLCData(IEnumerable<CalculatorDataInputModels> calculatorInputModels);

        /// <summary>
        /// Operation contract to get a list of occupations with salaries.
        /// </summary>
        /// <returns>List of occupations with salaries</returns>
        [OperationContract]
        IEnumerable<OccupationModels> GetOccupations();

        /// <summary>
        /// Operation contract to get regional details from all BC regions in the database.
        /// </summary>
        /// <returns>Regional details from all BC regions</returns>
        [OperationContract]
        IEnumerable<RegionalDetailModels> GetRegionalDetails();

        /// <summary>
        /// Operation contract to get a flat list of locations with regions, cities, and neighbourhoods from the database layer
        /// </summary>
        /// <returns>Flat list of locations with regions, cities, and neighbourhoods</returns>
        [OperationContract]
        IEnumerable<LocationsModels> GetLocations();

        /// <summary>
        /// Operation contract to get external links from the database layer
        /// </summary>
        /// <returns>List of external links</returns>
        [OperationContract]
        IEnumerable<ExternalLinksModels> GetExternalLinks(string skin);      
    }

}
