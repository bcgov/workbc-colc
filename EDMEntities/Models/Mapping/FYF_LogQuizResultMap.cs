using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_LogQuizResultMap : EntityTypeConfiguration<FYF_LogQuizResult>
    {
        public FYF_LogQuizResultMap()
        {
            // Primary Key
            this.HasKey(t => t.LogQuizResultId);

            // Properties
            // Table & Column Mappings
            this.ToTable("FYF_LogQuizResult", "fyf");
            this.Property(t => t.LogQuizResultId).HasColumnName("LogQuizResultId");
            this.Property(t => t.DominantArchetypeId).HasColumnName("DominantArchetypeId");
            this.Property(t => t.DominantNACIS_ID).HasColumnName("DominantNACIS_ID");
            this.Property(t => t.CareerQuizType).HasColumnName("CareerQuizType");
        }
    }
}
