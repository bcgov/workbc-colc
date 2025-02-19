using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public partial class FYF_AbilityMap : EntityTypeConfiguration<FYF_Ability>
    {
        public FYF_AbilityMap()
        {
            // Primary Key
            this.HasKey(t => t.QuizID);
            this.ToTable("FYF_Ability", "fyf");
            this.Property(t => t.Noc).HasColumnName("Noc").IsRequired().HasMaxLength(4);
            this.Property(t => t.G).HasColumnName("G");
            this.Property(t => t.V).HasColumnName("V");
            this.Property(t => t.N).HasColumnName("N");
            this.Property(t => t.S).HasColumnName("S");
            this.Property(t => t.P).HasColumnName("P");
            this.Property(t => t.Q).HasColumnName("Q");
            this.Property(t => t.K).HasColumnName("K");
            this.Property(t => t.F).HasColumnName("F");
            this.Property(t => t.M).HasColumnName("M");
            this.Property(t => t.QuizID).HasColumnName("QuizID");
        }
    }
}
