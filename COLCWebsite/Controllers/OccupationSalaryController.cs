using ColcBusinessLayerWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COLC.COLCWebsite.Controllers
{
    public class OccupationSalaryController : Controller
    {

        /// <summary>
        /// Displays a list of occupations with salaries
        /// </summary>
        /// <returns>Partial view containing a list of occupations with salaries</returns>
        public PartialViewResult OccupationSalaryPartial()
        {
            List<COLCWebsite.Models.OccupationSalary.OccupationSalaryModels> model = new List<Models.OccupationSalary.OccupationSalaryModels>();

            using (var colcBusinessLayerService = new ColcBusinessLayerService())
            {
                IEnumerable<ColcBusinessLayerWcfService.Models.Occupation.OccupationModels> occupationsList = colcBusinessLayerService.GetOccupations();

                if (occupationsList != null)
                {
                    model = new List<COLCWebsite.Models.OccupationSalary.OccupationSalaryModels>();

                    foreach (var item in occupationsList)
                    {
                        COLCWebsite.Models.OccupationSalary.OccupationSalaryModels occupation = new COLCWebsite.Models.OccupationSalary.OccupationSalaryModels();

                        occupation.NOCCode = item.NOCCode;
                        occupation.NameEnglish = item.NameEnglish;
                        occupation.AvgSalary = item.AvgSalary;
                        occupation.AlternativeJobTitles = item.AlternativeJobTitles;

                        model.Add(occupation);
                    }
                }
            }

            return PartialView("~/Views/OccupationSalary/view.cshtml", model);
        }

    }
}
