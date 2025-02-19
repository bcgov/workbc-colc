using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class IndustryRegionalShareOfProvincialEmploymentViewMap : EntityTypeConfiguration<EDMEntities.Models.Custom.IndustryRegionalShareOfProvincialEmploymentView>
    {
        public IndustryRegionalShareOfProvincialEmploymentViewMap()
        {
            //// Primary Key
            this.HasKey(t => new { t.NAICS, t.LocationID });

            // Table & Column Mappings
            this.ToTable("vw_IndustryRegionalShareOfProvincialEmployment");
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.RegionShareOfIndustryEmploymentInProvince).HasColumnName("RegionShareOfIndustryEmploymentInProvince");

            //// Relationships
            //this.HasRequired(t => t.IndustryProfile)
            //    .WithMany(t => t.IndustryRegionalShareOfProvincialEmployments)
            //    .HasForeignKey(d => d.NAICS);

        }
        
    }
}
