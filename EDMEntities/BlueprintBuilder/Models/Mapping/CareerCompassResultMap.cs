using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class CareerCompassResultMap : EntityTypeConfiguration<CareerCompassResult>
    {
        public CareerCompassResultMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CareerCompassResults", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ToolID).HasColumnName("ToolID");
            this.Property(t => t.QuizType).HasColumnName("QuizType");
            this.Property(t => t.QuizResult).HasColumnName("QuizResult");
            this.HasRequired(t => t.Tool)
                .WithMany(t => t.CareerCompassResults)
                .HasForeignKey(d => d.ToolID);

        }
    }
}
