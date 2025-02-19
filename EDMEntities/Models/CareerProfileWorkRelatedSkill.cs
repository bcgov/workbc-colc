namespace EDMEntities.Models
{
    public class CareerProfileWorkRelatedSkill
    {
        public int Id { get; set; }
        public string NOC { get; set; }
        public string SkillsCompetencies { get; set; }
        public double Importance { get; set; }
        public string ImportanceDescription { get; set; }
        public double Proficiency { get; set; }
        public string ProficiencyDescription { get; set; }
        public int SkillsDefId { get; set; }
    }
}
