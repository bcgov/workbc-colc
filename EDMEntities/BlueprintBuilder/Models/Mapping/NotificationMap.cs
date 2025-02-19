using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class NotificationMap : EntityTypeConfiguration<Notification>
    {
        public NotificationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Notification", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.NotoficationType).HasColumnName("NotoficationType");
            this.Property(t => t.ResourceID).HasColumnName("ResourceID");
            this.Property(t => t.ToolID).HasColumnName("ToolID");
            this.Property(t => t.SentOn).HasColumnName("SentOn");
        }
    }
}
