using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerLicensingMap : EntityTypeConfiguration<CareerLicensing>
    {
        public CareerLicensingMap()
        {
            // Primary Key
            this.HasKey(t => t.CareerLicensingID);

            // Properties
            this.Property(t => t.CareerLicensingName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("EDM_CareerLicensing");
            this.Property(t => t.CareerLicensingID).HasColumnName("CareerLicensingID");
            this.Property(t => t.CareerLicensingName).HasColumnName("CareerLicensingName");
        }
    }
}
