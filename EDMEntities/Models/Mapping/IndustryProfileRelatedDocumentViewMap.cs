using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class IndustryProfileRelatedDocumentViewMap : EntityTypeConfiguration<EDMEntities.Models.Custom.IndustryProfileRelatedDocumentView>
    {
        public IndustryProfileRelatedDocumentViewMap()
        {
            // Primary Key
            this.HasKey(t => t.IndustryProfileDocumentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("vw_IndustryProfileRelatedDocument");
            this.Property(t => t.IndustryProfileDocumentID).HasColumnName("IndustryProfileDocumentID");
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.DocumentID).HasColumnName("DocumentID");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.URL).HasColumnName("URL");

            // Relationships
            this.HasRequired(t => t.IndustryProfile)
                .WithMany(t => t.IndustryProfileRelatedDocuments)
                .HasForeignKey(d => d.NAICS);        
        }
    }
}
