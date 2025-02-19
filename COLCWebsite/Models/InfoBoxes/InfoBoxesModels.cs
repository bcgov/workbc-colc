

namespace COLC.COLCWebsite.Models.InfoBoxes
{
    /// <summary>
    /// Model for the external links in the info boxes
    /// </summary>
    public class InfoBoxesModels
    {
        public string Section { get; set; }
        public string LinkText { get; set; }
        public string LinkURL { get; set; }
        public string LinkDescription { get; set; }
        public int SortOrder { get; set; }
    }
}
