using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class CareerSuggestionMap : EntityTypeConfiguration<CareerSuggestion>
    {
        public CareerSuggestionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CareerSuggestions", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ResultsID).HasColumnName("ResultsID");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Suggestion).HasColumnName("Suggestion");
            this.Property(t => t.Hidden).HasColumnName("Hidden");

            this.HasRequired(t => t.Result)
                .WithMany(t => t.CareerSuggestions)
                .HasForeignKey(d => d.ResultsID);


        }
    }
}
