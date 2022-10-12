using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Demo.Pages
{
    public class DesignerModel : PageModel
    {
        private readonly ILogger<DesignerModel> _logger;

        public DesignerModel(ILogger<DesignerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}