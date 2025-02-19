using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationID);

            // Properties
            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EDM_Location");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.ListOrder).HasColumnName("ListOrder");
            this.Property(t => t.ParentLocationID).HasColumnName("ParentLocationID");
            this.Property(t => t.LocationTypeID).HasColumnName("LocationTypeID");

            // Relationships
            this.HasOptional(t => t.ParentLocation)
                .WithMany(t => t.ChildLocations)
                .HasForeignKey(d => d.ParentLocationID);
            this.HasRequired(t => t.LocationType)
                .WithMany(t => t.Location)
                .HasForeignKey(d => d.LocationTypeID);

            this.HasOptional(t => t.RegionalProfile)
                .WithRequired(t => t.Location)
                .Map(m => m.ToTable("EDM_RegionalProfile").MapKey("LocationID"));
        }
    }
}
