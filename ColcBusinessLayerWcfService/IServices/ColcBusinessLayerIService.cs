using ColcBusinessLayerWcfService.Models.Calculator;
using ColcBusinessLayerWcfService.Models.ExternalLinks;
using ColcBusinessLayerWcfService.Models.Locations;
using ColcBusinessLayerWcfService.Models.Occupation;
using ColcBusinessLayerWcfService.Models.RegionalDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ColcBusinessLayerWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ColcBusinessLayerIService : IDisposable
    {

        /// <summary>
        /// Operation contract to calculate the yearly Cost of Living for each city or neighbourhood.
        /// </summary>
        /// <param name="calculatorInputModels">A list of calculation results. One item is for a city or neighbourhood.</param>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<CalculatorOutputModels> Calculate(IEnumerable<CalculatorInputModels> calculatorInputModels);

        /// <summary>
        /// Operation contract to get a list of occupations with salaries from the database layer.
        /// </summary>
        /// <returns>List of occupations with salaries</returns>
        [OperationContract]
        IEnumerable<OccupationModels> GetOccupations();

        /// <summary>
        /// Operation contract to get regional details by region ID from the database layer.
        /// </summary>
        /// <param name="regionID"></param>
        /// <returns>Regional details data for a region</returns>
        [OperationContract]
        RegionalDetailModels GetRegionalDetailsByRegion(int regionID);

        
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
