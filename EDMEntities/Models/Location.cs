using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class Location
    {
        public Location()
        {
            this.ChildLocations = new List<Location>();
            this.DataViewCareerProfileRegionalEmployment = new List<DataViewCareerProfileRegionalEmployment>();
        }

        public short LocationID { get; set; }
        public string LocationName { get; set; }
        public Nullable<byte> ListOrder { get; set; }
        public Nullable<short> ParentLocationID { get; set; }
        public byte LocationTypeID { get; set; }
        public virtual ICollection<Location> ChildLocations { get; set; }
        public virtual Location ParentLocation { get; set; }
        public virtual LocationType LocationType { get; set; }
        public virtual RegionalProfile RegionalProfile { get; set; }
        public virtual ICollection<FYF_LifestyleQuestionResponseOptionLocationScore> FYF_LifestyleQuestionResponseOptionLocationScore { get; set; }
        public virtual ICollection<DataViewCareerProfileRegionalEmployment> DataViewCareerProfileRegionalEmployment { get; set; }
    }
}
