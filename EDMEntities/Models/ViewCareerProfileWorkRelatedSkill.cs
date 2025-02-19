namespace EDMEntities.Models
{
    public class ViewCareerProfileWorkRelatedSkill
    {
        public int Id { get; set; }
        public string NOCCode { get; set; }
        public int NOC_ID { get; set; }
        public string IconUrl { get; set; }
        public string Skill { get; set; }
        public string SkillDefinition { get; set; }
        public double LevelOfImportancePercentage { get; set; }
        public string LevelOfImportanceDescription { get; set; }
        public int SkillStrength { get; set; }
    }
}
