using System;
using System.Collections.Generic;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class EmailTemplate
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
