using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DemographicsProjectedPopulationMap : EntityTypeConfiguration<DemographicsProjectedPopulation>
    {
        public DemographicsProjectedPopulationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Year, t.AgeGroupID });

            // Table & Column Mappings
            this.ToTable("vw_DemographicsProjectedPopulation");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.AgeGroupID).HasColumnName("AgeGroupID");
            this.Property(t => t.MalePopPercent).HasColumnName("MalePopPercent");
            this.Property(t => t.FemalePopPercent).HasColumnName("FemalePopPercent");
            this.Property(t => t.TotalPop).HasColumnName("TotalPop");

            // Relationships
            this.HasRequired(t => t.AgeGroup)
                .WithMany(t => t.ProjectedPopulationData)
                .HasForeignKey(d => d.AgeGroupID);
        }
    }
}
