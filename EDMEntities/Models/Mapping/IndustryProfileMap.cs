using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class IndustryProfileMap : EntityTypeConfiguration<IndustryProfile>
    {
        public IndustryProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.IndustryProfileID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EDM_IndustryProfile");
            this.Property(t => t.IndustryProfileID).HasColumnName("IndustryProfileID");
            this.Property(t => t.NAICS_ID).HasColumnName("NAICS_ID");
            this.Property(t => t.IndustryImage).HasColumnName("IndustryImage");
            this.Property(t => t.KeyPoints).HasColumnName("KeyPoints");
            this.Property(t => t.Overview).HasColumnName("Overview");           
            this.Property(t => t.Employment).HasColumnName("Employment");
            this.Property(t => t.Workforce).HasColumnName("Workforce");
            this.Property(t => t.EmploymentTypeFullTime).HasColumnName("EmploymentTypeFullTime");
            this.Property(t => t.EmploymentTypeSelfEmployed).HasColumnName("EmploymentTypeSelfEmployed");
            this.Property(t => t.EmploymentTypeTemp).HasColumnName("EmploymentTypeTemp");           
            this.Property(t => t.WorkEnvironment).HasColumnName("WorkEnvironment");
            this.Property(t => t.WorkEnvironmentPrivateSector).HasColumnName("WorkEnvironmentPrivateSector");
            this.Property(t => t.WorkEnvironmentSmallerWorkspace).HasColumnName("WorkEnvironmentSmallerWorkspace");
            this.Property(t => t.WorkEnvironmentUnion).HasColumnName("WorkEnvironmentUnion");
            this.Property(t => t.WagesSummary).HasColumnName("WagesSummary");
            this.Property(t => t.RegionalDistributionSummary).HasColumnName("RegionalDistributionSummary");
            this.Property(t => t.Outlook).HasColumnName("Outlook");
            this.Property(t => t.RelatedCareersIntro).HasColumnName("RelatedCareersIntro");
            this.Property(t => t.IsFeatured).HasColumnName("IsFeatured");
            this.Property(t => t.IndustryHeaderImage).HasColumnName("IndustryHeaderImage");

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
            this.Property(t => t.TableGraph13FootNote).HasColumnName("TableGraph13FootNote");
            this.Property(t => t.TableGraph14FootNote).HasColumnName("TableGraph14FootNote");
            this.Property(t => t.TableGraph15FootNote).HasColumnName("TableGraph15FootNote");
            this.Property(t => t.TableGraph16FootNote).HasColumnName("TableGraph16FootNote");
            this.Property(t => t.TableGraph17FootNote).HasColumnName("TableGraph17FootNote");
            this.Property(t => t.TableGraph18FootNote).HasColumnName("TableGraph18FootNote");

            // Meta data for each profile
            this.Property(t => t.PageTitle).HasColumnName("PageTitle");
            this.Property(t => t.PageDescription).HasColumnName("PageDescription");
            this.Property(t => t.PageKeywords).HasColumnName("PageKeywords");


            // Relationships
            this.HasMany(t => t.RelatedNOC)
                .WithMany(t => t.IndustryProfile)
                .Map(m =>
                {
                    m.ToTable("EDM_IndustryCommonOccupation");
                    m.MapLeftKey("IndustryProfileID");
                    m.MapRightKey("NOC_ID");
                });

            this.HasMany(t => t.RelatedDocument)
                .WithMany(t => t.IndustryProfile)
                .Map(m =>
                {
                    m.ToTable("EDM_IndustryProfileRelatedDocument");
                    m.MapLeftKey("IndustryProfileID");
                    m.MapRightKey("DocumentID");
                });

            this.HasMany(t => t.RelatedSource)
                .WithMany(t => t.IndustryProfile)
                .Map(m =>
                {
                    m.ToTable("EDM_IndustryProfileRelatedSource");
                    m.MapLeftKey("IndustryProfileID");
                    m.MapRightKey("SourceID");
                });

            this.HasRequired(t => t.NAICS)
                .WithMany(t => t.IndustryProfile)
                .HasForeignKey(d => d.NAICS_ID);

        }
    }
}
