using System;
using System.Collections.Generic;

namespace EDMEntities.BlueprintBuilder.Models
{
    public class Blueprint
    {
        public Blueprint()
        {
            Tools = new List<Tool>();
            Resources = new List<Resource>();
        }

        public Guid ID { get; set; }
        public DateTime LastSaved { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
