using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 100;
            if (Pizza.Cheese) PizzaPrice += 100;
            if (Pizza.Tuna) PizzaPrice += 100;
            if (Pizza.corn) PizzaPrice += 100;
            if (Pizza.Mushroom) PizzaPrice += 100;
            if (Pizza.Peperoni) PizzaPrice += 100;
            if (Pizza.Pineapple) PizzaPrice += 500;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
