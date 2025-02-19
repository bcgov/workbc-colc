namespace EDMEntities.Models
{
    public partial class ViewMinorGroup
    {
        public string NOC_CODE { get; set; }
        public string NOC_TITLE { get; set; }
        public string EnglishTitle { get; set; }
        public string ParentNOC_Code { get; set; }
        public string ParentNOC_Title { get; set; }
        public int SiteID { get; set; }
    }
}
