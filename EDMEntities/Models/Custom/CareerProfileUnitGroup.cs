using System;
using System.Collections.Generic;


namespace EDMEntities.Models.Custom
{
    /// <summary>
    /// Entity representing a career by 4-digit NOC
    /// </summary>
    public class CareerProfileUnitGroup
    {
        public string NOC4Digit { get; set; }
        public string Title { get; set; }
        public int SiteID { get; set; }
        public virtual CareerProfileMinorGroup CareerProfileMinorGroup { get; set; }
    }
}
