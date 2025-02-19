using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class WBC_ProvinceMap : EntityTypeConfiguration<WBC_Province>
    {
        public WBC_ProvinceMap()
        {
            // Primary Key
            this.HasKey(t => t.ProvinceID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.ShortName)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("WBC_Province");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
        }
    }
}
