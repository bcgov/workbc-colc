using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_TaxMap : EntityTypeConfiguration<COLC_Tax>
    {
        public COLC_TaxMap()
        {
            // Primary Key
            this.HasKey(t => t.TaxID);

            // Properties
            this.Property(t => t.TaxID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COLC_Tax", Constants.SCHEMA_NAME);
            this.Property(t => t.TaxID).HasColumnName("TaxID");
            this.Property(t => t.TaxTypeID).HasColumnName("TaxTypeID");
            this.Property(t => t.LowerIncomeAmount).HasColumnName("LowerIncomeAmount");
            this.Property(t => t.UpperIncomeAmount).HasColumnName("UpperIncomeAmount");
            this.Property(t => t.BaseIncomeAmount).HasColumnName("BaseIncomeAmount");
            this.Property(t => t.TaxRate).HasColumnName("TaxRate");
            this.Property(t => t.CumulativeTaxAmount).HasColumnName("CumulativeTaxAmount");

            // Relationships
            this.HasRequired(t => t.COLC_TaxType)
                .WithMany(t => t.COLC_Tax)
                .HasForeignKey(d => d.TaxTypeID);

        }
    }
}
