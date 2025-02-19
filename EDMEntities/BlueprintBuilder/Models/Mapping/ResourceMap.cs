using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class ResourceMap : EntityTypeConfiguration<Resource>
    {
        public ResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Resources", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BlueprintID).HasColumnName("BlueprintID");
            this.Property(t => t.KenticoResourceID).HasColumnName("KenticoResourceID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.Viewed).HasColumnName("Viewed");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.Comment).HasColumnName("Comment");

            this.HasRequired(t => t.Blueprint)
                .WithMany(t => t.Resources)
                .HasForeignKey(d => d.BlueprintID);

        }
    }
}
