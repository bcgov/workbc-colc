using ColcBusinessLayerWcfService.Models.ExternalLinks;
using ColcDataLayerWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcBusinessLayerWcfService.Controllers
{
    public class ExternalLinksController
    {
        /// <summary>
        /// Gets external links from the database layer.
        /// </summary>
        /// <param name="skin">visual style for a particular site (e.g. welcomebc)</param>
        /// <returns>List of external links for the skin</returns>
        public IEnumerable<ExternalLinksModels> GetExternalLinks(string skin)
        {
            using (var colcDataLayerService = new ColcDataLayerService())
            {
                IEnumerable<ColcDataLayerWcfService.Models.ExternalLinks.ExternalLinksModels> listExternalLinks = null;

                try
                {
                    listExternalLinks = colcDataLayerService.GetExternalLinks(skin);
                }
                catch (ColcDataLayerWcfService.CustomExceptions.KenticoCMSDatabaseException ke)
                {
                    throw new ColcBusinessLayerWcfService.CustomExceptions.KenticoCMSDatabaseException("Kentico CMS database error.", ke.InnerException);
                }                
                
                List<Models.ExternalLinks.ExternalLinksModels> list = null; 

                if (listExternalLinks != null)
                {
                    list = new List<Models.ExternalLinks.ExternalLinksModels>();

                    foreach (var item in listExternalLinks)
                    {
                        Models.ExternalLinks.ExternalLinksModels link = new Models.ExternalLinks.ExternalLinksModels();

                        link.Section = item.Section;
                        link.LinkURL = item.LinkURL;
                        link.LinkText = item.LinkText;
                        link.LinkDescription = item.LinkDescription;
                        link.SortOrder = item.SortOrder;

                        list.Add(link);
                    }
                }

                return list;
            }
            
        }
       

    }
}