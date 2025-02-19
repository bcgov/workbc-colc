using System.Collections.Generic;

namespace EDMEntities.Models
{
    /// <summary>
    /// This class describes a Skill Level that can be assigned to a Career Profile.
    /// It should not be confused with CareerProfileSkill which is a one to many relationship of skills associated with a Career Profile.
    /// </summary>
    public partial class NOCSkillLevelDemandOutlook
    {
        public NOCSkillLevelDemandOutlook()
        {
            this.NOC = new List<NOC>();
        }

        public string SkillTypeCode { get; set; }
        public string OccupationType { get; set; }
        public string Education { get; set; }
        public double? PercentageOpenings { get; set; }
        public string EducationLongDesc { get; set; }
        public int SortOrder { get; set;}

        public virtual ICollection<NOC> NOC { get; set; }

    }
}
