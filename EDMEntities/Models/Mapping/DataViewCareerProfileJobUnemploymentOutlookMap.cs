using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace EDMEntities.Models.Mapping
{
    public class DataViewCareerProfileJobUnemploymentOutlookMap : EntityTypeConfiguration<DataViewCareerProfileJobUnemploymentOutlook>
    {
        public DataViewCareerProfileJobUnemploymentOutlookMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NOC_ID, t.ParentNOC_ID, t.NOCCode });

            // Properties
            this.Property(t => t.NOC_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

          
            // Table & Column Mappings
            this.ToTable("vw_DataViewCareerProfileJobUnemploymentOutlook");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.ParentNOC_ID).HasColumnName("ParentNOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.DataYear).HasColumnName("DataYear");
            this.Property(t => t.UnemploymentRate).HasColumnName("UnemploymentRate");
            this.Property(t => t.JobOpenings10Years).HasColumnName("JobOpenings10Years");
            this.Property(t => t.JobOpeningsYear).HasColumnName("JobOpeningsYear");
            this.Property(t => t.JobOpeningsDataYear).HasColumnName("JobOpeningsDataYear");
        }
    }
}
