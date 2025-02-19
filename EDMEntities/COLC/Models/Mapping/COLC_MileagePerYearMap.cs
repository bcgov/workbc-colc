using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_MileagePerYearMap : EntityTypeConfiguration<COLC_MileagePerYear>
    {
        public COLC_MileagePerYearMap()
        {
            // Primary Key
            this.HasKey(t => t.MileagePerYearID);

            // Properties
            this.Property(t => t.MileagePerYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COLC_MileagePerYear", Constants.SCHEMA_NAME);
            this.Property(t => t.MileagePerYearID).HasColumnName("MileagePerYearID");
            this.Property(t => t.Mileage).HasColumnName("Mileage");
        }
    }
}
