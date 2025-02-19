using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EDMEntities.Models.Custom;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileDetailViewMap : EntityTypeConfiguration<CareerProfileDetailView>
    {
        public CareerProfileDetailViewMap()
        {
            // Primary Key
            this.HasKey(t => t.CareerProfileID);

            // Properties
            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("vw_CareerProfileDetails");
            this.Property(t => t.CareerProfileID).HasColumnName("CareerProfileID");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.CareerTrekDescription).HasColumnName("CareerTrekDescription");
            this.Property(t => t.CareerTrekID).HasColumnName("CareerTrekID");
            this.Property(t => t.CareerTrekImageURL).HasColumnName("CareerTrekImageURL");
            this.Property(t => t.CareerImage).HasColumnName("CareerImage");
            this.Property(t => t.CareerFullImageAltTag).HasColumnName("CareerFullImageAltTag");
            this.Property(t => t.CareerImageHeadShot).HasColumnName("CareerImageHeadShot");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.MinimumEducation).HasColumnName("MinimumEducation");
            this.Property(t => t.CareerIntro).HasColumnName("CareerIntro");
            this.Property(t => t.CareerSummary).HasColumnName("CareerSummary");
            this.Property(t => t.MainDuties).HasColumnName("MainDuties");
            this.Property(t => t.MainDutiesMore).HasColumnName("MainDutiesMore");
            this.Property(t => t.WorkEnvironment).HasColumnName("WorkEnvironment");
            this.Property(t => t.WorkEnvironmentMore).HasColumnName("WorkEnvironmentMore");

            this.Property(t => t.JobRequirements).HasColumnName("JobRequirements");
            this.Property(t => t.JobRequirementsMore).HasColumnName("JobRequirementsMore");
            this.Property(t => t.CareerPath).HasColumnName("CareerPath");
            this.Property(t => t.CareerPathMore).HasColumnName("CareerPathMore");

            this.Property(t => t.InsightsFromIndustry).HasColumnName("InsightsFromIndustry");
            this.Property(t => t.InsightsFromIndustryMore).HasColumnName("InsightsFromIndustryMore");
            this.Property(t => t.DayInTheLifeContent).HasColumnName("DayInTheLifeContent");
            this.Property(t => t.DayInTheLifeContentMore).HasColumnName("DayInTheLifeContentMore");

            this.Property(t => t.OccupationGroup).HasColumnName("OccupationGroup");
            this.Property(t => t.SiteID).HasColumnName("SiteID");

            this.Property(t => t.IsTopOccupation).HasColumnName("IsTopOccupation");
            this.Property(t => t.IsTopHealthOccupation).HasColumnName("IsTopHealthOccupation");

            this.Property(t => t.WorkRelatedSkillsIntro).HasColumnName("WorkRelatedSkillsIntro");
            this.Property(t => t.WorkRelatedSkillsSource).HasColumnName("WorkRelatedSkillsSource");

            this.HasRequired(t => t.NOC)
                .WithMany(t => t.CareerProfileDetailView)
                .HasForeignKey(d => d.NOC_ID);
        }
    }
}
