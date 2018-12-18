using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDemoJoensuu.Models;
namespace AspNetCoreBackend.Controllers
{
    /// <summary>
    /// Ensimmäine API-kontrolleri-testi
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("merkkijono")]
        public string Merkkijono()
        {
            return "Terve, Joensuu!";
        }
        [Route("päivämäärä")]
        public DateTime Päivämäärä()
        {
            return DateTime.Now;
        }
        [Route("olio")]
        public Henkilö Olio()
        {
            return new Henkilö()
            {
                Nimi = "Teppo Testaaja",
                Osoite = "Kotikatu 12 B 8",
                Ikä = 35
            };
        }
        [Route("oliot")]
        public List<Henkilö> Oliot()
        {
            List<Henkilö> henkilöt = new List<Henkilö>()
            {
                new Henkilö()
                {
                    Nimi = "Teppo Testaaja",
                    Osoite = "Kotikatu 12 B 8",
                    Ikä = 35
                },
                new Henkilö()
                {
                    Nimi = "Teija Testaaja",
                    Osoite = "Kotikatu 12 B 8",
                    Ikä = 34
                },
                new Henkilö()
                {
                    Nimi = "Matti Mekaanikko",
                    Osoite = "Mekaniikkatie 61",
                    Ikä = 45
                }
            };
            return henkilöt;
        }
    }
}
