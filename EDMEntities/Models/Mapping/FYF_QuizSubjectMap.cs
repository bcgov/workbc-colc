using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class FYF_QuizSubjectMap : EntityTypeConfiguration<FYF_QuizSubject>
    {
        public FYF_QuizSubjectMap()
        {
            // Primary Key
            this.HasKey(t => t.QuizSubjectId);

            // Properties
            this.Property(t => t.QuizSubjectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FYF_QuizSubject", "fyf");
            this.Property(t => t.QuizSubjectId).HasColumnName("QuizSubjectId");
            this.Property(t => t.ClassId).HasColumnName("ClassId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.NAICS_ID).HasColumnName("NAICS_ID");

            // Relationships
            this.HasRequired(t => t.NAICS)
                .WithMany(t => t.FYF_QuizSubject)
                .HasForeignKey(d => d.NAICS_ID);
            this.HasRequired(t => t.FYF_Class)
                .WithMany(t => t.FYF_QuizSubject)
                .HasForeignKey(d => d.ClassId);
            this.HasRequired(t => t.FYF_RelatedIndustryGroup)
                .WithMany(t => t.FYF_QuizSubject)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
