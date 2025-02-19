using ColcBusinessLayerWcfService;
using ColcBusinessLayerWcfService.CustomExceptions;
using Elmah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COLC.COLCWebsite.Controllers
{
    public class InfoBoxesController : Controller
    {
        /// <summary>
        /// Displays a list of external links in the info boxes.
        /// </summary>
        /// <returns>Partial view containing a list of external links in the info boxes</returns>
        public PartialViewResult InfoBoxesPartial(string skin = "welcomebc")
        {
            List<COLCWebsite.Models.InfoBoxes.InfoBoxesModels> model = new List<COLCWebsite.Models.InfoBoxes.InfoBoxesModels>();

            using (var colcBusinessLayerService = new ColcBusinessLayerService())
            {
                IEnumerable<ColcBusinessLayerWcfService.Models.ExternalLinks.ExternalLinksModels> externalLinksList = null;
                try
                {
                    externalLinksList = colcBusinessLayerService.GetExternalLinks(skin);
                }
                catch (KenticoCMSDatabaseException ke) // As requested by the client, handle Kentico database errors gracefully without stopping the entire application.
                {
                    // Reference: http://stackoverflow.com/questions/88326/does-elmah-handle-caught-exceptions-as-well
                    ErrorSignal.FromCurrentContext().Raise(ke); //ELMAH Signaling
                }
                

                if (externalLinksList != null)
                {
                    model = new List<COLCWebsite.Models.InfoBoxes.InfoBoxesModels>();

                    foreach (var item in externalLinksList)
                    {
                        COLCWebsite.Models.InfoBoxes.InfoBoxesModels link = new COLCWebsite.Models.InfoBoxes.InfoBoxesModels();

                        link.Section = item.Section;
                        link.LinkURL = item.LinkURL;
                        link.LinkText = item.LinkText;
                        link.LinkDescription = item.LinkDescription;
                        link.SortOrder = item.SortOrder;

                        model.Add(link);
                    }
                }
            }

            return PartialView("~/Views/InfoBoxes/view.cshtml", model);
        }

    }
}
