using ColcDataLayerWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcBusinessLayerWcfService.Controllers
{
    public class RegionalDetailController
    {
        
        /// <summary>
        /// Gets regional details by region ID from the database layer.
        /// </summary>
        /// <param name="regionID">RegionID</param>
        /// <returns>Regional details data for a region</returns>
        public Models.RegionalDetail.RegionalDetailModels GetRegionalDetailsByRegion(int regionID)
        {
            Models.RegionalDetail.RegionalDetailModels regionalDetail = null;

            using (var colcDataLayerService = new ColcDataLayerService())
            {
                ColcDataLayerWcfService.Models.RegionalDetail.RegionalDetailModels regionalDetailsData = null;

                IEnumerable<ColcDataLayerWcfService.Models.RegionalDetail.RegionalDetailModels> regionalData = colcDataLayerService.GetRegionalDetails();

                if (regionalData != null)
                {
                    regionalDetailsData = colcDataLayerService.GetRegionalDetails().Where(x => x.LocationID == regionID).SingleOrDefault();
                    regionalDetail = new Models.RegionalDetail.RegionalDetailModels();

                    regionalDetail.LocationID = regionalDetailsData.LocationID;
                    regionalDetail.LocationName = regionalDetailsData.LocationName;
                    regionalDetail.KeyCities = regionalDetailsData.KeyCities;
                    regionalDetail.ForecastedAnnualEmploymentGrowth = regionalDetailsData.ForecastedAnnualEmploymentGrowth;
                    regionalDetail.DataYearStart = regionalDetailsData.DataYearStart;
                    regionalDetail.DataYearMidpoint = regionalDetailsData.DataYearMidpoint;
                    regionalDetail.DataYearEnd = regionalDetailsData.DataYearEnd;
                    regionalDetail.EmploymentGrowthStartOfOutlook = regionalDetailsData.EmploymentGrowthStartOfOutlook;
                    regionalDetail.EmploymentGrowthMidpointOfOutlook = regionalDetailsData.EmploymentGrowthMidpointOfOutlook;
                    regionalDetail.EmploymentGrowthEndOfOutlook = regionalDetailsData.EmploymentGrowthEndOfOutlook;
                    regionalDetail.TotalEmploymentIncrease = regionalDetailsData.TotalEmploymentIncrease;
                    regionalDetail.TopNOCCode1 = regionalDetailsData.TopNOCCode1;
                    regionalDetail.TopOccupation1 = regionalDetailsData.TopOccupation1;
                    regionalDetail.TopNOCCode2 = regionalDetailsData.TopNOCCode2;
                    regionalDetail.TopOccupation2 = regionalDetailsData.TopOccupation2;
                    regionalDetail.TopNOCCode3 = regionalDetailsData.TopNOCCode3;
                    regionalDetail.TopOccupation3 = regionalDetailsData.TopOccupation3;                    
                }                
            }

            return regionalDetail;
        }
    }
}