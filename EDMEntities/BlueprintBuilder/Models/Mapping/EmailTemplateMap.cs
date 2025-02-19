using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class EmailTemplateMap : EntityTypeConfiguration<EmailTemplate>
    {
        public EmailTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EmailTemplate", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Message).HasColumnName("Message");
           
        }
    }
}
