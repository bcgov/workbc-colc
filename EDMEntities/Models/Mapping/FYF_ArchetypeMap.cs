using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_ArchetypeMap : EntityTypeConfiguration<FYF_Archetype>
    {
        public FYF_ArchetypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ArchetypeId);

            // Properties
            this.Property(t => t.ArchetypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Motivation)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Outcome)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("FYF_Archetype", "fyf");
            this.Property(t => t.ArchetypeId).HasColumnName("ArchetypeId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Motivation).HasColumnName("Motivation");
            this.Property(t => t.Outcome).HasColumnName("Outcome");
        }
    }
}
