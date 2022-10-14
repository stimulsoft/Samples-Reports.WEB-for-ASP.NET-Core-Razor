using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;

namespace Using_Variables_in_the_Report.Pages
{
    public class ViewerPOSTModel : PageModel
    {
        private readonly ILogger<ViewerPOSTModel> _logger;

        public ViewerPOSTModel(ILogger<ViewerPOSTModel> logger)
        {
            _logger = logger;
        }

        static ViewerPOSTModel()
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
            report.Load(StiNetCoreHelper.MapPath(this, "Reports/Variables.mrt"));

            report.Compile();

            var formValues = StiNetCoreViewer.GetFormValues(this);
            report["Name"] = formValues["name"] ?? string.Empty;
            report["Surname"] = formValues["surname"] ?? string.Empty;
            report["Email"] = formValues["email"] ?? string.Empty;
            report["Address"] = formValues["address"] ?? string.Empty;
            report["Sex"] = formValues["sex"] != null && Convert.ToBoolean(formValues["sex"]);

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