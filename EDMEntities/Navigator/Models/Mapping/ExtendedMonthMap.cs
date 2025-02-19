using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Navigator.Models.Mapping
{
    public class ExtendedMonthMap : EntityTypeConfiguration<ExtendedMonth>
    {
        public ExtendedMonthMap()
        {
            // Primary Key
            this.HasKey(t => t.month_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_ExtendedMonth", Constants.SCHEMA_NAME);
            this.Property(t => t.month_id).HasColumnName("month_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.is_published).HasColumnName("is_published");
        }
    }
}
