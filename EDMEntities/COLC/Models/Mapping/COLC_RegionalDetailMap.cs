using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EDMEntities.COLC.Models;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_RegionalDetailMap : EntityTypeConfiguration<COLC_RegionalDetail>
    {
        public COLC_RegionalDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LocationID});

            // Table & Column Mappings
            this.ToTable("vw_RegionalDetails", Constants.SCHEMA_NAME);
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.KeyCities).HasColumnName("KeyCities");
            this.Property(t => t.ForecastedAnnualEmploymentGrowth).HasColumnName("ForecastedAnnualEmploymentGrowth");
            this.Property(t => t.DataYearStart).HasColumnName("DataYearStart");
            this.Property(t => t.DataYearMidpoint).HasColumnName("DataYearMidpoint");
            this.Property(t => t.DataYearEnd).HasColumnName("DataYearEnd");
            this.Property(t => t.EmploymentGrowthStartOfOutlook).HasColumnName("EmploymentGrowthStartOfOutlook");
            this.Property(t => t.EmploymentGrowthMidpointOfOutlook).HasColumnName("EmploymentGrowthMidpointOfOutlook");
            this.Property(t => t.EmploymentGrowthEndOfOutlook).HasColumnName("EmploymentGrowthEndOfOutlook");
            this.Property(t => t.TotalEmploymentIncrease).HasColumnName("TotalEmploymentIncrease");
            this.Property(t => t.TopNOCCode1).HasColumnName("TopNOCCode1");
            this.Property(t => t.TopOccupation1).HasColumnName("TopOccupation1");
            this.Property(t => t.TopNOCCode2).HasColumnName("TopNOCCode2");
            this.Property(t => t.TopOccupation2).HasColumnName("TopOccupation2");
            this.Property(t => t.TopNOCCode3).HasColumnName("TopNOCCode3");
            this.Property(t => t.TopOccupation3).HasColumnName("TopOccupation3");
        }
    }
}
