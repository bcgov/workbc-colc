using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class WBC_ServicesCentreContractorMap : EntityTypeConfiguration<WBC_ServicesCentreContractor>
    {
        public WBC_ServicesCentreContractorMap()
        {
            // Primary Key
            this.HasKey(t => t.ServicesCentreContractorID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("WBC_ServicesCentreContractor");
            this.Property(t => t.ServicesCentreContractorID).HasColumnName("ServicesCentreContractorID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
