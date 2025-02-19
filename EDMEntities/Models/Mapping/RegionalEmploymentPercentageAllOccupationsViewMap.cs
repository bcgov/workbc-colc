using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalEmploymentPercentageAllOccupationsViewMap : EntityTypeConfiguration<EDMEntities.Models.Custom.RegionalEmploymentPercentageAllOccupationsView>
    {
        public RegionalEmploymentPercentageAllOccupationsViewMap()
        {
            //// Primary Key
            this.HasKey(t => new { t.NAICS, t.LocationID });

            // Table & Column Mappings
            this.ToTable("View_RegionalEmploymentPercentageAllOccupations");
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.RegionShareOfIndustryEmploymentInProvince).HasColumnName("RegionShareOfIndustryEmploymentInProvince");
        }
    }
}
