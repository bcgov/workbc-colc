using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_LocationTypeMap : EntityTypeConfiguration<COLC_LocationType>
    {
        public COLC_LocationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationTypeID);

            // Properties
            this.Property(t => t.LocationTypeName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("COLC_LocationType", Constants.SCHEMA_NAME);
            this.Property(t => t.LocationTypeID).HasColumnName("LocationTypeID");
            this.Property(t => t.LocationTypeName).HasColumnName("LocationTypeName");
        }
    }
}
