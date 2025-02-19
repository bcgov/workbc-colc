using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class NOCJobTitlesMap : EntityTypeConfiguration<NOCJobTitles>
    {
        public NOCJobTitlesMap()
        {
            // Primary Key
            this.HasKey(t => t.NOCJobTitleID);

            // Properties
            this.Property(t => t.EnglishTitle)
                .HasMaxLength(200);

            this.Property(t => t.FrenchTitle)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("EDM_NOCJobTitles");
            this.Property(t => t.NOCJobTitleID).HasColumnName("NOCJobTitleID");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.EnglishTitle).HasColumnName("EnglishTitle");
            this.Property(t => t.FrenchTitle).HasColumnName("FrenchTitle");

            // Relationships
            this.HasRequired(t => t.NOC)
                .WithMany(t => t.NOCJobTitles)
                .HasForeignKey(d => d.NOC_ID);

        }
    }
}
