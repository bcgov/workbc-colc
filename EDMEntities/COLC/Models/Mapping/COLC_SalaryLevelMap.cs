using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_SalaryLevelMap : EntityTypeConfiguration<COLC_SalaryLevel>
    {
        public COLC_SalaryLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.SalaryLevelID);

            // Properties
            this.Property(t => t.SalaryLevelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COLC_SalaryLevel", Constants.SCHEMA_NAME);
            this.Property(t => t.SalaryLevelID).HasColumnName("SalaryLevelID");
            this.Property(t => t.Salary).HasColumnName("Salary");
        }
    }
}
