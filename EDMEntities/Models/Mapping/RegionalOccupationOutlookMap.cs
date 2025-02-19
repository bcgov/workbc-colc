using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalOccupationOutlookMap : EntityTypeConfiguration<RegionalOccupationOutlook>
    {
        public RegionalOccupationOutlookMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.NOC_ID, t.NameEnglish, t.JobOpenings });

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NameEnglish)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.JobOpenings)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("View_RegionalOccupationOutlook");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NameEnglish).HasColumnName("NameEnglish");
            this.Property(t => t.JobOpenings).HasColumnName("JobOpenings");            
            this.Property(t => t.TopOccForecastedAverageAnnualEmploymentGrowth).HasColumnName("TopOccForecastedAverageAnnualEmploymentGrowth");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.TopLevelNocCode).HasColumnName("TopLevelNocCode");           
        }
    }
}
