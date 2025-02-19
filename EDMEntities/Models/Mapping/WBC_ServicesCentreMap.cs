using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class WBC_ServicesCentreMap : EntityTypeConfiguration<WBC_ServicesCentre>
    {
        public WBC_ServicesCentreMap()
        {
            // Primary Key
            this.HasKey(t => t.ServicesCentreID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Address2)
                .HasMaxLength(255);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.StoreFront)
                .HasMaxLength(255);

            this.Property(t => t.Phone)
                .HasMaxLength(20);

            this.Property(t => t.Fax)
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(255);

            this.Property(t => t.Website)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("WBC_ServicesCentre");
            this.Property(t => t.ServicesCentreID).HasColumnName("ServicesCentreID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Lat).HasColumnName("Lat");
            this.Property(t => t.Lon).HasColumnName("Lon");
            this.Property(t => t.StoreFront).HasColumnName("StoreFront");
            this.Property(t => t.EnglishService).HasColumnName("EnglishService");
            this.Property(t => t.FrenchService).HasColumnName("FrenchService");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.OpeningHours).HasColumnName("OpeningHours");
            this.Property(t => t.CatchmentAreaID).HasColumnName("CatchmentAreaID");
            this.Property(t => t.ServicesCentreContractorID).HasColumnName("ServicesCentreContractorID");

            // Relationships
            this.HasRequired(t => t.WBC_CatchmentArea)
                .WithMany(t => t.WBC_ServicesCentres)
                .HasForeignKey(d => d.CatchmentAreaID);
            this.HasRequired(t => t.WBC_Province)
                .WithMany(t => t.WBC_ServicesCentres)
                .HasForeignKey(d => d.ProvinceID);
            this.HasRequired(t => t.WBC_ServicesCentreContractor)
                .WithMany(t => t.WBC_ServicesCentres)
                .HasForeignKey(d => d.ServicesCentreContractorID);

        }
    }
}
