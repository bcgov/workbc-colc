using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class NOCGroupTypeMap : EntityTypeConfiguration<NOCGroupType>
    {
        public NOCGroupTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.NOCGroupTypeID);

            // Properties
            this.Property(t => t.NOCGroupTypeName)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("EDM_NOCGroupType");
            this.Property(t => t.NOCGroupTypeID).HasColumnName("NOCGroupTypeID");
            this.Property(t => t.NOCGroupTypeName).HasColumnName("NOCGroupTypeName");
        }
    }
}
