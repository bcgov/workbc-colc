using COLC.COLCWebsite.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;


namespace COLC.COLCWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(HomeModels homeModels)
        {   
            return View(homeModels);
        }

    }
}
