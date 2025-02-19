using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RelatedDocumentMap : EntityTypeConfiguration<RelatedDocument>
    {
        public RelatedDocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.DocumentID);

            // Properties
            this.Property(t => t.Caption)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.URL)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("EDM_RelatedDocument");
            this.Property(t => t.DocumentID).HasColumnName("DocumentID");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.URL).HasColumnName("URL");
        }
    }
}
