using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LifestyleQuestionResponseOptionLocationScoreMap : EntityTypeConfiguration<FYF_LifestyleQuestionResponseOptionLocationScore>
    {
        public FYF_LifestyleQuestionResponseOptionLocationScoreMap()
        {
            // Primary Key
            this.HasKey(t => t.LifestyleQuestionResponseOptionLocationScoreId);

            // Table & Column Mappings
            this.ToTable("FYF_LifestyleQuestionResponseOptionLocationScore", "fyf");
            this.Property(t => t.LifestyleQuestionResponseOptionLocationScoreId).HasColumnName("LifestyleQuestionResponseOptionLocationScoreId");
            this.Property(t => t.LifestyleQuestionResponseOptionId).HasColumnName("LifestyleQuestionResponseOptionId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.Score).HasColumnName("Score");

            // Relationships
            this.HasRequired(t => t.FYF_LifestyleQuestionResponseOption)
                .WithMany(t => t.FYF_LifestyleQuestionResponseOptionLocationScore)
                .HasForeignKey(d => d.LifestyleQuestionResponseOptionId);

            this.HasRequired(t => t.Location)
                .WithMany(t => t.FYF_LifestyleQuestionResponseOptionLocationScore)
                .HasForeignKey(d => d.LocationId);
        }
    }
}
