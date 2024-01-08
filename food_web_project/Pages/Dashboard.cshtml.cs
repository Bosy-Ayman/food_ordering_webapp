using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class DashboardModel : PageModel
    {

        private readonly ILogger<DashboardModel> _logger;
        private readonly DB dB;
        public DashboardModel(ILogger<DashboardModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
    }
}
