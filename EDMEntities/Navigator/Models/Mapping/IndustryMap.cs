using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Navigator.Models.Mapping
{
    public class IndustryMap : EntityTypeConfiguration<Industry>
    {
        public IndustryMap()
        {
            // Primary Key
            this.HasKey(t => t.Name);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Region_1)
                .HasMaxLength(255);

            this.Property(t => t.Region_2)
                .HasMaxLength(255);

            this.Property(t => t.Region_3)
                .HasMaxLength(255);

            this.Property(t => t.Common_Occupation_1)
                .HasMaxLength(255);

            this.Property(t => t.NOC1)
                .HasMaxLength(255);

            this.Property(t => t.Common_Occupation_2)
                .HasMaxLength(255);

            this.Property(t => t.NOC2)
                .HasMaxLength(255);

            this.Property(t => t.Common_Occupation_3)
                .HasMaxLength(255);

            this.Property(t => t.NOC3)
                .HasMaxLength(255);

            this.Property(t => t.Common_Occupation_4)
                .HasMaxLength(255);

            this.Property(t => t.NOC4)
                .HasMaxLength(255);

            this.Property(t => t.Common_Occupation_5)
                .HasMaxLength(255);

            this.Property(t => t.NOC5)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Industry", Constants.SCHEMA_NAME);
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Projected_Employment_Change_2010_2020).HasColumnName("Projected Employment Change 2010-2020");
            this.Property(t => t.Forecasted_Average_Annual_Growth_in_Employment__2010_2020_).HasColumnName("Forecasted Average Annual Growth in Employment (2010-2020)");
            this.Property(t => t.Employment_in_2010).HasColumnName("Employment in 2010");
            this.Property(t => t.Employment_in_2015).HasColumnName("Employment in 2015");
            this.Property(t => t.Employment_in_2020).HasColumnName("Employment in 2020");
            this.Property(t => t.Region_1).HasColumnName("Region 1");
            this.Property(t => t.Average_Annual_Growth_of_employment_in_industry_in_region_1).HasColumnName("Average Annual Growth of employment in industry in region 1");
            this.Property(t => t.Region_2).HasColumnName("Region 2");
            this.Property(t => t.Average_Annual_Growth_of_employment_in_industry_in_region_2).HasColumnName("Average Annual Growth of employment in industry in region 2");
            this.Property(t => t.Region_3).HasColumnName("Region 3");
            this.Property(t => t.Average_Annual_Growth_of_employment_in_industry_in_region_3).HasColumnName("Average Annual Growth of employment in industry in region 3");
            this.Property(t => t.Common_Occupation_1).HasColumnName("Common Occupation 1");
            this.Property(t => t.NOC1).HasColumnName("NOC1");
            this.Property(t => t.Common_Occupation_2).HasColumnName("Common Occupation 2");
            this.Property(t => t.NOC2).HasColumnName("NOC2");
            this.Property(t => t.Common_Occupation_3).HasColumnName("Common Occupation 3");
            this.Property(t => t.NOC3).HasColumnName("NOC3");
            this.Property(t => t.Common_Occupation_4).HasColumnName("Common Occupation 4");
            this.Property(t => t.NOC4).HasColumnName("NOC4");
            this.Property(t => t.Common_Occupation_5).HasColumnName("Common Occupation 5");
            this.Property(t => t.NOC5).HasColumnName("NOC5");
        }
    }
}
