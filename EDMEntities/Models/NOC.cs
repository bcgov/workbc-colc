using EDMEntities.Models.Custom;
using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class NOC
    {
        public NOC()
        {
            this.CareerProfile = new List<CareerProfile>();
            this.CareerProfileDetailView = new List<CareerProfileDetailView>();
            this.ChildNOCs = new List<NOC>();
            this.NOCJobTitles = new List<NOCJobTitles>();
            this.IndustryProfile = new List<IndustryProfile>();
            this.DataPointCareers = new List<DataPointCareer>();
        }

        public int NOC_ID { get; set; }
        public string NOCCode { get; set; }
        public string NameEnglish { get; set; }
        public string NameFrench { get; set; }
        public string Alias { get; set; }
        public string NOCS2006 { get; set; }
        public Nullable<byte> NOCGroupTypeID { get; set; }
        public Nullable<int> ParentNOC_ID { get; set; }
        public Nullable<int> NOC_ID2006 { get; set; }
        public int NOCYear { get; set; }
        public string SkillLevelID { get; set; }
        public virtual NOCSkillLevelDemandOutlook SkillLevel { get; set; }
        public virtual ICollection<CareerProfile> CareerProfile { get; set; }
        public virtual ICollection<CareerProfileDetailView> CareerProfileDetailView { get; set; }
        public virtual ICollection<NOC> ChildNOCs { get; set; }
        public virtual NOC ParentNOC { get; set; }
        public virtual NOC NOC2006 { get; set; }
        public virtual ICollection<NOC> NOC2011 { get; set; }
        public virtual NOCGroupType NOCGroupType { get; set; }
        public virtual ICollection<NOCJobTitles> NOCJobTitles { get; set; }
        public virtual ICollection<IndustryProfile> IndustryProfile { get; set; }
        public virtual ICollection<DataPointCareer> DataPointCareers { get; set; }
    }
}
