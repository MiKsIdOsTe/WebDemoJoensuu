using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDemoJoensuu.Models;

namespace WebDemoJoensuu.Controllers
{
    public class AsiakkaatController : Controller
    {
        public IActionResult Index()
        {
            NorthwindContext context = new NorthwindContext();
            List<Customers> asiakkaat = context.Customers.ToList();

            /*Aina kun mennään asiakas indexiin niin luopi uusen asiakkaan oma firma oy. Joten ei hyvä!!!
             * Customers uusi = new Customers()
            {
                CompanyName = "Oma firma Oy",
                City = "Joensuu",
                Country = "Finland"
            };
            context.Customers.Add(uusi);
            context.SaveChanges();*/

            return View(asiakkaat);
        }
        public IActionResult LuoUusi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LuoUusi(Customers uusi)
        {
            NorthwindContext context = new NorthwindContext();
            context.Customers.Add(uusi);
            context.SaveChanges();
            return View();
        }
    }
}