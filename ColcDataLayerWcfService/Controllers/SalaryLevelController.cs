using ColcDataLayerWcfService.Caching;
using ColcDataLayerWcfService.Models.SalaryLevel;
using EDMEntities;
using EDMEntities.COLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcDataLayerWcfService.Controllers
{
    public class SalaryLevelController
    {
        public ICacheProvider Cache { get; set; }

        public SalaryLevelController()
            : this(new DefaultCacheProvider())
        { }

        public SalaryLevelController(ICacheProvider cacheProvider)
        {
            this.Cache = cacheProvider;
        }

        /// <summary>
        /// Get all salary levels from the database.
        /// </summary>
        /// <returns>A list of salary levels</returns>
        public List<SalaryLevelModels> GetSalaryLevels()
        {
            List<SalaryLevelModels> salaryLevelsList = null;
            salaryLevelsList = Cache.Get(Constants.SALARY_LEVELS) as List<SalaryLevelModels>;

            if (salaryLevelsList == null)
            {
                using (var db = new WorkBC_EDMContext())
                {
                    IQueryable<COLC_SalaryLevel> query = from s in db.COLC_SalaryLevels.AsNoTracking()
                                                 select s;
                    if (query.Any())
                    {
                        salaryLevelsList = new List<SalaryLevelModels>();
                        foreach (COLC_SalaryLevel salaryLevel in query)
                        {
                            salaryLevelsList.Add(new SalaryLevelModels()
                            {
                                SalaryLevelID = salaryLevel.SalaryLevelID,
                                Salary = salaryLevel.Salary
                            });
                        }
                        Cache.Set(Constants.SALARY_LEVELS, salaryLevelsList, Constants.DATA_CACHE_MINUTES);
                    }
                }
            }

            return salaryLevelsList;
        }    
    }
}