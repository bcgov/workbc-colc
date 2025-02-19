using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class IndustryProfileImpactViewMap : EntityTypeConfiguration<EDMEntities.Models.Custom.IndustryProfileImpactView>
    {
        public IndustryProfileImpactViewMap()
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
            this.ToTable("vw_IndustryProfileImpact");
            this.Property(t => t.ImpactID).HasColumnName("ImpactID");
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.Factor).HasColumnName("Factor");
            this.Property(t => t.EffectOnEmployment).HasColumnName("EffectOnEmployment");
            this.Property(t => t.Impact).HasColumnName("Impact");

            // Relationships
            this.HasRequired(t => t.IndustryProfile)
                .WithMany(t => t.IndustryProfileImpacts)
                .HasForeignKey(d => d.NAICS);

        }
    }
}
