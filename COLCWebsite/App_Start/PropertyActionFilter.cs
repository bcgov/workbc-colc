using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace COLC.COLCWebsite.App_Start
{
    public class PropertyActionFilter : ActionFilterAttribute
    {
        
        /// <summary>
        /// Sets global ViewBag properties and have them available in each View
        /// 
        /// Reference: http://www.ryadel.com/2014/10/20/asp-net-mvc-set-global-viewbag-properties-for-all-views/
        /// </summary>
        /// <param name="filterContext">ResultExecutingContext</param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // ViewBag.Skin is used to switch between the WelcomeBC Cost of Living Calculator and and the WorkBC Cost of Living Calculator
            filterContext.Controller.ViewBag.Skin = "welcomebc";

            if (filterContext.HttpContext.Request.Url.Host == WebConfigurationManager.AppSettings["WelcomeBCHost"])
            {
                filterContext.Controller.ViewBag.Skin = "welcomebc";
            }
            else if (filterContext.HttpContext.Request.Url.Host == WebConfigurationManager.AppSettings["WorkBCHost"])
            {
                filterContext.Controller.ViewBag.Skin = "workbc";
            }           
        }
    }
}