using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public partial class FYF_WorkPreferenceMap : EntityTypeConfiguration<FYF_WorkPreference>
    {
        public FYF_WorkPreferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.QuizID);
            this.ToTable("FYF_WorkPreference", "fyf");
            this.Property(t => t.Noc).HasColumnName("Noc").IsRequired().IsUnicode(false).HasMaxLength(4);
            this.Property(t => t.Code).HasColumnName("Code").IsRequired().IsUnicode(false).HasMaxLength(3);
            this.Property(t => t.QuizID).HasColumnName("QuizID");
        }
    }
}
