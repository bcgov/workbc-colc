using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DemographicsReportMap : EntityTypeConfiguration<DemographicsReport>
    {
        public DemographicsReportMap()
        {
            // Primary Key
            this.HasKey(t => t.DemographicsReportID);

            // Table & Column Mappings
            this.ToTable("vw_DemographicsReport");
            this.Property(t => t.DemographicsReportID).HasColumnName("DemographicsReportID");
            this.Property(t => t.IsPublished).HasColumnName("IsPublished");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.PDFLink).HasColumnName("PDFLink");

        }
    }
}
