using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_CareerQuizAnswerMap : EntityTypeConfiguration<FYF_CareerQuizAnswer>
    {
        public FYF_CareerQuizAnswerMap()
        {
            this.HasKey(t => t.CareerQuizAnswerID);
            this.ToTable("FYF_CareerQuizAnswer", "fyf");
            this.Property(t => t.CareerQuizAnswerID).HasColumnName("CareerQuizAnswerID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.AnswerText).HasColumnName("AnswerText").IsRequired().HasMaxLength(200);
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.CareerQuizType).HasColumnName("CareerQuizType");
        }
    }
}
