using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EDMEntities.COLC.Models;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_OccupationMap : EntityTypeConfiguration<COLC_Occupation>
    {
        public COLC_OccupationMap()
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
            this.ToTable("vw_Occupation", Constants.SCHEMA_NAME);
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.NameEnglish).HasColumnName("NameEnglish");
            this.Property(t => t.AvgSalary).HasColumnName("AvgSalary");
            this.Property(t => t.AlternativeJobTitles).HasColumnName("AlternativeJobTitles");
        }
    }
}
