using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COLC.COLCWebsite.Models.Locations
{
   
    /// <summary>
    /// Model for the location dropdowns
    /// </summary>
    public class LocationsModels
    {
        public short LocationID { get; set; }
        public string LocationName { get; set; }
        public byte LocationTypeID { get; set; }
        public short? ParentLocationID { get; set; }    
    }  

}