using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_RelatedIndustryGroupMap : EntityTypeConfiguration<FYF_RelatedIndustryGroup>
    {
        public FYF_RelatedIndustryGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupId);

            // Properties
            this.Property(t => t.GroupId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FYF_RelatedIndustryGroup", "fyf");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.Score).HasColumnName("Score");
        }
    }
}
