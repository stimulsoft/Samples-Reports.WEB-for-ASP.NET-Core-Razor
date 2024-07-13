using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;

namespace Web_Demo.Pages
{
    public class ViewModel : PageModel
    {
        private readonly ILogger<ViewModel> _logger;

        public ViewModel(ILogger<ViewModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostGetReport(string id = "SimpleList")
        {
            var report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "/Reports/" + id + ".mrt"));
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

        public IActionResult OnPostDesign(string id)
        {
            return RedirectToPage("Design", new { id });
        }
    }
}