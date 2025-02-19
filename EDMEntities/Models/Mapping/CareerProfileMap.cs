using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileMap : EntityTypeConfiguration<CareerProfile>
    {
        public CareerProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.CareerProfileID);

            // Properties
            this.Property(t => t.MinimumEducation)
                .HasMaxLength(250);

            this.Property(t => t.CareerOutlookTitle)
                .HasMaxLength(255);

            this.Property(t => t.CareerTrekID)
                .IsFixedLength()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("EDM_CareerProfile");
            this.Property(t => t.CareerProfileID).HasColumnName("CareerProfileID");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.MinimumEducation).HasColumnName("MinimumEducation");
            this.Property(t => t.CareerSummary).HasColumnName("CareerSummary");
            this.Property(t => t.MainDuties).HasColumnName("MainDuties");
            this.Property(t => t.SpecialDuties).HasColumnName("SpecialDuties");
            this.Property(t => t.WorkEnvironment).HasColumnName("WorkEnvironment");
            this.Property(t => t.JobRequirements).HasColumnName("JobRequirements");
            this.Property(t => t.Workforce).HasColumnName("Workforce");
            this.Property(t => t.EarningsExtended).HasColumnName("EarningsExtended");
            this.Property(t => t.RegionalEmploymentVIThis).HasColumnName("RegionalEmploymentVIThis");
            this.Property(t => t.RegionalEmploymentVIAll).HasColumnName("RegionalEmploymentVIAll");
            this.Property(t => t.RegionalEmploymentMSWThis).HasColumnName("RegionalEmploymentMSWThis");
            this.Property(t => t.RegionalEmploymentMSWAll).HasColumnName("RegionalEmploymentMSWAll");
            this.Property(t => t.RegionalEmploymentTOKThis).HasColumnName("RegionalEmploymentTOKThis");
            this.Property(t => t.RegionalEmploymentTOKAll).HasColumnName("RegionalEmploymentTOKAll");
            this.Property(t => t.RegionalEmploymentKOOThis).HasColumnName("RegionalEmploymentKOOThis");
            this.Property(t => t.RegionalEmploymentKOOAll).HasColumnName("RegionalEmploymentKOOAll");
            this.Property(t => t.RegionalEmploymentCARThis).HasColumnName("RegionalEmploymentCARThis");
            this.Property(t => t.RegionalEmploymentCARAll).HasColumnName("RegionalEmploymentCARAll");
            this.Property(t => t.RegionalEmploymentNCNThis).HasColumnName("RegionalEmploymentNCNThis");
            this.Property(t => t.RegionalEmploymentNCNAll).HasColumnName("RegionalEmploymentNCNAll");
            this.Property(t => t.EmploymentOutlook).HasColumnName("EmploymentOutlook");
            this.Property(t => t.CareerOutlookTitle).HasColumnName("CareerOutlookTitle");
            this.Property(t => t.CareerOutlookSummary).HasColumnName("CareerOutlookSummary");
            this.Property(t => t.RegionOutlookSummaryMSW).HasColumnName("RegionOutlookSummaryMSW");
            this.Property(t => t.RegionOutlookSummaryVI).HasColumnName("RegionOutlookSummaryVI");
            this.Property(t => t.RegionOutlookSummaryTOK).HasColumnName("RegionOutlookSummaryTOK");
            this.Property(t => t.RegionOutlookSummaryKOO).HasColumnName("RegionOutlookSummaryKOO");
            this.Property(t => t.RegionOutlookSummaryCAR).HasColumnName("RegionOutlookSummaryCAR");
            this.Property(t => t.RegionOutlookSummaryNCN).HasColumnName("RegionOutlookSummaryNCN");
            this.Property(t => t.RegionOutlookSummaryNE).HasColumnName("RegionOutlookSummaryNE");
            this.Property(t => t.CareerPath).HasColumnName("CareerPath");
            this.Property(t => t.CareerTrekDescription).HasColumnName("CareerTrekDescription");
            this.Property(t => t.CareerTrekID).HasColumnName("CareerTrekID");
            this.Property(t => t.CareerTrekImageURL).HasColumnName("CareerTrekImageURL");
            this.Property(t => t.CareerTrekImageAltText).HasColumnName("CareerTrekImageAltText");
            this.Property(t => t.CareerTrekSource).HasColumnName("CareerTrekSource");
            this.Property(t => t.CareerImage).HasColumnName("CareerImage");
            this.Property(t => t.IsFeatured).HasColumnName("IsFeatured");
            this.Property(t => t.FeaturedDescription).HasColumnName("FeaturedDescription");
            this.Property(t => t.CareerImageHeadShot).HasColumnName("CareerImageHeadShot");
            this.Property(t => t.DayInTheLifeOf).HasColumnName("DayInTheLifeOf");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.IsFeaturedCategory).HasColumnName("IsFeaturedCategory");
            this.Property(t => t.FeaturedCategoryDescription).HasColumnName("FeaturedCategoryDescription");
            this.Property(t => t.IsTopOccupation).HasColumnName("IsTopOccupation");
            this.Property(t => t.IsTopHealthOccupation).HasColumnName("IsTopHealthOccupation");
            this.Property(t => t.CareerProfileDescription).HasColumnName("CareerProfileDescription");
            this.Property(t => t.TopOccupationSkillLevelRank).HasColumnName("TopOccupationSkillLevelRank");
            this.Property(t => t.IsTop10Lng).HasColumnName("IsTop10Lng");
            this.Property(t => t.IsTop50Occupation).HasColumnName("IsTop50Occupation");
            this.Property(t => t.IsDesignatedTrade).HasColumnName("IsDesignatedTrade");
            this.Property(t => t.TradesTrainingResourcesNote).HasColumnName("TradesTrainingResourcesNote");
            this.Property(t => t.CareerFullImageAltTag).HasColumnName("CareerFullImageAltTag");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.SkillsAndAttributes).HasColumnName("SkillsAndAttributes");
            this.Property(t => t.EngLangRequire).HasColumnName("EngLangRequire");
            this.Property(t => t.CareerLicensingID).HasColumnName("CareerLicensingID");
            this.Property(t => t.BecomingQualifiedHeader).HasColumnName("BecomingQualifiedHeader");
            this.Property(t => t.TotalApproximateFees).HasColumnName("TotalApproximateFees");
            this.Property(t => t.EstimatedTime).HasColumnName("EstimatedTime");
            this.Property(t => t.BecomingQualifiedContent).HasColumnName("BecomingQualifiedContent");
            this.Property(t => t.RelatedCareersIntro).HasColumnName("RelatedCareersIntro");
            this.Property(t => t.CareerIntro).HasColumnName("CareerIntro");
            this.Property(t => t.AddResourcesNotation).HasColumnName("AddResourcesNotation");

            // Table and Graphs Foot Notes
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

            // Meta data for each profile
            this.Property(t => t.PageTitle).HasColumnName("PageTitle");
            this.Property(t => t.PageDescription).HasColumnName("PageDescription");
            this.Property(t => t.PageKeywords).HasColumnName("PageKeywords");

            // Work-related skills
            this.Property(t => t.WorkRelatedSkillsIntro).HasColumnName("WorkRelatedSkillsIntro");

            // Relationships
            this.HasMany(t => t.RelatedCareerProfiles)
                .WithMany(t => t.RelatedFromCareerProfiles)
                .Map(m =>
                {
                    m.ToTable("EDM_CareerProfileRelatedGroup");
                    m.MapLeftKey("PrimaryCareerProfileID");
                    m.MapRightKey("RelatedCareerProfileID");
                });

            this.HasMany(t => t.RelatedSource)
                .WithMany(t => t.CareerProfile)
                .Map(m =>
                {
                    m.ToTable("EDM_CareerProfileRelatedSource");
                    m.MapLeftKey("CareerProfileID");
                    m.MapRightKey("SourceID");
                });

            this.HasRequired(t => t.NOC)
                .WithMany(t => t.CareerProfile)
                .HasForeignKey(d => d.NOC_ID);

        }
    }
}
