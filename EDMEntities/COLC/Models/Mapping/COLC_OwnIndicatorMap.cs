using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_OwnIndicatorMap : EntityTypeConfiguration<COLC_OwnIndicator>
    {
        public COLC_OwnIndicatorMap()
        {
            // Primary Key
            this.HasKey(t => t.OwnIndicatorID);

            // Properties
            this.Property(t => t.OwnIndicator)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("COLC_OwnIndicator", Constants.SCHEMA_NAME);
            this.Property(t => t.OwnIndicatorID).HasColumnName("OwnIndicatorID");
            this.Property(t => t.OwnIndicator).HasColumnName("OwnIndicator");
        }
    }
}
