using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public partial class FYF_LogQuizCareerQuizResultMap : EntityTypeConfiguration<FYF_LogQuizCareerQuizResult>
    {
        public FYF_LogQuizCareerQuizResultMap()
        {
            this.HasKey(t => t.LogQuizCareerQuizResultId);
            this.ToTable("FYF_LogQuizCareerQuizResult", "fyf");
            this.Property(t => t.LogQuizCareerQuizResultId).HasColumnName("LogQuizCareerQuizResultId");
            this.Property(t => t.LogQuizResultId).HasColumnName("LogQuizResultId");
            this.Property(t => t.CareerQuizQuestionId).HasColumnName("CareerQuizQuestionId");
            this.Property(t => t.CareerQuizAnswerID).HasColumnName("CareerQuizAnswerID");
            this.HasRequired(t => t.FYF_LogQuizResult).WithMany(t => t.FYF_LogQuizCareerQuizResult).HasForeignKey(d => d.LogQuizResultId);
        }
    }
}
