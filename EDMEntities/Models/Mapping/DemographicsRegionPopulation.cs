using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DemographicsRegionPopulationMap : EntityTypeConfiguration<DemographicsRegionPopulation>
    {
        public DemographicsRegionPopulationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionID, t.Year });
            
            // Table & Column Mappings
            this.ToTable("vw_DemographicsRegionPopulation");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PopulationPercent).HasColumnName("PopulationPercent");
            this.Property(t => t.Population).HasColumnName("Population");
            this.Property(t => t.TotalEmployment).HasColumnName("TotalEmployment");
            this.Property(t => t.UnemploymentRate).HasColumnName("UnemploymentRate");


        }
    }
}
