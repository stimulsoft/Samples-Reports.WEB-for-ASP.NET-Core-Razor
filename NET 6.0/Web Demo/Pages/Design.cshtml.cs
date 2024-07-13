using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;

namespace Web_Demo.Pages
{
    public class DesignModel : PageModel
    {
        private readonly ILogger<DesignModel> _logger;

        public DesignModel(ILogger<DesignModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostGetReport(string id = "SimpleList")
        {
            // Create the report object and load data from xml file
            var report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "/Reports/" + id + ".mrt"));

            return StiNetCoreDesigner.GetReportResult(this, report);
        }

        public IActionResult OnPostSaveReport()
        {
            var report = StiNetCoreDesigner.GetReportObject(this);

            // string packedReport = report.SavePackedReportToString();
            // ...
            // The save report code here
            // ...

            // Completion of the report saving without dialog box
            return StiNetCoreDesigner.SaveReportResult(this);
        }

        public IActionResult OnGetDesignerEvent()
        {
            return StiNetCoreDesigner.DesignerEventResult(this);
        }

        public IActionResult OnPostDesignerEvent()
        {
            return StiNetCoreDesigner.DesignerEventResult(this);
        }

        public IActionResult OnPostExitDesigner(string id)
        {
            return RedirectToPage("View", new { id });
        }
    }
}