using System;
using System.Collections.Generic;

namespace EDMEntities.Models.Custom
{
    public class CareerProfileMinorGroup
    {
        /// <summary>
        /// Entity representing a career group
        /// </summary>
        public CareerProfileMinorGroup()
        {
            this.CareerProfileUnitGroups = new List<CareerProfileUnitGroup>();
        }
        
        public string NOC4Digit { get; set; }
        public string Name { get; set; }
        public string NOC3Digit { get; set; }
        public virtual ICollection<CareerProfileUnitGroup> CareerProfileUnitGroups { get; set; }
    }
}
