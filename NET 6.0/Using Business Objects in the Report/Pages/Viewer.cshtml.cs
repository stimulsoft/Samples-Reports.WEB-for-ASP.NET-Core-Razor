using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;
using BusinessObjects;

namespace Using_Business_Objects_in_the_Report.Pages
{
    public class ViewerModel : PageModel
    {
        private readonly ILogger<ViewerModel> _logger;

        public ViewerModel(ILogger<ViewerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostGetReport(string id)
        {
            var report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, $"Reports/BusinessObjects_{id}.mrt"));
            switch (id)
            {
                case "IEnumerable":
                    report.RegData("EmployeeIEnumerable", CreateBusinessObjectsIEnumerable.GetEmployees());
                    break;

                case "ITypedList":
                    report.RegData("EmployeeITypedList", CreateBusinessObjectsITypedList.GetEmployees());
                    break;

                case "IEnumerable_BO":
                    report.RegBusinessObject("EmployeeIEnumerable", CreateBusinessObjectsIEnumerable.GetEmployees());
                    report.Dictionary.SynchronizeBusinessObjects(2);
                    break;

                case "ITypedList_BO":
                    report.RegBusinessObject("EmployeeITypedList", CreateBusinessObjectsITypedList.GetEmployees());
                    report.Dictionary.SynchronizeBusinessObjects(2);
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