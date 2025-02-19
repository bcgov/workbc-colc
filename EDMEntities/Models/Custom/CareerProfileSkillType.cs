using System;
using System.Collections.Generic;

namespace EDMEntities.Models.Custom
{
    /// <summary>
    /// Entity representing an occupation category by 1-digit NOC
    /// </summary>
    public class CareerProfileSkillType
    {
        public string NOC1Digit { get; set; }
        public string Name { get; set; }
    }
}
