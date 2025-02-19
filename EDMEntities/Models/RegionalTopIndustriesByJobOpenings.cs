namespace EDMEntities.Models
{
    public partial class RegionalTopIndustriesByJobOpenings
    {
        public int RegionalProfileId { get; set; }
        public int NAICS_ID { get; set; }
        public string Title { get; set; }
        public double JobOpenings { get; set; }
        public double ForecastedAverageAnnualGrowth { get; set; }       
    }
}
