using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class DataViewCareerProfileRegionalEmploymentMap : EntityTypeConfiguration<DataViewCareerProfileRegionalEmployment>
    {
        public DataViewCareerProfileRegionalEmploymentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_ID, t.NOCCode, t.LocationID });

            // Properties
            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.title)
                .HasMaxLength(200);

            this.Property(t => t.LocationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vw_CareerProfileRegionalEmployment");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Location)
                .WithMany(t => t.DataViewCareerProfileRegionalEmployment)
                .HasForeignKey(d => d.LocationID);
        }
    }
}
