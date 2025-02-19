using ColcDataLayerWcfService.Caching;
using ColcDataLayerWcfService.Models.Tax;
using EDMEntities;
using EDMEntities.COLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ColcDataLayerWcfService.Controllers
{
    public class TaxController
    {
        public ICacheProvider Cache { get; set; }

        public TaxController()
            : this(new DefaultCacheProvider())
        { }

        public TaxController(ICacheProvider cacheProvider)
        {
            this.Cache = cacheProvider;
        }

        /// <summary>
        /// Get all tax brackets from the database.
        /// </summary>
        /// <returns>List of tax brackets </returns>
        public List<TaxModels> GetTaxes()
        {
            List<TaxModels> taxesList = null;
            taxesList = Cache.Get(Constants.TAXES) as List<TaxModels>;

            if (taxesList == null)
            {
                using (var db = new WorkBC_EDMContext())
                {
                    IQueryable<COLC_Tax> query = from t in db.COLC_Taxes.AsNoTracking()
                                                 select t;
                    if (query.Any())
                    {
                        taxesList = new List<TaxModels>();
                        foreach (COLC_Tax tax in query)
                        {
                            taxesList.Add(new TaxModels()
                            {
                                TaxID = tax.TaxID,
                                TaxTypeID = tax.TaxTypeID,
                                LowerIncomeAmount = tax.LowerIncomeAmount,
                                UpperIncomeAmount = tax.UpperIncomeAmount,
                                BaseIncomeAmount = tax.BaseIncomeAmount,
                                TaxRate = tax.TaxRate,
                                CumulativeTaxAmount = tax.CumulativeTaxAmount
                            });
                        }
                        Cache.Set(Constants.TAXES, taxesList, Constants.DATA_CACHE_MINUTES);
                    }
                }
            }

            return taxesList;
        }
    }
}