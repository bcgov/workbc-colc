using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.Script.Serialization;

namespace COLC.COLCWebsite.Helpers
{
	public class UiAsset
  {
    public static bool debug = WebConfigurationManager.AppSettings["debug"] == "true";
    public static string uiPath = "~/UI/";
    public static string uiBuildPath = "~/UI_build/";
    public static string filerevPath = HttpContext.Current.Server.MapPath(Path.Combine(uiBuildPath, "filerev.json"));
    public static string json = File.Exists(filerevPath) ? File.ReadAllText(filerevPath) : "";
    public static JavaScriptSerializer s = new JavaScriptSerializer();
    public static Dictionary<string, string> filerev = json != "" ? s.Deserialize<Dictionary<string, string>>(json) : null;

    public string file { get; set; }
    public string filePath { get; set; }
    public string type { get; set; }
    public bool async { get; set; }
    public bool defer { get; set; }
    public string ext { get; set; }
    public Dictionary<string, string> files { get; set; }

    public UiAsset(string file, string type, bool async = false, bool defer = false, string ext = "")
    {
      this.file = file;
      this.type = type;
      this.ext = type;
      this.ext = type == "require" ? "js" : this.ext;

      this.async = async;
      this.defer = defer;

      this.filePath = this.getPath(this.file);
    }

    private string getPath(string file)
    {
      var filePathUi = uiPath + file + "." + this.ext;

      // map file revision if not in debug mode
      if (!debug)
      {
        var filePathUiBuild = uiBuildPath + file + "." + this.ext;
        var adjustedFilePathUiBuild = filePathUiBuild.Replace("~/", "");

        // try to get file revision hash and add it to the file path
        if (filerev != null && filerev.ContainsKey(adjustedFilePathUiBuild))
        {
          Regex regex = new Regex(@"[\w]*\." + this.ext + "$");
          Match match = regex.Match(filerev[adjustedFilePathUiBuild]);
          var hash = match.Value;
          filePathUi = filePathUi.Replace(this.ext, hash);
        }
      }

      return VirtualPathUtility.ToAbsolute(filePathUi);
    }

    public bool exists(string basePath = "", string variant = "")
    {
      if (basePath == "")
      {
        basePath = uiPath;
      }
      var filePath = basePath + this.file + variant + "." + this.ext;
      filePath = HttpContext.Current.Server.MapPath(filePath);
      return File.Exists(filePath);
    }
  }
}
