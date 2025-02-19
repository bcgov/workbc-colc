using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DataPointLocationMap : EntityTypeConfiguration<DataPointLocation>
    {
        public DataPointLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.DataPointLocationID);

            // Properties
            this.Property(t => t.CitationOverride)
                .HasMaxLength(500);

            this.Property(t => t.AuditTrail)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("EDM_DataPointLocation");
            this.Property(t => t.DataPointLocationID).HasColumnName("DataPointLocationID");
            this.Property(t => t.DataSourceID).HasColumnName("DataSourceID");
            this.Property(t => t.VariableID).HasColumnName("VariableID");
            this.Property(t => t.DataYear).HasColumnName("DataYear");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.CitationOverride).HasColumnName("CitationOverride");
            this.Property(t => t.AuditTrail).HasColumnName("AuditTrail");
        }
    }
}
