using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class HOOReportMap : EntityTypeConfiguration<HOOReport>
    {
        public HOOReportMap()
        {
            // Primary Key
            this.HasKey(t => t.HOOReportID);

            // Table & Column Mappings
            this.ToTable("vw_HOOReport");
            this.Property(t => t.HOOReportID).HasColumnName("HOOReportID");
            this.Property(t => t.IsPublished).HasColumnName("IsPublished");
            this.Property(t => t.DatePublished).HasColumnName("DatePublished");

        }
    }
}
