using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EDMEntities.Models.Mapping;
using System.Collections.Generic;
using EDMEntities.Filters;

namespace EDMEntities
{
    public partial class WorkBC_EDMContext : DbContext
    {
        static WorkBC_EDMContext()
        {
            Database.SetInitializer<WorkBC_EDMContext>(null);
        }

        public WorkBC_EDMContext()
            : base("Name=WorkBCConnectionString")
        {
        }


        public void ApplyFilters(IList<IFilter<WorkBC_EDMContext>> filters)
        {
            foreach (var filter in filters)
            {
                filter.DbContext = this;
                filter.Apply();
            }
        }


        #region ---- EDM Models --------------------------------------------------------

        public DbSet<EDMEntities.Models.CareerLicensing> CareerLicensings { get; set; }
        public IDbSet<EDMEntities.Models.CareerProfile> CareerProfiles { get; set; }
        public DbSet<EDMEntities.Models.CareerProfileSkill> CareerProfileSkills { get; set; }
        public DbSet<EDMEntities.Models.CareerSkill> CareerSkills { get; set; }
        public DbSet<EDMEntities.Models.CareerProfileInYourLanguage> CareerProfileInYourLanguages { get; set; }
        public DbSet<EDMEntities.Models.CareerProfileBecomingQualified> CareerProfileBecomingQualified { get; set; }
        public DbSet<EDMEntities.Models.CareerProfileCareerTrekVideos> CareerProfileCareerTrekVideos { get; set; }
        public DbSet<EDMEntities.Models.CareerProfileWorkRelatedSkill> CareerProfileWorkRelatedSkills { get; set; }
        public DbSet<EDMEntities.Models.CareerProfileSkillDefinition> CareerProfileSkillsDefinitions { get; set; }
        public DbSet<EDMEntities.Models.ViewCareerProfileWorkRelatedSkill> ViewCareerProfileWorkRelatedSkills { get; set; }
        public DbSet<EDMEntities.Models.CareerProfileWorkRelatedSkillsSource> CareerProfileWorkRelatedSkillsSource { get; set; }
        public DbSet<EDMEntities.Models.CareerProfileWorkRelatedSkillsFile> CareerProfileWorkRelatedSkillsFiles { get; set; }
        public DbSet<EDMEntities.Models.DataViewCareerProfile> DataViewCareerProfile { get; set; }
        public DbSet<EDMEntities.Models.DataViewCareerProfileExpectedOutlookByRegion> DataViewCareerProfileExpectedOutlookByRegion { get; set; }
        public DbSet<EDMEntities.Models.DataViewCareerProfileTopIndustriesByEmployment> DataViewCareerProfileTopIndustriesByEmployment { get; set; }
        public DbSet<EDMEntities.Models.DataViewCareerProfileJobUnemploymentOutlook> DataViewCareerProfileJobUnemploymentOutlook { get; set; }
        public DbSet<EDMEntities.Models.DataViewCareerProfileJobOpeningsOutlook> DataViewCareerProfileJobOpeningsOutlook { get; set; }
        public DbSet<EDMEntities.Models.DataViewCareerProfileForecastedEmployment> DataViewCareerProfileForecastedEmployment { get; set; }
        public DbSet<EDMEntities.Models.DataViewCareerProfileRegionalOutlook> DataViewCareerProfileRegionalOutlook { get; set; } 
        public DbSet<EDMEntities.Models.DataViewTopOccupation> DataViewTopOccupation { get; set; }        
        public DbSet<EDMEntities.Models.DataViewTopLNGOccupation> DataViewTopLNGOccupation { get; set; }
        public DbSet<EDMEntities.Models.DataViewTopHealthOccupation> DataViewTopHealthOccupation { get; set; }
        public DbSet<EDMEntities.Models.IndustryProfile> IndustryProfiles { get; set; }
        public DbSet<EDMEntities.Models.IndustryProfileImpact> IndustryProfileImpacts { get; set; }
        public DbSet<EDMEntities.Models.Location> Location { get; set; }
        public DbSet<EDMEntities.Models.LocationType> LocationType { get; set; }
        public DbSet<EDMEntities.Models.NAICS> NAICS { get; set; }
        public DbSet<EDMEntities.Models.NAICSCodes> NAICSCodes { get; set; }
        public IDbSet<EDMEntities.Models.NOC> NOC { get; set; }
        public DbSet<EDMEntities.Models.NOCGroupType> NOCGroupType { get; set; }
        public DbSet<EDMEntities.Models.NOCJobTitles> NOCJobTitles { get; set; }
        public DbSet<EDMEntities.Models.RegionalProfile> RegionalProfiles { get; set; }
        public DbSet<EDMEntities.Models.RelatedDocument> RelatedDocuments { get; set; }
        public DbSet<EDMEntities.Models.RelatedSource> RelatedSources { get; set; }
        public DbSet<EDMEntities.Models.NOCSkillLevelDemandOutlook> SkillLevel { get; set; }
        public DbSet<EDMEntities.Models.FYF_Archetype> FYF_Archetype { get; set; }
        public DbSet<EDMEntities.Models.FYF_ArchetypeRelatedIndustry> FYF_ArchetypeRelatedIndustry { get; set; }
        public DbSet<EDMEntities.Models.FYF_Class> FYF_Class { get; set; }
        public DbSet<EDMEntities.Models.FYF_LogLifestyleQuestionResult> FYF_LogLifestyleQuestionResult { get; set; }
        public DbSet<EDMEntities.Models.FYF_LogQuizCareerResult> FYF_LogQuizCareerResult { get; set; }
        public DbSet<EDMEntities.Models.FYF_LogQuizClassResult> FYF_LogQuizClassResult { get; set; }
        public DbSet<EDMEntities.Models.FYF_LogQuizLocationResult> FYF_LogQuizLocationResult { get; set; }
        public DbSet<EDMEntities.Models.FYF_LogQuizIndustryResult> FYF_LogQuizIndustryResult { get; set; }
        public DbSet<EDMEntities.Models.FYF_LogQuizResult> FYF_LogQuizResult { get; set; }
        public DbSet<EDMEntities.Models.FYF_QuizQuestion> FYF_QuizQuestion { get; set; }
        public DbSet<EDMEntities.Models.FYF_QuizSubject> FYF_QuizSubject { get; set; }
        public DbSet<EDMEntities.Models.FYF_RelatedIndustryGroup> FYF_RelatedIndustryGroup { get; set; }
        public DbSet<EDMEntities.Models.FYF_Subject> FYF_Subject { get; set; }
        public DbSet<EDMEntities.Models.FYF_LifestyleQuestion> FYF_LifestyleQuestion { get; set; }
        public DbSet<EDMEntities.Models.FYF_LifestyleQuestionResponseOption> FYF_LifestyleQuestionResponseOption { get; set; }
        public DbSet<EDMEntities.Models.FYF_LifestyleQuestionResponseOptionLocationScore> FYF_LifestyleQuestionResponseOptionLocationScore { get; set; }
        public DbSet<EDMEntities.Models.FYF_CareerQuizQuestion> FYF_CareerQuizQuestion { get; set; }
        public DbSet<EDMEntities.Models.FYF_CareerQuizAnswer> FYF_CareerQuizAnswer { get; set; }
        public DbSet<EDMEntities.Models.FYF_LogQuizCareerQuizResult> FYF_LogQuizCareerQuizResult { get; set; }
        public DbSet<EDMEntities.Models.FYF_Ability> FYF_Ability { get; set; }
        public DbSet<EDMEntities.Models.FYF_WorkPreference> FYF_WorkPreference { get; set; }
        public DbSet<EDMEntities.Models.WBC_CatchmentArea> WBC_CatchmentArea { get; set; }
        public DbSet<EDMEntities.Models.WBC_Province> WBC_Province { get; set; }
        public DbSet<EDMEntities.Models.WBC_ServicesCentre> WBC_ServicesCentre { get; set; }
        public DbSet<EDMEntities.Models.WBC_ServicesCentreContractor> WBC_ServicesCentreContractor { get; set; }

        public DbSet<EDMEntities.Models.Custom.CareerProfileDetailView> CareerProfileDetailView { get; set; }
        public DbSet<EDMEntities.Models.Custom.CareerProfilesGeneralDetailsView> CareerProfilesGeneralDetailsView { get; set; }
        public DbSet<EDMEntities.Models.Custom.IndustryProfileView> IndustryProfileView { get; set; }
        public DbSet<EDMEntities.Models.Custom.IndustryProfileImpactView> IndustryProfileImpactView { get; set; }
        public DbSet<EDMEntities.Models.Custom.IndustryProfileRelatedSourceView> IndustryProfileRelatedSourceView { get; set; }
        public DbSet<EDMEntities.Models.Custom.IndustrySnapshotLatestView> IndustrySnapshotLatestView { get; set; }
        public DbSet<EDMEntities.Models.Custom.IndustryProfileRelatedDocumentView> IndustryProfileRelatedDocumentView { get; set; }
        public DbSet<EDMEntities.Models.Custom.IndustryProfileCommonOccupationView> IndustryProfileCommonOccupationView { get; set; }
        public DbSet<EDMEntities.Models.Custom.IndustryRegionalShareOfProvincialEmploymentView> IndustryRegionalShareOfProvincialEmploymentView { get; set; }
        public DbSet<EDMEntities.Models.Custom.RegionalEmploymentPercentageAllOccupationsView> RegionalEmploymentPercentageAllOccupationsView { get; set; }

        public DbSet<EDMEntities.Models.RegionalProfileDetail> RegionalProfileDetails { get; set; }
        public DbSet<EDMEntities.Models.RegionalDistrict> RegionalDistricts { get; set; }
        public DbSet<EDMEntities.Models.RegionalAgeDistribution> RegionalAgeDistributions { get; set; }
        public DbSet<EDMEntities.Models.RegionalEmployment> RegionalEmployments { get; set; }
        public DbSet<EDMEntities.Models.RegionalIndustryDetail> RegionalIndustryDetails { get; set; }
        public DbSet<EDMEntities.Models.RegionalUnemploymentRate> RegionalUnemploymentRates { get; set; }
        public DbSet<EDMEntities.Models.RegionalOccupationOutlook> RegionalOccupationOutlooks { get; set; }
        public DbSet<EDMEntities.Models.RegionalExpectedHighGrowthOccupation> RegionalExpectedHighGrowthOccupations { get; set; }
        public DbSet<EDMEntities.Models.RegionalIndustryOutlook> RegionalIndustryOutlooks { get; set; }
        public DbSet<EDMEntities.Models.RegionalTopIndustriesByJobOpenings> RegionalTopIndustriesByJobOpenings { get; set; }
        public DbSet<EDMEntities.Models.LocationRegionView> DataRegionViews { get; set; }
        public DbSet<EDMEntities.Models.DataPointCareer> DataPointCareers { get; set; }
        public DbSet<EDMEntities.Models.DataPointIndustry> DataPointIndustries { get; set; }
        public DbSet<EDMEntities.Models.DataPointLocation> DataPointLocations { get; set; }
        public DbSet<EDMEntities.Models.DataViewCareerProfileRegionalEmployment> DataViewCareerProfileRegionalEmployments { get; set; }
        public DbSet<EDMEntities.Models.ViewMinorGroup> ViewMinorGroups { get; set; }
        public DbSet<EDMEntities.Models.EDM_EduPlannerNoc> EDM_EduPlannerNoc { get; set; }
        //public DbSet<EDMEntities.Models.EDM_EduPlannerProgram> EDM_EduPlannerProgram { get; set; }
        public DbSet<EDMEntities.Models.EDM_EduPlannerSubjectArea> EDM_EduPlannerSubjectArea { get; set; }
        public DbSet<EDMEntities.Models.EDM_EduPlannerField> EDM_EduPlannerField { get; set; }
        //public DbSet<EDMEntities.Models.EDM_EduPlannerLength> EDM_EduPlannerLength { get; set; }

      
        public DbSet<EDMEntities.Models.Custom.HOOReport> HOOReports { get; set; }
        public DbSet<EDMEntities.Models.Custom.HOOReportContent> HOOReportContent { get; set; }
        public DbSet<EDMEntities.Models.Custom.HOOReportSection> HOOReportSections { get; set; }
        public DbSet<EDMEntities.Models.Custom.HOOLMIndicators> HOOLMIndicators { get; set; }

        public DbSet<EDMEntities.Models.Custom.DemographicsReport> DemographicsReports { get; set; }
        public DbSet<EDMEntities.Models.Custom.DemographicsReportContent> DemographicsReportContent { get; set; }
        public DbSet<EDMEntities.Models.Custom.DemographicsReportSection> DemographicsReportSections { get; set; }
        public DbSet<EDMEntities.Models.Custom.DemographicsAgeGroup> DemographicsAgeGroups { get; set; }
        public DbSet<EDMEntities.Models.Custom.DemographicsLanguage> DemographicsLanguages { get; set; }
        public DbSet<EDMEntities.Models.Custom.DemographicsProjectedParticipation> DemographicsProjectedParticipation { get; set; }
        public DbSet<EDMEntities.Models.Custom.DemographicsPopulation> DemographicsPopulation { get; set; }
        public DbSet<EDMEntities.Models.Custom.DemographicsProjectedPopulation> DemographicsProjectedPopulation { get; set; }
        public DbSet<EDMEntities.Models.Custom.DemographicsRegionPopulation> DemographicsRegionPopulation { get; set; }

        public DbSet<EDMEntities.Models.RatingThisToolResult> RatingThisToolResult { get; set; }

        #endregion ---- EDM Models --------------------------------------------------------

        #region ---- Navigator Models --------------------------------------------------------

        public DbSet<EDMEntities.Navigator.Models.Industry> Industries { get; set; }
        public DbSet<EDMEntities.Navigator.Models.Month> Months { get; set; }
        public DbSet<EDMEntities.Navigator.Models.Snapshot> Snapshots { get; set; }
        public DbSet<EDMEntities.Navigator.Models.SnapshotSection> SnapshotSections { get; set; }
               
        public DbSet<EDMEntities.Navigator.Models.ExtendedSnapshot> ExtendedSnapshots { get; set; }
        public DbSet<EDMEntities.Navigator.Models.ExtendedSnapshotSection> ExtendedSnapshotSections { get; set; }
        public DbSet<EDMEntities.Navigator.Models.ExtendedMonth> ExtendedMonths { get; set; }       

        


        #endregion ---- Navigator Models --------------------------------------------------------

        #region ---- Blueprint Builder Models --------------------------------------------------------
        
        public DbSet<EDMEntities.BlueprintBuilder.Models.User> Users { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.Blueprint> Blueprints { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.Category> Categories { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.Tool> Tools { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.Resource> Resources { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.CareerCompassResult> CareerCompassResults { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.CareerSuggestion> CareerSuggestions { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.CareerIndustry> CareerIndustries { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.EmailTemplate> EmailTemplates { get; set; }
        public DbSet<EDMEntities.BlueprintBuilder.Models.Notification> Notifications { get; set; }

        #endregion ---- Blueprint Builder Models --------------------------------------------------------

        #region  ---- COLC Models --------------------------------------------------------

        public DbSet<EDMEntities.COLC.Models.COLC_Occupation> COLC_Occupations { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_RegionalDetail> COLC_RegionalDetails { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_ConsumableHealthExpense> COLC_ConsumableHealthExpenses { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_DownPaymentLevel> COLC_DownPaymentLevels { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_HousingExpense> COLC_HousingExpenses { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_Location> COLC_Locations { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_LocationType> COLC_LocationTypes { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_MileagePerYear> COLC_MileagePerYears { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_OwnIndicator> COLC_OwnIndicators { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_SalaryLevel> COLC_SalaryLevels { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_SqFtLevel> COLC_SqFtLevels { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_Tax> COLC_Taxes { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_TaxType> COLC_TaxTypes { get; set; }
        public DbSet<EDMEntities.COLC.Models.COLC_TransportationExpense> COLC_TransportationExpenses { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region ---- EDM Model Mappings ---------------------------------------

            modelBuilder.Configurations.Add(new CareerProfileMap());
            modelBuilder.Configurations.Add(new IndustryProfileMap());
            modelBuilder.Configurations.Add(new IndustryProfileImpactMap());
            modelBuilder.Configurations.Add(new RelatedDocumentMap());
            modelBuilder.Configurations.Add(new RelatedSourceMap());
            modelBuilder.Configurations.Add(new FYF_ArchetypeMap());
            modelBuilder.Configurations.Add(new FYF_ArchetypeRelatedIndustryMap());
            modelBuilder.Configurations.Add(new FYF_ClassMap());
            modelBuilder.Configurations.Add(new FYF_QuizQuestionMap());
            modelBuilder.Configurations.Add(new FYF_QuizSubjectMap());
            modelBuilder.Configurations.Add(new FYF_RelatedIndustryGroupMap());
            modelBuilder.Configurations.Add(new FYF_SubjectMap());
            modelBuilder.Configurations.Add(new FYF_LifestyleQuestionMap());
            modelBuilder.Configurations.Add(new FYF_LifestyleQuestionResponseOptionMap());
            modelBuilder.Configurations.Add(new FYF_LifestyleQuestionResponseOptionLocationScoreMap());
            modelBuilder.Configurations.Add(new FYF_LogLifestyleQuestionResultMap());
            modelBuilder.Configurations.Add(new FYF_LogQuizCareerResultMap());
            modelBuilder.Configurations.Add(new FYF_LogQuizClassResultMap());
            modelBuilder.Configurations.Add(new FYF_LogQuizLocationResultMap());
            modelBuilder.Configurations.Add(new FYF_LogQuizIndustryResultMap());
            modelBuilder.Configurations.Add(new FYF_LogQuizResultMap());
            modelBuilder.Configurations.Add(new FYF_CareerQuizQuestionMap());
            modelBuilder.Configurations.Add(new FYF_CareerQuizAnswerMap());
            modelBuilder.Configurations.Add(new FYF_LogQuizCareerQuizResultMap());
            modelBuilder.Configurations.Add(new FYF_AbilityMap());
            modelBuilder.Configurations.Add(new FYF_WorkPreferenceMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new RegionalProfileMap());
            modelBuilder.Configurations.Add(new CareerSkillMap());
            modelBuilder.Configurations.Add(new CareerProfileSkillMap());
            modelBuilder.Configurations.Add(new DataViewCareerProfileMap());
            modelBuilder.Configurations.Add(new DataViewCareerProfileExpectedOutlookByRegionMap());
            modelBuilder.Configurations.Add(new DataViewCareerProfileTopIndustriesByEmploymentMap());            
            modelBuilder.Configurations.Add(new DataViewCareerProfileJobUnemploymentOutlookMap());
            modelBuilder.Configurations.Add(new DataViewCareerProfileJobOpeningsOutlookMap());
            modelBuilder.Configurations.Add(new DataViewCareerProfileForecastedEmploymentMap());
            modelBuilder.Configurations.Add(new DataViewTopOccupationMap());            
            modelBuilder.Configurations.Add(new DataViewTopLNGOccupationMap());
            modelBuilder.Configurations.Add(new DataViewTopHealthOccupationMap());
            modelBuilder.Configurations.Add(new NAICSMap());
            modelBuilder.Configurations.Add(new NAICSCodesMap());
            modelBuilder.Configurations.Add(new NOCMap());
            modelBuilder.Configurations.Add(new NOCGroupTypeMap());
            modelBuilder.Configurations.Add(new NOCJobTitlesMap());
            modelBuilder.Configurations.Add(new NOCSkillLevelDemandOutlookMap());
            modelBuilder.Configurations.Add(new WBC_CatchmentAreaMap());
            modelBuilder.Configurations.Add(new WBC_ProvinceMap());
            modelBuilder.Configurations.Add(new WBC_ServicesCentreMap());
            modelBuilder.Configurations.Add(new WBC_ServicesCentreContractorMap());
            modelBuilder.Configurations.Add(new CareerProfileDetailViewMap());
            modelBuilder.Configurations.Add(new CareerProfilesGeneralDetailsViewMap());
            modelBuilder.Configurations.Add(new IndustryProfileViewMap());
            modelBuilder.Configurations.Add(new IndustryProfileImpactViewMap());
            modelBuilder.Configurations.Add(new IndustryProfileRelatedSourceViewMap());
            modelBuilder.Configurations.Add(new IndustrySnapshotLatestViewMap());
            modelBuilder.Configurations.Add(new IndustryProfileRelatedDocumentViewMap());
            modelBuilder.Configurations.Add(new IndustryProfileCommonOccupationViewMap());
            modelBuilder.Configurations.Add(new IndustryRegionalShareOfProvincialEmploymentViewMap());
            modelBuilder.Configurations.Add(new RegionalEmploymentPercentageAllOccupationsViewMap());
            modelBuilder.Configurations.Add(new RegionalProfileDetailMap());
            modelBuilder.Configurations.Add(new RegionalDistrictMap());
            modelBuilder.Configurations.Add(new RegionalAgeDistributionMap());
            modelBuilder.Configurations.Add(new RegionalEmploymentMap());
            modelBuilder.Configurations.Add(new RegionalIndustryDetailMap());
            modelBuilder.Configurations.Add(new RegionalUnemploymentRatekMap());
            modelBuilder.Configurations.Add(new RegionalOccupationOutlookMap());
            modelBuilder.Configurations.Add(new RegionalExpectedHighGrowthOccupationMap());
            modelBuilder.Configurations.Add(new RegionalIndustryOutlookMap());
            modelBuilder.Configurations.Add(new RegionalTopIndustriesByJobOpeningsMap());
            modelBuilder.Configurations.Add(new LocationRegionViewMap());
            modelBuilder.Configurations.Add(new DataPointCareerMap());
            modelBuilder.Configurations.Add(new DataPointIndustryMap());
            modelBuilder.Configurations.Add(new DataPointLocationMap());
            modelBuilder.Configurations.Add(new DataViewCareerProfileRegionalEmploymentMap());
            modelBuilder.Configurations.Add(new DataViewCareerProfileRegionalOutlookMap());
            modelBuilder.Configurations.Add(new ViewMinorGroupMap());
            modelBuilder.Configurations.Add(new EDM_EduPlannerNocMap());
            //modelBuilder.Configurations.Add(new EDM_EduPlannerProgramMap());
            modelBuilder.Configurations.Add(new EDM_EduPlannerSubjectAreaMap());
            modelBuilder.Configurations.Add(new EDM_EduPlannerFieldMap());
            modelBuilder.Configurations.Add(new CareerProfileInYourLanguageMap());
            modelBuilder.Configurations.Add(new CareerLicensingMap());
            modelBuilder.Configurations.Add(new CareerProfileBecomingQualifiedMap());
            modelBuilder.Configurations.Add(new CareerProfileCareerTrekVideosMap());
            modelBuilder.Configurations.Add(new CareerProfileWorkRelatedSkillMap());
            modelBuilder.Configurations.Add(new CareerProfileSkillDefinitionMap());
            modelBuilder.Configurations.Add(new ViewCareerProfileWorkRelatedSkillMap());
            modelBuilder.Configurations.Add(new CareerProfileWorkedRelatedSkillsSourceMap());
            modelBuilder.Configurations.Add(new CareerProfileWorkRelatedSkillsFileMap());
            modelBuilder.Configurations.Add(new RatingThisToolResultMap());

            // new High Opportunity Occupation objects
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.HOOReportMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.HOOReportContentMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.HOOReportSectionMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.HOOLMIndicatorsMap());
                       
            //Demographics report objects
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsReportMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsReportSectionMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsReportContentMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsAgeGroupMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsLanguageMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsProjectedParticipationMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsPopulationMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsProjectedPopulationMap());
            modelBuilder.Configurations.Add(new EDMEntities.Models.Mapping.DemographicsRegionPopulationMap());

            #endregion ---- EDM Model Mappings ---------------------------------------

            #region ---- Navigator Model Mappings ---------------------------------------

            modelBuilder.Configurations.Add(new EDMEntities.Navigator.Models.Mapping.IndustryMap());
            modelBuilder.Configurations.Add(new EDMEntities.Navigator.Models.Mapping.MonthMap());           
            modelBuilder.Configurations.Add(new EDMEntities.Navigator.Models.Mapping.SnapshotMap());
            modelBuilder.Configurations.Add(new EDMEntities.Navigator.Models.Mapping.SnapshotSectionMap());            

            // extended snapshot objects
            modelBuilder.Configurations.Add(new EDMEntities.Navigator.Models.Mapping.ExtendedMonthMap());
            modelBuilder.Configurations.Add(new EDMEntities.Navigator.Models.Mapping.ExtendedSnapshotMap());
            modelBuilder.Configurations.Add(new EDMEntities.Navigator.Models.Mapping.ExtendedSnapshotSectionMap());            
                       
            #endregion ---- Navigator Model Mappings ---------------------------------------

            #region    ---- Blueprint Builder Models ---------------------------------------

            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.BlueprintMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.UserMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.CategoryMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.ToolMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.ResourceMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.CareerCompassResultMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.CareerSuggestionMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.CareerIndustryMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.EmailTemplateMap());
            modelBuilder.Configurations.Add(new EDMEntities.BlueprintBuilder.Models.Mapping.NotificationMap());
            #endregion

            #region  ---- COLC Models --------------------------------------------------------

            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_OccupationMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_RegionalDetailMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_ConsumableHealthExpenseMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_DownPaymentLevelMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_HousingExpenseMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_LocationMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_LocationTypeMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_MileagePerYearMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_OwnIndicatorMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_SalaryLevelMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_SqFtLevelMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_TaxMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_TaxTypeMap());
            modelBuilder.Configurations.Add(new EDMEntities.COLC.Models.Mapping.COLC_TransportationExpenseMap());

            #endregion
            
        }
    }
}
