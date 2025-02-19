using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileInYourLanguageMap : EntityTypeConfiguration<CareerProfileInYourLanguage>
    {
        public CareerProfileInYourLanguageMap()
        {
            // Primary Key
            this.HasKey(t => t.InYourLangID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EDM_CareerProfileInYourLanguage");
            this.Property(t => t.CareerProfileID).HasColumnName("CareerProfileID");
            this.Property(t => t.LanguageCaption).HasColumnName("LanguageCaption");
            this.Property(t => t.PDFName).HasColumnName("PDFName");
            this.Property(t => t.URL).HasColumnName("URL");

            // Relationships
            this.HasRequired(t => t.CareerProfile)
                .WithMany(t => t.CareerProfileInYourLanguages)
                .HasForeignKey(d => d.CareerProfileID);
        }
    }
}
