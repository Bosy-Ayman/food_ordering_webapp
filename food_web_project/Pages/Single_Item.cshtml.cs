using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class Single_ItemModel : PageModel
    {
        private readonly ILogger<Single_ItemModel> _logger;
        private readonly DB dB;
        public Single_ItemModel(ILogger<Single_ItemModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
    }
}
