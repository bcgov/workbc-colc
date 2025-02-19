using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class BlueprintMap : EntityTypeConfiguration<Blueprint>
    {
        public BlueprintMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Blueprints", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LastSaved).HasColumnName("LastSaved");
        }
    }
}
