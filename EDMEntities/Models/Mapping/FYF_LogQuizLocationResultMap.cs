using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LogQuizLocationResultMap : EntityTypeConfiguration<FYF_LogQuizLocationResult>
    {
        public FYF_LogQuizLocationResultMap()
        {
            // Primary Key
            this.HasKey(t => t.LogQuizLocationResultId);

            // Properties
            this.Property(t => t.LocationText)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FYF_LogQuizLocationResult", "fyf");
            this.Property(t => t.LogQuizLocationResultId).HasColumnName("LogQuizLocationResultId");
            this.Property(t => t.LogQuizResultId).HasColumnName("LogQuizResultId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationText).HasColumnName("LocationText");

            // Relationships
            this.HasRequired(t => t.FYF_LogQuizResult)
                .WithMany(t => t.FYF_LogQuizLocationResult)
                .HasForeignKey(d => d.LogQuizResultId);

        }
    }
}
