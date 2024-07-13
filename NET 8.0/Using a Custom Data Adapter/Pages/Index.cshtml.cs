using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;

namespace Using_a_Custom_Data_Adapter.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        static IndexModel()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            //Clearing standard data adapters, if necessary
            StiOptions.Services.Databases.Clear();

            //Adding a Custom PostgreSQL data adapter
            StiOptions.Services.Databases.Add(new CustomPostgreSQLDatabase());
            StiOptions.Services.DataAdapters.Add(new CustomPostgreSQLAdapterService());
        }

        public IActionResult OnPostGetReport()
        {
            var report = new StiReport();

            //Adding a connection to the report from code
            var database = new CustomPostgreSQLDatabase("CustomData1", "Server=127.0.0.1; Port=5432; Database=myDataBase; User Id=myUsername; Password=myPassword;");
            report.Dictionary.Databases.Add(database);

            //Adding a reference to this project using a custom adapter class
            var assemblies = report.ReferencedAssemblies.ToList();
            assemblies.Add("Using_a_Custom_Data_Adapter.dll");
            report.ReferencedAssemblies = assemblies.ToArray();

            return StiNetCoreDesigner.GetReportResult(this, report);
        }

        public IActionResult OnGetDesignerEvent()
        {
            return StiNetCoreDesigner.DesignerEventResult(this);
        }

        public IActionResult OnPostDesignerEvent()
        {
            return StiNetCoreDesigner.DesignerEventResult(this);
        }
    }
}