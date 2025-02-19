using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LogLifestyleQuestionResultMap : EntityTypeConfiguration<FYF_LogLifestyleQuestionResult>
    {
        public FYF_LogLifestyleQuestionResultMap()
        {
            // Primary Key
            this.HasKey(t => t.LogLifestyleQuestionResultId);

            // Properties
            this.Property(t => t.QuestionText)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ResponseOptionText)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FYF_LogLifestyleQuestionResult", "fyf");
            this.Property(t => t.LogLifestyleQuestionResultId).HasColumnName("LogLifestyleQuestionResultId");
            this.Property(t => t.LogQuizResultId).HasColumnName("LogQuizResultId");
            this.Property(t => t.QuestionId).HasColumnName("QuestionId");
            this.Property(t => t.QuestionText).HasColumnName("QuestionText");
            this.Property(t => t.ResponseOptionId).HasColumnName("ResponseOptionId");
            this.Property(t => t.ResponseOptionText).HasColumnName("ResponseOptionText");

            // Relationships
            this.HasRequired(t => t.FYF_LogQuizResult)
                .WithMany(t => t.FYF_LogLifestyleQuestionResult)
                .HasForeignKey(d => d.LogQuizResultId);

        }
    }
}
