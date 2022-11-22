using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_razor_layout.Data;
using Microsoft.Extensions.Hosting;
using la_mia_pizzeria_razor_layout.Models;

namespace la_mia_pizzeria_razor_layout.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzaDbContext db = new PizzaDbContext();

            List<Pizza> listaPizza = db.Pizza.ToList();

            return View(listaPizza);
        }

        public IActionResult Detail(int id)
        {

            PizzaDbContext db = new PizzaDbContext();

            Pizza pizza = db.Pizza.Where(p => p.Id == id).FirstOrDefault();

            return View(pizza);
        }


    }

    
}

