using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DemographicsLanguageMap : EntityTypeConfiguration<DemographicsLanguage>
    {
        public DemographicsLanguageMap()
        {
            // Primary Key
            this.HasKey(t => new {t.Year, t.Name });

            // Table & Column Mappings
            this.ToTable("vw_DemographicsLanguage");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.NumSpeakers).HasColumnName("NumSpeakers");
            this.Property(t => t.Percentage).HasColumnName("Percentage");

        }
    }
}
