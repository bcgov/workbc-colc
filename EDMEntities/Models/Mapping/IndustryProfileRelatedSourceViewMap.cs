using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class IndustryProfileRelatedSourceViewMap : EntityTypeConfiguration<EDMEntities.Models.Custom.IndustryProfileRelatedSourceView>
    {
        public IndustryProfileRelatedSourceViewMap()
        {
            // Primary Key
            this.HasKey(t => t.IndustryProfileRelatedSourceID);

            // Properties
            // Table & Column Mappings
            this.ToTable("vw_IndustryProfileRelatedSource");
            this.Property(t => t.IndustryProfileRelatedSourceID).HasColumnName("IndustryProfileRelatedSourceID");
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.SourceID).HasColumnName("SourceID");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.URL).HasColumnName("URL");

            // Relationships
            this.HasRequired(t => t.IndustryProfile)
                .WithMany(t => t.IndustryProfileRelatedSources)
                .HasForeignKey(d => d.NAICS);           

        }
    }
}
