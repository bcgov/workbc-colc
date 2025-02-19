using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_SqFtLevelMap : EntityTypeConfiguration<COLC_SqFtLevel>
    {
        public COLC_SqFtLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.SqFtLevelID);

            // Properties
            this.Property(t => t.SqFtLevelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COLC_SqFtLevel", Constants.SCHEMA_NAME);
            this.Property(t => t.SqFtLevelID).HasColumnName("SqFtLevelID");
            this.Property(t => t.SqFt).HasColumnName("SqFt");
        }
    }
}
