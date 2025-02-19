using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_DownPaymentLevelMap : EntityTypeConfiguration<COLC_DownPaymentLevel>
    {
        public COLC_DownPaymentLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.DownPaymentLevelID);

            // Properties
            this.Property(t => t.DownPaymentLevelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COLC_DownPaymentLevel", Constants.SCHEMA_NAME);
            this.Property(t => t.DownPaymentLevelID).HasColumnName("DownPaymentLevelID");
            this.Property(t => t.DownPayment).HasColumnName("DownPayment");
        }
    }
}
