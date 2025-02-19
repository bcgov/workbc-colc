using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class NAICSCodesMap : EntityTypeConfiguration<NAICSCodes>
    {
        public NAICSCodesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NAICS_ID, t.NAICSCode });

            // Properties
            this.Property(t => t.NAICS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAICSCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("EDM_NAICSCodes");
            this.Property(t => t.NAICS_ID).HasColumnName("NAICS_ID");
            this.Property(t => t.NAICSCode).HasColumnName("NAICSCode");

            // Relationships
            this.HasRequired(t => t.NAICS)
                .WithMany(t => t.NAICSCodes)
                .HasForeignKey(d => d.NAICS_ID);

        }
    }
}
