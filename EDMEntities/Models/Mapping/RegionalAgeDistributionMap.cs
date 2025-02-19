using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalAgeDistributionMap : EntityTypeConfiguration<RegionalAgeDistribution>
    {
        public RegionalAgeDistributionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.AgeRange, t.ShareOfPopulation });

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AgeRange)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("View_RegionalAgeDistribution");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.AgeRange).HasColumnName("AgeRange");
            this.Property(t => t.ShareOfPopulation).HasColumnName("ShareOfPopulation");
        }
    }
}
