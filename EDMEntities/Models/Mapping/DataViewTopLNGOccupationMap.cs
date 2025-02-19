using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EDMEntities.Models.Custom;

namespace EDMEntities.Models.Mapping
{
    public class DataViewTopLNGOccupationMap : EntityTypeConfiguration<DataViewTopLNGOccupation>
    {
        public DataViewTopLNGOccupationMap()
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
            this.ToTable("vw_TopLNGOccupation");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.AvgSalaryDataYear).HasColumnName("AvgSalaryDataYear");
            this.Property(t => t.AvgSalary).HasColumnName("AvgSalary");
            this.Property(t => t.NameEnglish).HasColumnName("NameEnglish");
            this.Property(t => t.CareerProfileDescription).HasColumnName("CareerProfileDescription");
            this.Property(t => t.SalaryRange).HasColumnName("SalaryRange");
            this.Property(t => t.SkillLevel).HasColumnName("SkillLevel");
        }
    }
}
