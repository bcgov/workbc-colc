using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DemographicsReportContentMap : EntityTypeConfiguration<DemographicsReportContent>
    {
        public DemographicsReportContentMap()
        {
            // Primary Key
            this.HasKey(t => t.DemographicsReportContentID);

            // Table & Column Mappings
            this.ToTable("vw_DemographicsReportContent");
            this.Property(t => t.DemographicsReportContentID).HasColumnName("DemographicsReportContentID");
            this.Property(t => t.DemographicsReportID).HasColumnName("DemographicsReportID");
            this.Property(t => t.DemographicsReportSectionID).HasColumnName("DemographicsReportSectionID");
            this.Property(t => t.Intro).HasColumnName("Intro");
            this.Property(t => t.MainContent).HasColumnName("MainContent");

            // Relationships
            this.HasRequired(t => t.Section)
                .WithMany(t => t.Content)
                .HasForeignKey(d => d.DemographicsReportSectionID);

            this.HasRequired(t => t.Report)
                .WithMany(t => t.Content)
                .HasForeignKey(d => d.DemographicsReportID);


        }
    }
}
