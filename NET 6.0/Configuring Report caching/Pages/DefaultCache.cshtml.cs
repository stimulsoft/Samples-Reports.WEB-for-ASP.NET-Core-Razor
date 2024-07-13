using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Web;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace Configuring_Report_caching.Pages
{
    public class StiDefaultCacheHelper : StiCacheHelper
    {
        public override StiReport GetReport(string guid)
        {
            return base.GetReport(guid);
        }

        public override void SaveReport(StiReport report, string guid)
        {
            base.SaveReport(report, guid);
        }

        public override void RemoveReport(string guid)
        {
            base.RemoveReport(guid);
        }
    }

    public class DefaultCacheModel : PageModel
    {
        private readonly ILogger<DefaultCacheModel> _logger;

        public DefaultCacheModel(ILogger<DefaultCacheModel> logger)
        {
            _logger = logger;

            StiNetCoreViewer.CacheHelper = new StiDefaultCacheHelper();
        }

        static DefaultCacheModel()
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