using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_HousingExpenseMap : EntityTypeConfiguration<COLC_HousingExpense>
    {
        public COLC_HousingExpenseMap()
        {
            // Primary Key
            this.HasKey(t => t.HousingExpenseID);

            // Properties
            // Table & Column Mappings
            this.ToTable("COLC_HousingExpense", Constants.SCHEMA_NAME);
            this.Property(t => t.HousingExpenseID).HasColumnName("HousingExpenseID");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.SalaryLevelID).HasColumnName("SalaryLevelID");
            this.Property(t => t.OwnIndicatorID).HasColumnName("OwnIndicatorID");
            this.Property(t => t.SqFtLevelID).HasColumnName("SqFtLevelID");
            this.Property(t => t.FamilySize).HasColumnName("FamilySize");
            this.Property(t => t.DownPaymentLevelID).HasColumnName("DownPaymentLevelID");
            this.Property(t => t.AnnualHousingCost).HasColumnName("AnnualHousingCost");

            // Relationships
            this.HasRequired(t => t.COLC_DownPaymentLevel)
                .WithMany(t => t.COLC_HousingExpense)
                .HasForeignKey(d => d.DownPaymentLevelID);
            this.HasRequired(t => t.COLC_Location)
                .WithMany(t => t.COLC_HousingExpense)
                .HasForeignKey(d => d.LocationID);
            this.HasRequired(t => t.COLC_OwnIndicator)
                .WithMany(t => t.COLC_HousingExpense)
                .HasForeignKey(d => d.OwnIndicatorID);
            this.HasRequired(t => t.COLC_SalaryLevel)
                .WithMany(t => t.COLC_HousingExpense)
                .HasForeignKey(d => d.SalaryLevelID);
            this.HasRequired(t => t.COLC_SqFtLevel)
                .WithMany(t => t.COLC_HousingExpense)
                .HasForeignKey(d => d.SqFtLevelID);

        }
    }
}
