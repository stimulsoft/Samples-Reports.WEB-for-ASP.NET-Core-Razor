using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Web;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace Configuring_Report_caching.Pages
{
    public class StiFileCacheHelper : StiCacheHelper
    {
        public override StiReport GetReport(string guid)
        {
            var path = Path.Combine(HttpContext.Server.MapPath("CacheFiles"), guid);
            if (File.Exists(path))
            {
                var report = new StiReport();
                var packedReport = File.ReadAllText(path);
                if (guid.EndsWith(GUID_ReportTemplate)) report.LoadPackedReportFromString(packedReport);
                else report.LoadPackedDocumentFromString(packedReport);

                return report;
            }
            return null;
        }

        public override void SaveReport(StiReport report, string guid)
        {
            var packedReport = guid.EndsWith(GUID_ReportTemplate) ? report.SavePackedReportToString() : report.SavePackedDocumentToString();
            var path = Path.Combine(HttpContext.Server.MapPath("CacheFiles"), guid);
            File.WriteAllText(path, packedReport);
        }

        public override void RemoveReport(string guid)
        {
            var path = Path.Combine(HttpContext.Server.MapPath("CacheFiles"), guid);
            if (File.Exists(path))
                File.Delete(path);
        }
    }

    public class FileCacheModel : PageModel
    {
        private readonly ILogger<FileCacheModel> _logger;

        public FileCacheModel(ILogger<FileCacheModel> logger)
        {
            _logger = logger;

            StiNetCoreViewer.CacheHelper = new StiFileCacheHelper();
        }

        static FileCacheModel()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostGetReport()
        {
            var report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "Reports/TwoSimpleLists.mrt"));
            return StiNetCoreViewer.GetReportResult(this, report);
        }

        public IActionResult OnGetViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }

        public IActionResult OnPostViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }
    }
}