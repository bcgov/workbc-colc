using ColcDataLayerWcfService.Caching;
using ColcDataLayerWcfService.Models.Occupation;
using EDMEntities;
using EDMEntities.COLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcDataLayerWcfService.Controllers
{
    public class OccupationController
    {
        public ICacheProvider Cache { get; set; }
        
        public OccupationController()
            : this(new DefaultCacheProvider())
        { }

        public OccupationController(ICacheProvider cacheProvider)
        {
            this.Cache = cacheProvider;
        }

        /// <summary>
        /// Gets a list of occupations with salaries from the database layer.
        /// </summary>
        /// <returns>List of occupations with salaries</returns>
        public IEnumerable<OccupationModels> GetOccupations()
        {
            List<OccupationModels> occupationsList = null;
            occupationsList = Cache.Get(Constants.OCCUPATIONS) as List<OccupationModels>;

            if (occupationsList == null)
            {
                using (var db = new WorkBC_EDMContext())
                {
                    IQueryable<COLC_Occupation> query = from o in db.COLC_Occupations.AsNoTracking()
                                                        select o;
                    if (query.Any())
                    {
                        occupationsList = new List<OccupationModels>();
                        foreach (COLC_Occupation occupation in query)
                        {
                            occupationsList.Add(new OccupationModels()
                            {
                                NOC_ID = occupation.NOC_ID,
                                NOCCode = occupation.NOCCode,
                                NameEnglish = occupation.NameEnglish,
                                AvgSalary = occupation.AvgSalary,
                                AlternativeJobTitles = occupation.AlternativeJobTitles
                            });
                        }
                        Cache.Set(Constants.OCCUPATIONS, occupationsList, Constants.DATA_CACHE_MINUTES);
                    }
                }
            }

            return occupationsList;
        }
    }
}