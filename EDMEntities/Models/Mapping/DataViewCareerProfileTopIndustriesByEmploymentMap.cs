using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DataViewCareerProfileTopIndustriesByEmploymentMap : EntityTypeConfiguration<DataViewCareerProfileTopIndustriesByEmployment>
    {
        public DataViewCareerProfileTopIndustriesByEmploymentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_ID, t.NOCCode });

            // Properties
            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Sector)
                .HasMaxLength(250);

            this.Property(t => t.SectorType)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("vw_DataViewCareerProfileTopIndustriesByEmployment");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.NAICS_ID).HasColumnName("NAICS_ID");
            this.Property(t => t.DataYear).HasColumnName("DataYear");
            this.Property(t => t.IndustryPercentEmploymentForNOC).HasColumnName("IndustryPercentEmploymentForNOC");
            this.Property(t => t.Sector).HasColumnName("Sector");
            this.Property(t => t.SectorType).HasColumnName("SectorType");
            this.Property(t => t.AnnotationNumber).HasColumnName("AnnotationNumber");
        }
    }
}
