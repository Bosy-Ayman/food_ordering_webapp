using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class PaymentModel : PageModel
    {
        private readonly ILogger<PaymentModel> _logger;
        private readonly DB dB;
        public PaymentModel(ILogger<PaymentModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
    }
}
