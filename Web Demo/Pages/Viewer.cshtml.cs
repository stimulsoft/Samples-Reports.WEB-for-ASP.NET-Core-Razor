using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Demo.Pages
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
    }
}