using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DataViewCareerProfileJobOpeningsOutlookMap : EntityTypeConfiguration<DataViewCareerProfileJobOpeningsOutlook>
    {
        public DataViewCareerProfileJobOpeningsOutlookMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_ID, t.NOCCode });

            // Properties
            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

          
            // Table & Column Mappings
            this.ToTable("vw_DataViewCareerProfileJobOpeningsOutlook");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.DataYear).HasColumnName("DataYear");
            this.Property(t => t.JobOpenings).HasColumnName("JobOpenings");
        }
    }
}
