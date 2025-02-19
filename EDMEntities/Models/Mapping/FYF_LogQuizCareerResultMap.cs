using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LogQuizCareerResultMap : EntityTypeConfiguration<FYF_LogQuizCareerResult>
    {
        public FYF_LogQuizCareerResultMap()
        {
            // Primary Key
            this.HasKey(t => t.LogQuizCareerResultId);

            // Properties
            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("FYF_LogQuizCareerResult", "fyf");
            this.Property(t => t.LogQuizCareerResultId).HasColumnName("LogQuizCareerResultId");
            this.Property(t => t.LogQuizResultId).HasColumnName("LogQuizResultId");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");

            // Relationships
            this.HasRequired(t => t.FYF_LogQuizResult)
                .WithMany(t => t.FYF_LogQuizCareerResult)
                .HasForeignKey(d => d.LogQuizResultId);

        }
    }
}
