using ColcDataLayerWcfService.Caching;
using ColcDataLayerWcfService.Models.RegionalDetail;
using EDMEntities;
using EDMEntities.COLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcDataLayerWcfService.Controllers
{
    public class RegionalDetailController
    {
        public ICacheProvider Cache { get; set; }

        public RegionalDetailController()
            : this(new DefaultCacheProvider())
        { }

        public RegionalDetailController(ICacheProvider cacheProvider)
        {
            this.Cache = cacheProvider;
        }

        /// <summary>
        /// Gets regional details from all BC regions in the database.
        /// </summary>
        /// <returns>Regional details from all BC regions </returns>
        public IEnumerable<RegionalDetailModels> GetRegionalDetails()
        {
            List<RegionalDetailModels> regionalDetailsList = null;
            regionalDetailsList = Cache.Get(Constants.REGIONAL_DETAILS) as List<RegionalDetailModels>;

            if (regionalDetailsList == null)
            {
                using (var db = new WorkBC_EDMContext())
                {
                    IQueryable<COLC_RegionalDetail> query = from r in db.COLC_RegionalDetails.AsNoTracking()
                                                            select r;
                    if (query.Any())
                    {
                        regionalDetailsList = new List<RegionalDetailModels>();
                        foreach (COLC_RegionalDetail regionalDetail in query)
                        {
                            regionalDetailsList.Add(new RegionalDetailModels()
                            {
                                LocationID = regionalDetail.LocationID,
                                LocationName = regionalDetail.LocationName,
                                KeyCities = regionalDetail.KeyCities,
                                ForecastedAnnualEmploymentGrowth = regionalDetail.ForecastedAnnualEmploymentGrowth,
                                DataYearStart = regionalDetail.DataYearStart,
                                DataYearMidpoint = regionalDetail.DataYearMidpoint,
                                DataYearEnd = regionalDetail.DataYearEnd,
                                EmploymentGrowthStartOfOutlook = regionalDetail.EmploymentGrowthStartOfOutlook,
                                EmploymentGrowthMidpointOfOutlook = regionalDetail.EmploymentGrowthMidpointOfOutlook,
                                EmploymentGrowthEndOfOutlook = regionalDetail.EmploymentGrowthEndOfOutlook,
                                TotalEmploymentIncrease = regionalDetail.TotalEmploymentIncrease,
                                TopNOCCode1 = regionalDetail.TopNOCCode1,
                                TopOccupation1 = regionalDetail.TopOccupation1,
                                TopNOCCode2 = regionalDetail.TopNOCCode2,
                                TopOccupation2 = regionalDetail.TopOccupation2,
                                TopNOCCode3 = regionalDetail.TopNOCCode3,
                                TopOccupation3 = regionalDetail.TopOccupation3,
                            });
                        }
                        Cache.Set(Constants.REGIONAL_DETAILS, regionalDetailsList, Constants.DATA_CACHE_MINUTES);
                    }
                }
            }

            return regionalDetailsList;
        }
    }
}