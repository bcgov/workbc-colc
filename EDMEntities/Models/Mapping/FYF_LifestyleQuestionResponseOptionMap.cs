using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LifestyleQuestionResponseOptionMap : EntityTypeConfiguration<FYF_LifestyleQuestionResponseOption>
    {
        public FYF_LifestyleQuestionResponseOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.LifestyleQuestionResponseOptionId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FYF_LifestyleQuestionResponseOption", "fyf");
            this.Property(t => t.LifestyleQuestionResponseOptionId).HasColumnName("LifestyleQuestionResponseOptionId");
            this.Property(t => t.LifestyleQuestionId).HasColumnName("LifestyleQuestionId");
            this.Property(t => t.Title).HasColumnName("Title");

            // Relationships
            this.HasRequired(t => t.FYF_LifestyleQuestion)
                .WithMany(t => t.FYF_LifestyleQuestionResponseOption)
                .HasForeignKey(d => d.LifestyleQuestionId);

        }
    }
}
