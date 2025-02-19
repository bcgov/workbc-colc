using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RelatedSourceMap : EntityTypeConfiguration<RelatedSource>
    {
        public RelatedSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.SourceID);

            // Properties
            this.Property(t => t.Caption)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.URL)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("EDM_RelatedSource");
            this.Property(t => t.SourceID).HasColumnName("SourceID");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.URL).HasColumnName("URL");
        }
    }
}
