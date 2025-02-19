using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace EDMEntities.Models.Mapping
{
    public class IndustryProfileCommonOccupationViewMap : EntityTypeConfiguration<EDMEntities.Models.Custom.IndustryProfileCommonOccupationView>
    {
        public IndustryProfileCommonOccupationViewMap()
        {
            // Primary Key
            this.HasKey(t => t.IndustryCommonOccupationID);

            // Table & Column Mappings
            this.ToTable("vw_IndustryProfileCommonOccupation");
            this.Property(t => t.IndustryCommonOccupationID).HasColumnName("IndustryCommonOccupationID");
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.NOC).HasColumnName("NOC");
            this.Property(t => t.Title).HasColumnName("Title");

            // Relationships
            this.HasRequired(t => t.IndustryProfile)
                .WithMany(t => t.IndustryProfileCommonOccupations)
                .HasForeignKey(d => d.NAICS);
        }
    }
}
