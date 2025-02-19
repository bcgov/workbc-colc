using ColcDataLayerWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcBusinessLayerWcfService.Controllers
{
    public class OccupationController
    {
        
        /// <summary>
        /// Gets a list of occupations with salaries from the database layer.
        /// </summary>
        /// <returns>List of occupations with salaries</returns>
        public IEnumerable<Models.Occupation.OccupationModels> GetOccupations()
        {
            using (var colcDataLayerService = new ColcDataLayerService())
            {
                IEnumerable<ColcDataLayerWcfService.Models.Occupation.OccupationModels> occupationsList = colcDataLayerService.GetOccupations();
                List<Models.Occupation.OccupationModels> list = null;

                if (occupationsList != null)
                {
                    list = new List<Models.Occupation.OccupationModels>();

                    foreach (var item in occupationsList)
                    {
                        Models.Occupation.OccupationModels occupation = new Models.Occupation.OccupationModels();

                        occupation.NOC_ID = item.NOC_ID;
                        occupation.NOCCode = item.NOCCode;
                        occupation.NameEnglish = item.NameEnglish;
                        occupation.AvgSalary = item.AvgSalary;
                        occupation.AlternativeJobTitles = item.AlternativeJobTitles;

                        list.Add(occupation);
                    }                    
                }

                return list;
            }
        }
    }
}