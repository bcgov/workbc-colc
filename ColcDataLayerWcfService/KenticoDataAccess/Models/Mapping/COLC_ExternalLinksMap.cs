using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ColcDataLayerWcfService.KenticoDataAccess.Models.Mapping
{
    public class COLC_ExternalLinksMap : EntityTypeConfiguration<COLC_ExternalLinks>
    {
        public COLC_ExternalLinksMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemID);

            // Properties
            this.Property(t => t.LinkText)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.LinkURL)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.LinkDescription)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.SortOrder)
                .IsRequired();
               

            // Table & Column Mappings
            this.ToTable("COLC_ExternalLinks");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Skin).HasColumnName("Skin");
            this.Property(t => t.Section).HasColumnName("Section");
            this.Property(t => t.LinkText).HasColumnName("LinkText");
            this.Property(t => t.LinkURL).HasColumnName("LinkURL");
            this.Property(t => t.LinkDescription).HasColumnName("LinkDescription");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");            
        }

    }
}