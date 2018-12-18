using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebDemoJoensuu.Controllers
{
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
    }
}