using System.Web.Configuration;
namespace ColcDataLayerWcfService.Caching
{
    public static class Constants
    {
        // Number of minutes to cache data from the database.
        public static int DATA_CACHE_MINUTES
        {
            get
            {
                int minutes;
                string webConfigMinutes = WebConfigurationManager.AppSettings["DataCacheMinutes"];

                if (!string.IsNullOrWhiteSpace(webConfigMinutes) && int.TryParse(webConfigMinutes, out minutes))
                {
                    return minutes;
                }
                else
                {
                    return 30;
                }                                  
            }
        }

        public static readonly string OCCUPATIONS = "occupations"; // for caching data from [COLC].vw_Occupation
        public static readonly string REGIONAL_DETAILS = "regionaldetails"; // for caching data from [COLC].vw_RegionalDetails
        public static readonly string LOCATIONS = "locations"; // for caching data from [COLC].COLC_Location
        public static readonly string TAXES = "taxes"; // for caching data from [COLC].COLC_Taxes      
        public static readonly string SALARY_LEVELS = "salarylevels"; // for caching data from [COLC].COLC_SalaryLevel
    }
}