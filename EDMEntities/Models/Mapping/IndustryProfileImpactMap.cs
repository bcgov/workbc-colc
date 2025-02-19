using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class IndustryProfileImpactMap : EntityTypeConfiguration<IndustryProfileImpact>
    {
        public IndustryProfileImpactMap()
        {
            // Primary Key
            this.HasKey(t => t.ImpactID);

            // Properties
            this.Property(t => t.Factor)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.EffectOnEmployment)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Impact)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("EDM_IndustryProfileImpact");
            this.Property(t => t.ImpactID).HasColumnName("ImpactID");
            this.Property(t => t.IndustryProfileID).HasColumnName("IndustryProfileID");
            this.Property(t => t.Factor).HasColumnName("Factor");
            this.Property(t => t.EffectOnEmployment).HasColumnName("EffectOnEmployment");
            this.Property(t => t.Impact).HasColumnName("Impact");

            // Relationships
            this.HasRequired(t => t.IndustryProfile)
                .WithMany(t => t.IndustryProfileImpact)
                .HasForeignKey(d => d.IndustryProfileID);

        }
    }
}
