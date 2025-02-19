using System;
using System.Collections.Generic;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class Notification
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public int NotoficationType { get; set; }
        public int ResourceID { get; set; }
        public int ToolID { get; set; }
        public DateTime SentOn { get; set; }
    }
}
