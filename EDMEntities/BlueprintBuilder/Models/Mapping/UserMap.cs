using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.BlueprintBuilder.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Users", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME);
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.NewToBC).HasColumnName("NewToBC");
            this.Property(t => t.Female).HasColumnName("Female");
            this.Property(t => t.Male).HasColumnName("Male");
            this.Property(t => t.Aboriginal).HasColumnName("Aboriginal");
            this.Property(t => t.Disability).HasColumnName("Disability");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.Stage).HasColumnName("Stage");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.LastVisited).HasColumnName("LastVisited");
            this.Ignore(t => t.IsAnonymous);
            this.Property(t => t.Salt).HasColumnName("Salt");
            this.Property(t => t.RegisterToken).HasColumnName("RegisterToken");
            this.Property(t => t.PasswordToken).HasColumnName("PasswordToken");
            this.Property(t => t.FailedLoginAttempts).HasColumnName("FailedAttempts");
            this.Property(t => t.IsEmailNotification).HasColumnName("IsEmailNotification");
            this.Property(t => t.IsNotificationNotLoginWithinDurationSent).HasColumnName("IsNotificationNotLoginWithinDurationSent");

            // Relationships
            this.HasOptional(t => t.Blueprint)
                .WithRequired(t => t.User)
                .Map(m => m.ToTable("Blueprints", EDMEntities.BlueprintBuilder.Constants.SCHEMA_NAME).MapKey("UserID"));
        }
    }
}
