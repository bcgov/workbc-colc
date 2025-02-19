using System;
using System.Collections.Generic;

namespace EDMEntities.Models.Custom
{
    public partial class IndustryProfileRelatedDocumentView
    {
        public int IndustryProfileDocumentID { get; set; }
        public int NAICS { get; set; }
        public int DocumentID { get; set; }
        public string Caption { get; set; }
        public string URL { get; set; }
        public virtual IndustryProfileView IndustryProfile { get; set; }
    }
}
