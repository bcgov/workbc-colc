using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Navigator.Models.Mapping
{
    public class SnapshotSectionMap : EntityTypeConfiguration<SnapshotSection>
    {
        public SnapshotSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.snap_sec_id);

            // Properties
            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SnapshotSection", Constants.SCHEMA_NAME);
            this.Property(t => t.snap_sec_id).HasColumnName("snap_sec_id");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
