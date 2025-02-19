using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class EDM_EduPlannerProgramMap : EntityTypeConfiguration<EDM_EduPlannerProgram>
    {
        public EDM_EduPlannerProgramMap()
        {
            // Primary Key
            this.HasKey(t => t.programID);

            // Properties
            this.Property(t => t.programAdvice)
                .IsMaxLength();
            this.Property(t => t.programADA)
                .IsMaxLength();
            this.Property(t => t.programContact)
                .IsRequired()
                .IsMaxLength();
            this.Property(t => t.programLength)
                .IsMaxLength();
            this.Property(t => t.programLocation)
                .IsMaxLength();
            this.Property(t => t.programName)
                .HasMaxLength(255);
            this.Property(t => t.programUrl)
                .IsMaxLength();
            this.Property(t => t.programAdvice)
                .HasMaxLength(System.Int32.MaxValue);
            this.Property(t => t.trainingLevel)
                .IsMaxLength();
            this.Property(t => t.trainingLocation)
                .IsMaxLength();
            this.Property(t => t.credentialLabel)
                .IsMaxLength();
            this.Property(t => t.admFeedADA)
                .IsMaxLength();
            this.Property(t => t.admFeedApply)
                .IsMaxLength();
            this.Property(t => t.admFeedApproval)
                .IsMaxLength();
            this.Property(t => t.admFeedMyComm)
                .IsMaxLength();
            this.Property(t => t.admFeedNotes)
                .IsMaxLength();
            this.Property(t => t.admFeedProvExams)
                .IsMaxLength();
            this.Property(t => t.admFeedRequirements)
                .IsMaxLength();
            this.Property(t => t.admFeedStartDate)
                .IsMaxLength();
            this.Property(t => t.admFeedTechEntry)
                .IsMaxLength();
            this.Property(t => t.admPAR)
                .IsMaxLength();
            this.Property(t => t.eboExProv)
                .IsMaxLength();
            this.Property(t => t.eboIIB)
                .IsMaxLength();
            this.Property(t => t.eboIntraInstitution)
                .IsMaxLength();
            this.Property(t => t.feeApplication)
                .IsMaxLength();
            this.Property(t => t.feeBooks)
                .IsMaxLength();
            this.Property(t => t.feeTuition)
                .IsMaxLength();
            this.Property(t => t.institutionLabel)
                .IsMaxLength();
            this.Property(t => t.isAboriginal);
            this.Property(t => t.isApprenticeship);
            this.Property(t => t.isCoop);
            this.Property(t => t.isDevelopmental);
            this.Property(t => t.isEpprentice);
            this.Property(t => t.isGraduate);
            this.Property(t => t.isPreApprenticeship);
            this.Property(t => t.isRedSeal);
            this.Property(t => t.isWorkExperience);

            // Table & Column Mappings
            this.ToTable("EDM_EduPlannerPrograms");
            this.Property(t => t.programID).HasColumnName("programID");
            this.Property(t => t.programAdvice).HasColumnName("programAdvice");
            this.Property(t => t.programADA).HasColumnName("programADA");
            this.Property(t => t.programContact).HasColumnName("programContact");
            this.Property(t => t.programLength).HasColumnName("programLength");
            this.Property(t => t.programLocation).HasColumnName("programLocation");
            this.Property(t => t.programName).HasColumnName("programName");
            this.Property(t => t.programUrl).HasColumnName("programUrl");
            this.Property(t => t.ttcProgramID).HasColumnName("ttcProgramID");
            this.Property(t => t.trainingLevel).HasColumnName("trainingLevel");
            this.Property(t => t.trainingLocation).HasColumnName("trainingLocation");
            this.Property(t => t.credentialLabel).HasColumnName("credentialLabel");
            this.Property(t => t.admFeedADA).HasColumnName("admFeedADA");
            this.Property(t => t.admFeedApply).HasColumnName("admFeedApply");
            this.Property(t => t.admFeedApproval).HasColumnName("admFeedApproval");
            this.Property(t => t.admFeedMyComm).HasColumnName("admFeedMyComm");
            this.Property(t => t.admFeedNotes).HasColumnName("admFeedNotes");
            this.Property(t => t.admFeedProvExams).HasColumnName("admFeedProvExams");
            this.Property(t => t.admFeedRequirements).HasColumnName("admFeedRequirements");
            this.Property(t => t.admFeedStartDate).HasColumnName("admFeedStartDate");
            this.Property(t => t.admFeedTechEntry).HasColumnName("admFeedTechEntry");
            this.Property(t => t.admPAR).HasColumnName("admPAR");
            this.Property(t => t.eboExProv).HasColumnName("eboExProv");
            this.Property(t => t.eboIIB).HasColumnName("eboIIB");
            this.Property(t => t.eboIntraInstitution).HasColumnName("eboIntraInstitution");
            this.Property(t => t.feeApplication).HasColumnName("feeApplication");
            this.Property(t => t.feeBooks).HasColumnName("feeBooks");
            this.Property(t => t.feeTuition).HasColumnName("feeTuition");
            this.Property(t => t.institutionLabel).HasColumnName("institutionLabel");
            this.Property(t => t.isAboriginal).HasColumnName("isAboriginal");
            this.Property(t => t.isApprenticeship).HasColumnName("isApprenticeship");
            this.Property(t => t.isCoop).HasColumnName("isCoop");
            this.Property(t => t.isDevelopmental).HasColumnName("isDevelopmental");
            this.Property(t => t.isEpprentice).HasColumnName("isEpprentice");
            this.Property(t => t.isGraduate).HasColumnName("isGraduate");
            this.Property(t => t.isPreApprenticeship).HasColumnName("isPreApprenticeship");
            this.Property(t => t.isRedSeal).HasColumnName("isRedSeal");
            this.Property(t => t.isWorkExperience).HasColumnName("isWorkExperience");

            // Relationships
            this.HasMany(t => t.EDM_EduPlannerSubjectAreas)
                .WithMany(t => t.EDM_EduPlannerPrograms)
                .Map(m =>
                {
                    m.ToTable("EDM_EduPlannerProgramsXSubjectAreas");
                    m.MapLeftKey("programID");
                    m.MapRightKey("subjectAreaID");
                });
            //this.HasMany(t => t.EDM_EduPlannerLengths)
            //    .WithMany(t => t.EDM_EduPlannerPrograms)
            //    .Map(m =>
            //    {
            //        m.ToTable("EDM_EduPlannerLengths");
            //        m.MapLeftKey("programID");
            //        m.MapRightKey("lengthID");
            //    });
        }
    }
}
