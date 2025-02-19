using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace EDMEntities.Models.Mapping
{
    public class IndustrySnapshotLatestViewMap : EntityTypeConfiguration<EDMEntities.Models.Custom.IndustrySnapshotLatestView>
    {
        public IndustrySnapshotLatestViewMap()
        {
            // Primary Key
            this.HasKey(t => t.SnapID);

            // Table & Column Mappings
            this.ToTable("vw_IndustrySnapshotLatest");
            this.Property(t => t.SnapID).HasColumnName("SnapID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.MonthName).HasColumnName("MonthName");
            this.Property(t => t.EmploymentRate).HasColumnName("EmploymentRate");
            this.Property(t => t.NumberOfJobs).HasColumnName("NumberOfJobs");
        }
    }
}
