using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_LocationMap : EntityTypeConfiguration<COLC_Location>
    {
        public COLC_LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationID);

            // Properties
            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("COLC_Location", Constants.SCHEMA_NAME);
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.ParentLocationID).HasColumnName("ParentLocationID");
            this.Property(t => t.LocationTypeID).HasColumnName("LocationTypeID");

            // Relationships
            this.HasRequired(t => t.COLC_LocationType)
                .WithMany(t => t.COLC_Location)
                .HasForeignKey(d => d.LocationTypeID);

        }
    }
}
