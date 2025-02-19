using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class ToolMap : EntityTypeConfiguration<Tool>
    {
        public ToolMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Tools", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BlueprintID).HasColumnName("BlueprintID");
            this.Property(t => t.KenticoToolID).HasColumnName("KenticoToolID");
            this.Property(t => t.Viewed).HasColumnName("Viewed");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.Comment).HasColumnName("Comment");

            this.HasRequired(t => t.Blueprint)
                .WithMany(t => t.Tools)
                .HasForeignKey(d => d.BlueprintID);

        }
    }
}
