using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Base;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;
using StiReports;

namespace Showing_a_Report_in_the_Viewer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        static IndexModel()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostGetReport(int id = 1)
        {
            // Create the report object
            var report = new StiReport();

            // Load report
            switch (id)
            {
                // Load report snapshot
                case 1:
                    report.LoadDocument(StiNetCoreHelper.MapPath(this, "Reports/SimpleList.mdc"));
                    break;

                // Load report template
                case 2:
                    report.Load(StiNetCoreHelper.MapPath(this, "Reports/TwoSimpleLists.mrt"));
                    break;

                // Load compiled report class
                case 3:
                    report = new StiMasterDetail();
                    break;

                // Load compiled report class
                case 4:
                    report = new StiParametersSelectingCountryReport();
                    break;
            }

            // Load data from JSON file for report template
            if (!report.IsDocument)
            {
                var data = StiJsonToDataSetConverterV2.GetDataSetFromFile(StiNetCoreHelper.MapPath(this, "Data/Demo.json"));
                report.Dictionary.Databases.Clear();
                report.RegData(data);
            }

            return StiNetCoreViewer.GetReportResult(this, report);
        }

        public IActionResult OnPostViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }

        public IActionResult OnGetViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }
    }
}