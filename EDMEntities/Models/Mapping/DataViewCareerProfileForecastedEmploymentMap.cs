using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Mapping
{
    public class DataViewCareerProfileForecastedEmploymentMap : EntityTypeConfiguration<DataViewCareerProfileForecastedEmployment>
    {
        public DataViewCareerProfileForecastedEmploymentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_ID, t.NOCCode });

            // Properties
            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.LocationName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_DataViewCareerProfileForecastedEmployment");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");            
            this.Property(t => t.ForecastedEmployment).HasColumnName("ForecastedEmployment");
        }
    }
}
