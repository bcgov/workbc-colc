using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LifestyleQuestionMap : EntityTypeConfiguration<FYF_LifestyleQuestion>
    {
        public FYF_LifestyleQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.LifestyleQuestionId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FYF_LifestyleQuestion", "fyf");
            this.Property(t => t.LifestyleQuestionId).HasColumnName("LifestyleQuestionId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
        }
    }
}
