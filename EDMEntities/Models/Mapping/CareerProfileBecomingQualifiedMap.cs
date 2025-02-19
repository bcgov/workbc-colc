using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileBecomingQualifiedMap : EntityTypeConfiguration<CareerProfileBecomingQualified>
    {
        public CareerProfileBecomingQualifiedMap()
        {
            HasKey(t => t.BecomingQualifiedID);

            ToTable("EDM_CareerProfileBecomingQualified");


            Property(t => t.CareerLicensingID).HasColumnName("CareerLicensingID");
            Property(t => t.TotalApproximateFees).HasColumnName("TotalApproximateFees");
            Property(t => t.EstimatedTime).HasColumnName("EstimatedTime");
            Property(t => t.BecomingQualifiedHeader).HasColumnName("BecomingQualifiedHeader");
            Property(t => t.BecomingQualifiedContent).HasColumnName("BecomingQualifiedContent");
            Property(t => t.JobTitle).HasColumnName("JobTitle");

            HasRequired(t => t.CareerProfile)
                    .WithMany(t => t.CareerProfileBecomingQualified)
                    .HasForeignKey(d => d.CareerProfileID);

            HasRequired(t => t.CareerLicensing)
                .WithMany(t => t.CareerProfileBecomingQualified)
                .HasForeignKey(k => k.CareerLicensingID);
        }
    }
}
