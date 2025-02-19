using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalExpectedHighGrowthOccupationMap : EntityTypeConfiguration<RegionalExpectedHighGrowthOccupation>
    {
        public RegionalExpectedHighGrowthOccupationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegionalProfileId, t.NOC_ID, t.GrowthRate, t.Jobs });

            // Properties
            this.Property(t => t.RegionalProfileId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOC_ID)
                .IsRequired();

            this.Property(t => t.NameEnglish)
                .HasMaxLength(200);

            this.Property(t => t.GrowthRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Jobs)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("View_RegionalExpectedHighGrowthOccupation");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NameEnglish).HasColumnName("NameEnglish");
            this.Property(t => t.GrowthRate).HasColumnName("GrowthRate");
            this.Property(t => t.Jobs).HasColumnName("Jobs");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.TopLevelNocCode).HasColumnName("TopLevelNocCode");
            //this.Property(t => t.Ranking).HasColumnName("Ranking");
        }
    }
}
