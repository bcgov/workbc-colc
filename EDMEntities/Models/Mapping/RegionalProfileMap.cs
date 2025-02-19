using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class RegionalProfileMap : EntityTypeConfiguration<RegionalProfile>
    {
        public RegionalProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionalProfileId);

            // Properties
            // Table & Column Mappings
            this.ToTable("EDM_RegionalProfile");
            this.Property(t => t.RegionalProfileId).HasColumnName("RegionalProfileId");
            this.Property(t => t.Overview).HasColumnName("Overview");
            this.Property(t => t.KeyPoints).HasColumnName("KeyPoints");
            this.Property(t => t.PopulationDistribution).HasColumnName("PopulationDistribution");
            this.Property(t => t.Demographics).HasColumnName("Demographics");
            this.Property(t => t.WorkforceFullTime).HasColumnName("WorkforceFullTime");
            this.Property(t => t.WorkforceUnemployed).HasColumnName("WorkforceUnemployed");
            this.Property(t => t.RegionRoleSummary).HasColumnName("RegionRoleSummary");
            this.Property(t => t.RegionRoleServiceSector).HasColumnName("RegionRoleServiceSector");
            this.Property(t => t.RegionRoleGoodsSector).HasColumnName("RegionRoleGoodsSector");
            this.Property(t => t.EmployDistributionSummary).HasColumnName("EmployDistributionSummary");
            this.Property(t => t.EmployDistributionServiceSector).HasColumnName("EmployDistributionServiceSector");
            this.Property(t => t.EmployDistributionGoodsSector).HasColumnName("EmployDistributionGoodsSector");
            this.Property(t => t.RegionalHeaderImage).HasColumnName("RegionalHeaderImage");
            // Table or Graph Foot Note (Optional)
            this.Property(t => t.TableGraph1FootNote).HasColumnName("TableGraph1FootNote");
            this.Property(t => t.TableGraph2FootNote).HasColumnName("TableGraph2FootNote");
            this.Property(t => t.TableGraph3FootNote).HasColumnName("TableGraph3FootNote");
            this.Property(t => t.TableGraph4FootNote).HasColumnName("TableGraph4FootNote");
            this.Property(t => t.TableGraph5FootNote).HasColumnName("TableGraph5FootNote");
            this.Property(t => t.TableGraph6FootNote).HasColumnName("TableGraph6FootNote");
            this.Property(t => t.TableGraph7FootNote).HasColumnName("TableGraph7FootNote");
            this.Property(t => t.TableGraph8FootNote).HasColumnName("TableGraph8FootNote");
            this.Property(t => t.TableGraph9FootNote).HasColumnName("TableGraph9FootNote");
            this.Property(t => t.TableGraph10FootNote).HasColumnName("TableGraph10FootNote");
            this.Property(t => t.TableGraph11FootNote).HasColumnName("TableGraph11FootNote");
            this.Property(t => t.TableGraph12FootNote).HasColumnName("TableGraph12FootNote");

            // Meta data for each profile
            this.Property(t => t.PageTitle).HasColumnName("PageTitle");
            this.Property(t => t.PageDescription).HasColumnName("PageDescription");
            this.Property(t => t.PageKeywords).HasColumnName("PageKeywords");
        }
    }
}
