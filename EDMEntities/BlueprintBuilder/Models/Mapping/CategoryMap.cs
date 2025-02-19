using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(p => p.ID);

            // Properties
            this.Property(p => p.Title).HasMaxLength(50);
            this.Property(p => p.MobileTitle).HasMaxLength(50);
            this.Property(p => p.ImageUrl).HasMaxLength(50);
            this.Property(p => p.AlternateText).HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Categories", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.MobileTitle).HasColumnName("MobileTitle");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.AlternateText).HasColumnName("AlternateText");
            this.Property(t => t.CategoryNumber).HasColumnName("CategoryNumber");
        }
    }
}

