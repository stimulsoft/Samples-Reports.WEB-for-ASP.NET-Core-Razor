using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Export;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;

namespace Managing_Report_Printing_and_Exporting.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        static IndexModel()
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
            // Create the report object
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

        public IActionResult OnPostPrintReport()
        {
            var report = StiNetCoreViewer.GetReportObject(this);

            // Some actions with report when printing

            return StiNetCoreViewer.PrintReportResult(this, report);
        }

        public IActionResult OnPostExportReport()
        {
            var report = StiNetCoreViewer.GetReportObject(this);
            var parameters = StiNetCoreViewer.GetRequestParams(this);

            // Some actions with report when exporting
            report.ReportName = "MyReportName";
            report.ReportAlias = report.ReportName;

            if (parameters.ExportFormat == StiExportFormat.Pdf)
            {
                // Change some export settings when exporting to PDF
                var settings = (StiPdfExportSettings)StiNetCoreViewer.GetExportSettings(this);
                settings.CreatorString = "My Company";

                return StiNetCoreViewer.ExportReportResult(this, report, settings);
            }

            return StiNetCoreViewer.ExportReportResult(this, report);
        }
    }
}