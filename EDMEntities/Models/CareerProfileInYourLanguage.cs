using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    [Serializable]
    public partial class CareerProfileInYourLanguage
    {
        public int InYourLangID { get; set; }
        public int CareerProfileID { get; set; }
        public string LanguageCaption { get; set; }
        public string PDFName { get; set; }
        public string URL { get; set; }
        public virtual CareerProfile CareerProfile { get; set; }
    }
}
