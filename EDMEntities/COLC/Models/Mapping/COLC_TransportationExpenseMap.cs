using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.COLC.Models.Mapping
{
    public class COLC_TransportationExpenseMap : EntityTypeConfiguration<COLC_TransportationExpense>
    {
        public COLC_TransportationExpenseMap()
        {
            // Primary Key
            this.HasKey(t => t.TransExpID);

            // Properties
            // Table & Column Mappings
            this.ToTable("COLC_TransportationExpense", Constants.SCHEMA_NAME);
            this.Property(t => t.TransExpID).HasColumnName("TransExpID");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.SalaryLevelID).HasColumnName("SalaryLevelID");
            this.Property(t => t.NumOfAutos).HasColumnName("NumOfAutos");
            this.Property(t => t.AutoValue).HasColumnName("AutoValue");
            this.Property(t => t.MileagePerYearID).HasColumnName("MileagePerYearID");
            this.Property(t => t.TransportationCost).HasColumnName("TransportationCost");

            // Relationships
            this.HasRequired(t => t.COLC_Location)
                .WithMany(t => t.COLC_TransportationExpense)
                .HasForeignKey(d => d.LocationID);
            this.HasRequired(t => t.COLC_MileagePerYear)
                .WithMany(t => t.COLC_TransportationExpense)
                .HasForeignKey(d => d.MileagePerYearID);
            this.HasRequired(t => t.COLC_SalaryLevel)
                .WithMany(t => t.COLC_TransportationExpense)
                .HasForeignKey(d => d.SalaryLevelID);

        }
    }
}
