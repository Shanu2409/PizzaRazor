using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FPizzasDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=10,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 20},

            new PizzasModel(){
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=10,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 20},

            new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=9,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 19},

            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=10,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 20},

            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=14,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 25},

            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=10,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 20},

            new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=10,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 20},

            new PizzasModel(){
                ImageTitle="Seafood",
                PizzaName="Seafood",
                BasePrice=14,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 25},

            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=10,
                TomatoSauce= true,
                Cheese= true,
                FinalPrice= 20},


        };
        public void OnGet()
        {
        }
    }
}
