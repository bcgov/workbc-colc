using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class NOCGroupType
    {
        public NOCGroupType()
        {
            this.NOC = new List<NOC>();
        }

        public byte NOCGroupTypeID { get; set; }
        public string NOCGroupTypeName { get; set; }
        public virtual ICollection<NOC> NOC { get; set; }
    }
}
