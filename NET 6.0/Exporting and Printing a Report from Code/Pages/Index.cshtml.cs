using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;

namespace Exporting_and_Printing_a_Report_from_Code.Pages
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

        private StiReport GetReport()
        {
            var reportPath = StiNetCoreHelper.MapPath(this, "Reports/TwoSimpleLists.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            return report;
        }

        public IActionResult OnGetPrintPdf()
        {
            var report = this.GetReport();
            return StiNetCoreReportResponse.PrintAsPdf(report);
        }

        public IActionResult OnGetPrintHtml()
        {
            var report = this.GetReport();
            return StiNetCoreReportResponse.PrintAsHtml(report);
        }

        public IActionResult OnGetExportPdf()
        {
            var report = this.GetReport();
            return StiNetCoreReportResponse.ResponseAsPdf(report);
        }

        public IActionResult OnGetExportHtml()
        {
            var report = this.GetReport();
            return StiNetCoreReportResponse.ResponseAsHtml(report);
        }

        public IActionResult OnGetExportXls()
        {
            var report = this.GetReport();
            return StiNetCoreReportResponse.ResponseAsXls(report);
        }
    }
}