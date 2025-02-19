using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class LocationTypeMap : EntityTypeConfiguration<LocationType>
    {
        public LocationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationTypeID);

            // Properties
            this.Property(t => t.LocationTypeName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("EDM_LocationType");
            this.Property(t => t.LocationTypeID).HasColumnName("LocationTypeID");
            this.Property(t => t.LocationTypeName).HasColumnName("LocationTypeName");
        }
    }
}
