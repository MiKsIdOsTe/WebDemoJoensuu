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

            return View(asiakkaat);
        }
    }
}