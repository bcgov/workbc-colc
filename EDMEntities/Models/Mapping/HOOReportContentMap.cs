using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class HOOReportContentMap : EntityTypeConfiguration<HOOReportContent>
    {
        public HOOReportContentMap()
        {
            // Primary Key
            this.HasKey(t => t.HOOReportContentID);

            // Table & Column Mappings
            this.ToTable("vw_HOOReportContent");
            this.Property(t => t.HOOReportContentID).HasColumnName("HOOReportContentID");
            this.Property(t => t.HOOReportID).HasColumnName("HOOReportID");
            this.Property(t => t.HOOReportSectionID).HasColumnName("HOOReportSectionID");
            this.Property(t => t.Intro).HasColumnName("Intro");
            this.Property(t => t.MainContent).HasColumnName("MainContent");

            // Relationships
            this.HasRequired(t => t.Section)
                .WithMany(t => t.Content)
                .HasForeignKey(d => d.HOOReportSectionID);

            this.HasRequired(t => t.Report)
                .WithMany(t => t.Content)
                .HasForeignKey(d => d.HOOReportID);


        }
    }
}
