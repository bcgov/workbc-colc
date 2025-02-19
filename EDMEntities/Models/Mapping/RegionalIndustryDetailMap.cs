using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalIndustryDetailMap : EntityTypeConfiguration<RegionalIndustryDetail>
    {
        public RegionalIndustryDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.IndustryId });

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IndustryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IndustryName)
                .HasMaxLength(250);

            this.Property(t => t.Sector)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("View_RegionalIndustryDetail");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.IndustryId).HasColumnName("IndustryId");
            this.Property(t => t.IndustryName).HasColumnName("IndustryName");
            this.Property(t => t.Sector).HasColumnName("Sector");
            this.Property(t => t.ShareOfJobs).HasColumnName("ShareOfJobs");
            this.Property(t => t.ShareOfEmployment).HasColumnName("ShareOfEmployment");
            this.Property(t => t.IsKeyIndustry).HasColumnName("IsKeyIndustry");
            this.Property(t => t.AnnotationNumber).HasColumnName("AnnotationNumber");
        }
    }
}
