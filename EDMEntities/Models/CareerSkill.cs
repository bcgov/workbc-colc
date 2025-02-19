using System;
using System.Collections.Generic;

namespace EDMEntities.Models
{
    public partial class CareerSkill
    {
        public CareerSkill()
        {
            this.CareerProfileSkill = new List<CareerProfileSkill>();
        }

        public short CareerSkillID { get; set; }
        public string CareerSkillName { get; set; }
        public virtual ICollection<CareerProfileSkill> CareerProfileSkill { get; set; }
    }
}
