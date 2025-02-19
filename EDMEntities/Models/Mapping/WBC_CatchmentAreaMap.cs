using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class WBC_CatchmentAreaMap : EntityTypeConfiguration<WBC_CatchmentArea>
    {
        public WBC_CatchmentAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.CatchmentAreaID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.PDFLink)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("WBC_CatchmentArea");
            this.Property(t => t.CatchmentAreaID).HasColumnName("CatchmentAreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PDFLink).HasColumnName("PDFLink");
        }
    }
}
