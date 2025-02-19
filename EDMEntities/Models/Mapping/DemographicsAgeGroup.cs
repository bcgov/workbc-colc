using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DemographicsAgeGroupMap : EntityTypeConfiguration<DemographicsAgeGroup>
    {
        public DemographicsAgeGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Table & Column Mappings
            this.ToTable("vw_DemographicsAgeGroup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");

        }
    }
}
