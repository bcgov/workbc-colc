using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalTopIndustriesByJobOpeningsMap : EntityTypeConfiguration<RegionalTopIndustriesByJobOpenings>
    {
        public RegionalTopIndustriesByJobOpeningsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.NAICS_ID, t.JobOpenings, t.ForecastedAverageAnnualGrowth});

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAICS_ID)
                .IsRequired();

            this.Property(t => t.Title)
                .HasMaxLength(250);

            this.Property(t => t.JobOpenings)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ForecastedAverageAnnualGrowth)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("View_RegionalTopIndustriesByJobOpenings");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.NAICS_ID).HasColumnName("NAICS_ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.JobOpenings).HasColumnName("JobOpenings");
            this.Property(t => t.ForecastedAverageAnnualGrowth).HasColumnName("ForecastedAverageAnnualGrowth");            
        }
    }
}
