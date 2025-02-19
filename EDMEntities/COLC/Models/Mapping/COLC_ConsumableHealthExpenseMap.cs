using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_ConsumableHealthExpenseMap : EntityTypeConfiguration<COLC_ConsumableHealthExpense>
    {
        public COLC_ConsumableHealthExpenseMap()
        {
            // Primary Key
            this.HasKey(t => t.ConsumHealthExpID);

            // Properties
            // Table & Column Mappings
            this.ToTable("COLC_ConsumableHealthExpense", Constants.SCHEMA_NAME);
            this.Property(t => t.ConsumHealthExpID).HasColumnName("ConsumHealthExpID");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.SalaryLevelID).HasColumnName("SalaryLevelID");
            this.Property(t => t.FamilySize).HasColumnName("FamilySize");
            this.Property(t => t.ConsumerablesCost).HasColumnName("ConsumerablesCost");
            this.Property(t => t.HealthCost).HasColumnName("HealthCost");

            // Relationships
            this.HasRequired(t => t.COLC_Location)
                .WithMany(t => t.COLC_ConsumableHealthExpense)
                .HasForeignKey(d => d.LocationID);
            this.HasRequired(t => t.COLC_SalaryLevel)
                .WithMany(t => t.COLC_ConsumableHealthExpense)
                .HasForeignKey(d => d.SalaryLevelID);

        }
    }
}
