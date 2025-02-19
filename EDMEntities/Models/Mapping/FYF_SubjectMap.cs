using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_SubjectMap : EntityTypeConfiguration<FYF_Subject>
    {
        public FYF_SubjectMap()
        {
            // Primary Key
            this.HasKey(t => t.SubjectId);

            // Properties
            this.Property(t => t.SubjectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FYF_Subject", "fyf");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
        }
    }
}
