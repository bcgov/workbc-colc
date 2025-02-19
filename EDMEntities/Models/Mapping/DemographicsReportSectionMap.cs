using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DemographicsReportSectionMap : EntityTypeConfiguration<DemographicsReportSection>
    {
        public DemographicsReportSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.DemographicsReportSectionID);

            // Table & Column Mappings
            this.ToTable("vw_DemographicsReportSection");
            this.Property(t => t.DemographicsReportSectionID).HasColumnName("DemographicsReportSectionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DataReference).HasColumnName("DataReference");
            this.Property(t => t.LinkText).HasColumnName("LinkText");

        }
    }
}
