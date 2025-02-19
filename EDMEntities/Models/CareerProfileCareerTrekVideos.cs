using System;
using Newtonsoft.Json;

namespace EDMEntities.Models
{
    [Serializable]
    public class CareerProfileCareerTrekVideos
    {
        [JsonIgnore]
        public int CareerTrekVideosID { get; set; }

        public string CareerTrekVideoID { get; set; }

        public string CareerTrekVideoTitle { get; set; }

        public string CareerTrekVideoTimeStamp { get; set; }

        public string CareerTrekVideoImgUrl { get; set; }

        public string CareerTrekVideoImgAltText { get; set; }

        public int CareerTrekVideoPosition  { get; set; }

        [JsonIgnore]
        // Relationship to the Career Profile
        public int CareerProfileID { get; set; }

        [JsonIgnore]
        public virtual CareerProfile CareerProfile { get; set; }
    }
}
