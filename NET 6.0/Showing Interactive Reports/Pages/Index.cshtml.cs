using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;

namespace Showing_Interactive_Reports.Pages
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

        public IActionResult OnPostGetReport(int id = 1)
        {
            // Create the report object
            var report = new StiReport();

            switch (id)
            {
                // Dynamic sorting
                case 1:
                    report.Load(StiNetCoreHelper.MapPath(this, "Reports/Sorting.mrt"));
                    break;

                // Drill down
                case 2:
                    report.Load(StiNetCoreHelper.MapPath(this, "Reports/ListOfProducts.mrt"));
                    break;

                // Collapsing
                case 3:
                    report.Load(StiNetCoreHelper.MapPath(this, "Reports/GroupWithCollapsing.mrt"));
                    break;

                // Bookmarks
                case 4:
                    report.Load(StiNetCoreHelper.MapPath(this, "Reports/ParametersSelectingCountry.mrt"));
                    break;

                // Parameters
                case 5:
                    report.Load(StiNetCoreHelper.MapPath(this, "Reports/InteractiveCharts.mrt"));
                    break;
            }

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