using EDMEntities.Models.Custom;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DemographicsProjectedParticipationMap : EntityTypeConfiguration<DemographicsProjectedParticipation>
    {
        public DemographicsProjectedParticipationMap()
        {
            // Primary Key
            this.HasKey(t => t.Year);

            // Table & Column Mappings
            this.ToTable("vw_DemographicsProjectedParticipation");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.MaleParticipation).HasColumnName("MaleParticipation");
            this.Property(t => t.FemaleParticipation).HasColumnName("FemaleParticipation");
            this.Property(t => t.TotalParticipation).HasColumnName("TotalParticipation");

        }
    }
}
