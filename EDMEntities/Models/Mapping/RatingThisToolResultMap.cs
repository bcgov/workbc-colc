using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RatingThisToolResultMap : EntityTypeConfiguration<RatingThisToolResult>
    {
        public RatingThisToolResultMap()
        {
            // Primary Key
            this.HasKey(t => t.ResultId);

            // Table & Column Mappings
            this.ToTable("EDM_RatingThisToolResult");
            this.Property(t => t.ResultId).HasColumnName("ResultId");
            this.Property(t => t.Rating).HasColumnName("Rating");
        }
    }
}
