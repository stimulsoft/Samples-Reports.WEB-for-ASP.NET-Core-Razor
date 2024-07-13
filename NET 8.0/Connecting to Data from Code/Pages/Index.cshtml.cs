using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;
using System.Data;

namespace Connecting_to_Data_from_Code.Pages
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
            // Loading the report template
            var reportPath = StiNetCoreHelper.MapPath(this, "Reports/TwoSimpleLists.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            // Deleting connections in the report template
            report.Dictionary.Databases.Clear();

            // Loading data from the XML file
            var dataPath = StiNetCoreHelper.MapPath(this, "Reports/Data/Demo.xml");
            var data = new DataSet();
            data.ReadXml(dataPath);

            // Registering data in the report
            report.RegData(data);

            // Syncing the data structure, if required
            //report.Dictionary.Synchronize();

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