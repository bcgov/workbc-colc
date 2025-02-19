using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_QuizQuestionMap : EntityTypeConfiguration<FYF_QuizQuestion>
    {
        public FYF_QuizQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.QuizQuestionId);

            // Properties
            this.Property(t => t.OptionX)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.OptionY)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FYF_QuizQuestion", "fyf");
            this.Property(t => t.QuizQuestionId).HasColumnName("QuizQuestionId");
            this.Property(t => t.ArchetypeId).HasColumnName("ArchetypeId");
            this.Property(t => t.OptionX).HasColumnName("OptionX");
            this.Property(t => t.OptionY).HasColumnName("OptionY");

            // Relationships
            this.HasRequired(t => t.FYF_Archetype)
                .WithMany(t => t.FYF_QuizQuestion)
                .HasForeignKey(d => d.ArchetypeId);

        }
    }
}
