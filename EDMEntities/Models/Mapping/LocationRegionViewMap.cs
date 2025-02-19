using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class LocationRegionViewMap : EntityTypeConfiguration<LocationRegionView>
    {
        public LocationRegionViewMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Properties
            this.Property(t => t.RegionName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("View_LocationRegionView");
            this.Property(t => t.RegionID).HasColumnName("LocationID");
            this.Property(t => t.RegionName).HasColumnName("LocationName");
            this.Property(t => t.ListOrder).HasColumnName("ListOrder");
        }
    }
}
