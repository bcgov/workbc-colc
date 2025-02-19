using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EDMEntities.Models.Custom;

namespace EDMEntities.Models.Mapping
{
    public class DataViewTopOccupationMap : EntityTypeConfiguration<DataViewTopOccupation>
    {
        public DataViewTopOccupationMap()
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
            this.ToTable("vw_TopOccupation");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.NameEnglish).HasColumnName("NameEnglish");
            this.Property(t => t.SalaryRange).HasColumnName("SalaryRange");
            this.Property(t => t.SkillLevel).HasColumnName("SkillLevel");
            this.Property(t => t.TopOccupationSkillLevelRank).HasColumnName("TopOccupationSkillLevelRank");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.SkillLevelSortOrder).HasColumnName("SkillLevelSortOrder");
            this.Property(t => t.WageMedian).HasColumnName("WageMedian");
            this.Property(t => t.JobOpenings).HasColumnName("JobOpenings");
            this.Property(t => t.WageIsAnnual).HasColumnName("WageIsAnnual");
            this.Property(t => t.OccupationalInterest).HasColumnName("OccupationalInterest");
            this.Property(t => t.OccupationalInterestAlphabetical).HasColumnName("OccupationalInterestAlphabetical");
        }
    }
}
