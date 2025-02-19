using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_TaxTypeMap : EntityTypeConfiguration<COLC_TaxType>
    {
        public COLC_TaxTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TaxTypeID);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("COLC_TaxType", Constants.SCHEMA_NAME);
            this.Property(t => t.TaxTypeID).HasColumnName("TaxTypeID");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
        }
    }
}
