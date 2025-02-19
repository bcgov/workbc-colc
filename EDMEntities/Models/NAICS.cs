using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class NAICS
    {
        public NAICS()
        {
            this.IndustryProfile = new List<IndustryProfile>();
            this.NAICSCodes = new List<NAICSCodes>();
            this.FYF_QuizSubject = new List<FYF_QuizSubject>();
        }

        public int NAICS_ID { get; set; }
        public string Sector { get; set; }
        public string SectorType { get; set; }
        public bool Enabled { get; set; }
        public virtual ICollection<IndustryProfile> IndustryProfile { get; set; }
        public virtual ICollection<NAICSCodes> NAICSCodes { get; set; }
        public virtual ICollection<FYF_QuizSubject> FYF_QuizSubject { get; set; }
        public virtual ICollection<FYF_ArchetypeRelatedIndustry> FYF_ArchetypeRelatedIndustry { get; set; }
    }
}
