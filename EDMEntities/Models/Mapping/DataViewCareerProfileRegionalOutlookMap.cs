using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DataViewCareerProfileRegionalOutlookMap : EntityTypeConfiguration<DataViewCareerProfileRegionalOutlook>
    {
        public DataViewCareerProfileRegionalOutlookMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_ID, t.NOCCode });

            // Properties
            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.LocationName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_DataViewCareerProfileRegionalOutlook");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.JobOpeningsOutlook).HasColumnName("JobOpeningsOutlook");
            this.Property(t => t.ExpectedAnnualDemandGrowthRate).HasColumnName("ExpectedAnnualDemandGrowthRate");
            this.Property(t => t.ForecastedEmployment).HasColumnName("ForecastedEmployment");
        }
    }
}
