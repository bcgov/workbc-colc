using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalUnemploymentRatekMap : EntityTypeConfiguration<RegionalUnemploymentRate>
    {
        public RegionalUnemploymentRatekMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.Year, t.Rate });

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Rate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("View_RegionalUnemploymentRate");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Rate).HasColumnName("Rate");
        }
    }
}
