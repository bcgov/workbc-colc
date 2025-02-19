using System;

namespace EDMEntities.Models
{
    public partial class DataViewCareerProfileJobUnemploymentOutlook
    {
        public int NOC_ID { get; set; }
        public int ParentNOC_ID { get; set; }
        public string NOCCode { get; set; }
        public Nullable<Int16> LocationID { get; set; }
        public Nullable<short> DataYear { get; set; }
        public Nullable<double> UnemploymentRate { get; set; }
        public Nullable<double> JobOpenings10Years { get; set; }
        public Nullable<double> JobOpeningsYear { get; set; }
        /// <summary>
        /// Job Openings Data Year can be different from Data Year. E.g. for Unemployment year 2021 only the job openings for 2022 were provided.
        /// </summary>
        public Nullable<short> JobOpeningsDataYear { get; set; }
    }
}
