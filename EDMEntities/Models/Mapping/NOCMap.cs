using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class NOCMap : EntityTypeConfiguration<NOC>
    {
        public NOCMap()
        {
            // Primary Key
            this.HasKey(t => t.NOC_ID);

            // Properties
            this.Property(t => t.NOCCode)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.NameEnglish)
                .HasMaxLength(200);

            this.Property(t => t.NameFrench)
                .HasMaxLength(200);

            this.Property(t => t.Alias)
                .HasMaxLength(200);

            this.Property(t => t.NOCS2006)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("EDM_NOC");
            this.Property(t => t.NOC_ID).HasColumnName("NOC_ID");
            this.Property(t => t.NOCCode).HasColumnName("NOCCode");
            this.Property(t => t.NameEnglish).HasColumnName("NameEnglish");
            this.Property(t => t.NameFrench).HasColumnName("NameFrench");
            this.Property(t => t.Alias).HasColumnName("EnglishShortAlias");
            this.Property(t => t.NOCS2006).HasColumnName("NOCS2006");
            this.Property(t => t.NOCGroupTypeID).HasColumnName("NOCGroupTypeID");
            this.Property(t => t.ParentNOC_ID).HasColumnName("ParentNOC_ID");
            this.Property(t => t.NOC_ID2006).HasColumnName("NOC_ID2006");
            this.Property(t => t.NOCYear).HasColumnName("NOCYear");
            this.Property(t => t.SkillLevelID).HasColumnName("SkillLevel");

            // Relationships
            this.HasOptional(t => t.ParentNOC)
                .WithMany(t => t.ChildNOCs)
                .HasForeignKey(d => d.ParentNOC_ID);
            this.HasOptional(t => t.NOC2006)
                .WithMany(t => t.NOC2011)
                .HasForeignKey(d => d.NOC_ID2006);
            this.HasOptional(t => t.NOCGroupType)
                .WithMany(t => t.NOC)
                .HasForeignKey(d => d.NOCGroupTypeID);
            this.HasOptional(t => t.SkillLevel)
                .WithMany(t => t.NOC)
                .HasForeignKey(d => d.SkillLevelID);
        }
    }
}
