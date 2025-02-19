using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_ArchetypeRelatedIndustryMap : EntityTypeConfiguration<FYF_ArchetypeRelatedIndustry>
    {
        public FYF_ArchetypeRelatedIndustryMap()
        {
            // Primary Key
            this.HasKey(t => t.ArchetypeRelatedIndustryId);

            // Properties
            // Table & Column Mappings
            this.ToTable("FYF_ArchetypeRelatedIndustry", "fyf");
            this.Property(t => t.ArchetypeRelatedIndustryId).HasColumnName("ArchetypeRelatedIndustryId");
            this.Property(t => t.ArchetypeId).HasColumnName("ArchetypeId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.NAICS_ID).HasColumnName("NAICS_ID");

            // Relationships
            this.HasRequired(t => t.NAICS)
                .WithMany(t => t.FYF_ArchetypeRelatedIndustry)
                .HasForeignKey(d => d.NAICS_ID);
            this.HasRequired(t => t.FYF_Archetype)
                .WithMany(t => t.FYF_ArchetypeRelatedIndustry)
                .HasForeignKey(d => d.ArchetypeId);
            this.HasRequired(t => t.FYF_RelatedIndustryGroup)
                .WithMany(t => t.FYF_ArchetypeRelatedIndustry)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
