using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace EDMEntities.Models.Mapping
{
    public partial class FYF_CareerQuizQuestionMap : EntityTypeConfiguration<FYF_CareerQuizQuestion>
    {
        public FYF_CareerQuizQuestionMap()
        {
            this.HasKey(t => t.CareerQuestionId);
            this.ToTable("FYF_CareerQuizQuestion", "fyf");
            this.Property(t => t.CareerQuestionId).HasColumnName("CareerQuestionId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.QuestionNumber).HasColumnName("QuestionNumber");
            this.Property(t => t.Question).HasColumnName("Question").IsRequired().HasMaxLength(300);
            this.Property(t => t.CareerQuizType).HasColumnName("CareerQuizType");
        }
    }
}
