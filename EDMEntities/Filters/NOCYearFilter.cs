namespace EDMEntities.Filters
{
    public class NOCYearFilter : IFilter<WorkBC_EDMContext>
    {
        public WorkBC_EDMContext DbContext { get; set; }

        private int _year;

        /// <summary>
        /// This creates a new instance of the NOCYearFilter.
        /// </summary>
        /// <param name="year">The year of NOC data to filter on. The default value is the most current data.</param>
        public NOCYearFilter(int year = 2011)
        {
            _year = year;
        }

        public void Apply()
        {
            DbContext.NOC = new FilteredDbSet<EDMEntities.Models.NOC>(DbContext, n => n.NOCYear == _year);
            DbContext.CareerProfiles = new FilteredDbSet<EDMEntities.Models.CareerProfile>(DbContext, c => c.NOC.NOCYear == _year); 
        }
    }
}
