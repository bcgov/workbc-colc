using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    
    public class ViewMinorGroupMap : EntityTypeConfiguration<ViewMinorGroup>
    {
        public ViewMinorGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_CODE, t.ParentNOC_Code });

            // Properties
            this.Property(t => t.NOC_CODE)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.NOC_TITLE)
                .HasMaxLength(200);

            this.Property(t => t.EnglishTitle)
                .HasMaxLength(200);

            this.Property(t => t.ParentNOC_Code)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ParentNOC_Title)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("View_MinorGroup");
            this.Property(t => t.NOC_CODE).HasColumnName("NOC_CODE");
            this.Property(t => t.NOC_TITLE).HasColumnName("NOC_TITLE");
            this.Property(t => t.EnglishTitle).HasColumnName("EnglishTitle");
            this.Property(t => t.ParentNOC_Code).HasColumnName("ParentNOC_Code");
            this.Property(t => t.ParentNOC_Title).HasColumnName("ParentNOC_Title");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
        }
    }
}
