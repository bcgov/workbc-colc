using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LogQuizIndustryResultMap : EntityTypeConfiguration<FYF_LogQuizIndustryResult>
    {
        public FYF_LogQuizIndustryResultMap()
        {
            // Primary Key
            this.HasKey(t => t.LogQuizLocationResultId);

            this.ToTable("FYF_LogQuizIndustryResult", "fyf");
            this.Property(t => t.LogQuizLocationResultId).HasColumnName("LogQuizLocationResultId");
            this.Property(t => t.LogQuizResultId).HasColumnName("LogQuizResultId");
            this.Property(t => t.IndustryId).HasColumnName("IndustryId");
            this.Property(t => t.IndustryText).HasColumnName("IndustryText").IsRequired().HasMaxLength(200);
            this.HasRequired(t => t.FYF_LogQuizResult).WithMany(t => t.FYF_LogQuizIndustryResult).HasForeignKey(d => d.LogQuizResultId);
        }
    }
}