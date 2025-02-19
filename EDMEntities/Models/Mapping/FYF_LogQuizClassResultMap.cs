using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LogQuizClassResultMap : EntityTypeConfiguration<FYF_LogQuizClassResult>
    {
        public FYF_LogQuizClassResultMap()
        {
            // Primary Key
            this.HasKey(t => t.LogQuizClassResultId);

            // Properties
            this.Property(t => t.ClassText)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FYF_LogQuizClassResult", "fyf");
            this.Property(t => t.LogQuizClassResultId).HasColumnName("LogQuizClassResultId");
            this.Property(t => t.LogQuizResultId).HasColumnName("LogQuizResultId");
            this.Property(t => t.ClassId).HasColumnName("ClassId");
            this.Property(t => t.ClassText).HasColumnName("ClassText");

            // Relationships
            this.HasRequired(t => t.FYF_LogQuizResult)
                .WithMany(t => t.FYF_LogQuizClassResult)
                .HasForeignKey(d => d.LogQuizResultId);

        }
    }
}
