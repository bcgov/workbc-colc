using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class CareerProfileSkill
    {
        public int CareerProfileSkillID { get; set; }
        public int CareerProfileID { get; set; }
        public short CareerSkillID { get; set; }
        public byte SortOrder { get; set; }
        public virtual CareerProfile CareerProfile { get; set; }
        public virtual CareerSkill CareerSkill { get; set; }
    }
}
