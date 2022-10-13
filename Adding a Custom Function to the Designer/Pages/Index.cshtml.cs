using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Mvc;

namespace Adding_a_Custom_Function_to_the_Designer.Pages
{
    public class IndexModel : PageModel
    {
        public static string MyFunc(string value)
        {
            return value.ToUpper();
        }

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

            var ParamNames = new string[1];
            var ParamTypes = new Type[1];
            var ParamDescriptions = new string[1];

            ParamNames[0] = "value";
            ParamDescriptions[0] = "Descriptions";
            ParamTypes[0] = typeof(string);

            // How to add my function
            StiFunctions.AddFunction(
                "MyCategory",
                "MyFunc",
                "MyFunc",
                "Description",
                typeof(IndexModel),
                typeof(string),
                "Return Description",
                ParamTypes,
                ParamNames,
                ParamDescriptions);
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostGetReport()
        {
            var report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "Reports/MyTwoSimpleLists.mrt"));

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