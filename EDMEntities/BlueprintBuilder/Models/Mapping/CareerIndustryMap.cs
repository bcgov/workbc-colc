using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class CareerIndustryMap : EntityTypeConfiguration<CareerIndustry>
    {
        public CareerIndustryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CareerIndustries", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ResultsID).HasColumnName("ResultsID");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Industry).HasColumnName("Industry");
            this.Property(t => t.SortIndex).HasColumnName("SortIndex");
            this.Property(t => t.Hidden).HasColumnName("Hidden");

            this.HasRequired(t => t.Result)
                .WithMany(t => t.CareerIndustries)
                .HasForeignKey(d => d.ResultsID);

        }
    }
}
