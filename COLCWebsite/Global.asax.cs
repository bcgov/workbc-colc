using AutoMapper;
using COLC.COLCWebsite.App_Start;
using COLC.COLCWebsite.Models.Calculator;
using ColcBusinessLayerWcfService.Models.Calculator;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace COLC.COLCWebsite
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801
	public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Use Automapper to map calculator input models between the presentation
            // and business layers
            Mapper.CreateMap<CalculatorRequestModels, CalculatorInputModels>();

            // Sets global ViewBag properties and have them available in each View
            GlobalFilters.Filters.Add(new PropertyActionFilter(), 0);
        }
    }
}
