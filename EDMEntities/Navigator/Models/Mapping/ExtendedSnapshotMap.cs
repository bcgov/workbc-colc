using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Navigator.Models.Mapping
{
    public class ExtendedSnapshotMap : EntityTypeConfiguration<ExtendedSnapshot>
    {
        public ExtendedSnapshotMap()
        {
            // Primary Key
            this.HasKey(t => t.snap_id);

            // Properties
            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("vw_ExtendedSnapshot", Constants.SCHEMA_NAME);
            this.Property(t => t.snap_id).HasColumnName("snap_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.month_over_month_change).HasColumnName("month_over_month_change");
            this.Property(t => t.jobs).HasColumnName("jobs");
            this.Property(t => t.month_id).HasColumnName("month_id");
            this.Property(t => t.snap_sec_id).HasColumnName("snap_sec_id");

            // new columns
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.region_id).HasColumnName("region_id");
            this.Property(t => t.current_value).HasColumnName("current_value");
            this.Property(t => t.previous_value).HasColumnName("previous_value");
            this.Property(t => t.order_id).HasColumnName("order_id");


            // Relationships
            this.HasRequired(t => t.Month)
                .WithMany(t => t.Snapshots)
                .HasForeignKey(d => d.month_id);
            this.HasOptional(t => t.SnapshotSection)
                .WithMany(t => t.Snapshots)
                .HasForeignKey(d => d.snap_sec_id);

        }
    }
}
