using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class NAICSMap : EntityTypeConfiguration<NAICS>
    {
        public NAICSMap()
        {
            // Primary Key
            this.HasKey(t => t.NAICS_ID);

            // Properties
            this.Property(t => t.NAICS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sector)
                .HasMaxLength(250);

            this.Property(t => t.SectorType)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("EDM_NAICS");
            this.Property(t => t.NAICS_ID).HasColumnName("NAICS_ID");          
            this.Property(t => t.Sector).HasColumnName("Sector");
            this.Property(t => t.SectorType).HasColumnName("SectorType");
            this.Property(t => t.Enabled).HasColumnName("Enabled");
        }
    }
}
