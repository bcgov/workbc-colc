using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalEmploymentMap : EntityTypeConfiguration<RegionalEmployment>
    {
        public RegionalEmploymentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.RegionName, t.FullTimeEmploymentRate, t.ShareOfGoodsSector, t.ShareOfServiceSector });

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegionName)
                .IsRequired()
                .HasMaxLength(23);

            this.Property(t => t.FullTimeEmploymentRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShareOfGoodsSector)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShareOfServiceSector)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ListOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("View_RegionalEmployment");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.RegionName).HasColumnName("RegionName");
            this.Property(t => t.FullTimeEmploymentRate).HasColumnName("FullTimeEmploymentRate");
            this.Property(t => t.ShareOfGoodsSector).HasColumnName("ShareOfGoodsSector");
            this.Property(t => t.ShareOfServiceSector).HasColumnName("ShareOfServiceSector");
            this.Property(t => t.ListOrder).HasColumnName("ListOrder");
        }
    }
}
