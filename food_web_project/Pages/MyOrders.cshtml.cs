/*using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{

    public class MyOrdersModel : PageModel
    {
        private readonly ILogger<MyOrdersModel> _logger;
        private readonly DB dB;

        [BindProperty]
        public int? order_item_id { get; set; }

        [BindProperty]
        public int order_id { get; set; }

        [BindProperty]
        public int cart_id { get; set; }

        [BindProperty]
        public string users_id { get; set; }

        [BindProperty]
        public int total_price { get; set; }


        public MyOrdersModel(ILogger<MyOrdersModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
       *//* public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                total_price = dB.CalculateTotalPrice(order_id);

                if (order_id > 0)
                {
                    string order_id = dB.CalculateTotalPrice(order_id).Trim();

                    if (order_id == order_id)
                    {
                        dB.CalculateTotalPrice(order_id);

                        if (order_id == ModelBinderAttribute.order_id)
                            return RedirectToPage(new { ID = order_id });
                        else if 
                            return RedirectToPage("/the order_id is not valid", new { order_id = order_id });
                    }
                }
                ViewData["ErrorMessage"] = "Invalid order_id.";
                return Page();
            }
            return Page();
        }*//*
    }
}
*/