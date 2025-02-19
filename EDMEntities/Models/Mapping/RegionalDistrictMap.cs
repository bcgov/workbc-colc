using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalDistrictMap : EntityTypeConfiguration<RegionalDistrict>
    {
        public RegionalDistrictMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LocationID, t.LocationTypeID, t.RegionalProfileId, t.DistrictName, t.KeyCities });

            // Properties
            this.Property(t => t.LocationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DistrictName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KeyCities)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("View_RegionalDistricts");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationTypeID).HasColumnName("LocationTypeID");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileID");
            this.Property(t => t.DistrictName).HasColumnName("DistrictName");
            this.Property(t => t.KeyCities).HasColumnName("KeyCities");
            this.Property(t => t.Population).HasColumnName("Population");
            this.Property(t => t.ShareOfPopulationUrban).HasColumnName("ShareOfPopulationUrban");
            this.Property(t => t.ShareOfPopulationRural).HasColumnName("ShareOfPopulationRural");
        }
    }
}
