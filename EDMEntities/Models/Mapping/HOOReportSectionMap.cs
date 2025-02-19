using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class HOOReportSectionMap : EntityTypeConfiguration<HOOReportSection>
    {
        public HOOReportSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.HOOReportSectionID);

            // Table & Column Mappings
            this.ToTable("vw_HOOReportSection");
            this.Property(t => t.HOOReportSectionID).HasColumnName("HOOReportSectionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DataReference).HasColumnName("DataReference");

        }
    }
}
