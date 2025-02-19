using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_ClassMap : EntityTypeConfiguration<FYF_Class>
    {
        public FYF_ClassMap()
        {
            // Primary Key
            this.HasKey(t => t.ClassId);

            // Properties
            this.Property(t => t.ClassId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FYF_Class", "fyf");
            this.Property(t => t.ClassId).HasColumnName("ClassId");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            // Relationships
            this.HasRequired(t => t.FYF_Subject)
                .WithMany(t => t.FYF_Class)
                .HasForeignKey(d => d.SubjectId);

        }
    }
}
