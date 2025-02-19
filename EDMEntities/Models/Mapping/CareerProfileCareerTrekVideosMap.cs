using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EDMEntities.Models.Mapping
{
    public class CareerProfileCareerTrekVideosMap : EntityTypeConfiguration<CareerProfileCareerTrekVideos>
    {
        public CareerProfileCareerTrekVideosMap()
        {
            HasKey(t => t.CareerTrekVideosID);

            ToTable("EDM_CareerProfileCareerTrekVideos");

            //Property(t => t.CareerProfileID).HasColumnName("CareerProfileID");

            Property(t => t.CareerTrekVideoID).HasColumnName("CareerTrekVideoID");
            Property(t => t.CareerTrekVideoTitle).HasColumnName("CareerTrekVideoTitle");
            Property(t => t.CareerTrekVideoTimeStamp).HasColumnName("CareerTrekVideoTimeStamp");
            Property(t => t.CareerTrekVideoImgUrl).HasColumnName("CareerTrekVideoImgUrl");
            Property(t => t.CareerTrekVideoImgAltText).HasColumnName("CareerTrekVideoImgAltText");
            Property(t => t.CareerTrekVideoPosition).HasColumnName("CareerTrekVideoPosition");

            HasRequired(t => t.CareerProfile)
                    .WithMany(t => t.CareerProfileCareerTrekVideos)
                    .HasForeignKey(d => d.CareerProfileID);
        }
    }
}
