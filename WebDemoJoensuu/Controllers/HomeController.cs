﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDemoJoensuu.Models;

namespace WebDemoJoensuu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult OmaTesti()
        {
            return Content("Hello, World!");
            
        }
        public IActionResult TietokantaTesti()
        {
            StringBuilder teksti = new StringBuilder();

            NorthwindContext malli = new NorthwindContext();

            List<Customers> suomalaiset = (from c in malli.Customers
                                           where c.Country == "Finland"
                                           orderby c.CompanyName
                                           select c).ToList();
            foreach (Customers asiakas in suomalaiset)
            {
                teksti.AppendLine(asiakas.CompanyName);
            }
            return Content(teksti.ToString());
        }
        
    }
}
