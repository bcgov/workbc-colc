using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class HOOLMIndicatorsMap : EntityTypeConfiguration<HOOLMIndicators>
    {
        public HOOLMIndicatorsMap()
        {

            // Table & Column Mappings
            this.ToTable("vw_HOOLMIndicators");
            this.Property(t => t.NOC).HasColumnName("NOC");
            this.Property(t => t.OccupationCategoryID).HasColumnName("OccupationCategoryID");
            this.Property(t => t.OccupationCategoryName).HasColumnName("OccupationCategoryName");
            this.Property(t => t.OccupationName).HasColumnName("OccupationName");
            this.Property(t => t.EmploymentSize).HasColumnName("EmploymentSize");
            this.Property(t => t.JobOpenings).HasColumnName("JobOpenings");
            this.Property(t => t.ProjectedUnemploymentRate).HasColumnName("ProjectedUnemploymentRate");
            this.Property(t => t.Education).HasColumnName("Education");

            // Relationships
            this.HasRequired(t => t.Report)
                .WithMany(t => t.LMIndicators)
                .HasForeignKey(d => d.HOOReportID);
        }
    }
}

