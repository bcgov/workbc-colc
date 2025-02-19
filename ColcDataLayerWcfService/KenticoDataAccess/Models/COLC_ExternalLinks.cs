using System;
using System.Collections.Generic;

namespace ColcDataLayerWcfService.KenticoDataAccess.Models
{
    public class COLC_ExternalLinks
    {
        public int ItemID { get; set; }
        public string Skin { get; set; }
        public string Section { get; set; }
        public string LinkText { get; set; }
        public string LinkURL { get; set; }
        public string LinkDescription { get; set; }
        public int SortOrder { get; set; }        
    }
}