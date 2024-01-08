using Azure;
using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace food_web_project.Pages
{
	public class IndexModel : PageModel
	{
        private readonly ILogger<IndexModel> _logger;
        private readonly DB dB;

        public IndexModel(ILogger<IndexModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }

        public void OnGet()
		{

		}
	}
}
