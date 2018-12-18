using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDemoJoensuu.Models;

//Päivä 11. Harjoitus: oman kontrollerin lisääminen
namespace WebDemoJoensuu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //Haetaan Customers tiedot tietokannasta
        public List<Customers> GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            List<Customers> asiakkaat = context.Customers.ToList();
            return asiakkaat;
        }

        //Haetaan yhden Customers tiedot tietokkannasta 
        //IdCusromers avaimen avulla
        [Route("{key}")]
        public Customers GetSingle(String key)
        {

            NorthwindContext context = new NorthwindContext();
            Customers asiakkas = context.Customers.Find(key);
            return asiakkas;
        }

        //Lisätään customer Customers tietokantaan
        [HttpPost]
        public String PostCreateNew([FromBody] Customers customer)
        {
            NorthwindContext context = new NorthwindContext();
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer.CustomerId;
        }

        //Customers muokkaus
        [HttpPut]
        [Route("{key}")]
        public String PutEdit( String key, [FromBody] Customers newData)
        {
            NorthwindContext context = new NorthwindContext();
            Customers asiakas = context.Customers.Find(key);
            if (asiakas != null)
            {
                asiakas.CompanyName = newData.CompanyName;
                asiakas.ContactName = newData.ContactName;
                asiakas.ContactTitle = newData.ContactTitle;
                asiakas.Address = newData.Address;
                asiakas.Phone = newData.Phone;
                asiakas.Fax = newData.Fax;

                context.SaveChanges();
                return "OK";
            }

            
            return "NOT FOUND";
        }


        //Customers Poisto IdCustomersin tiedon avulla
        [HttpDelete]
        [Route("{key}")]
        public String DeleteSingle(String key)
        {

            NorthwindContext context = new NorthwindContext();
            Customers asiakas = context.Customers.Find(key);
            if (asiakas != null)
            {
                context.Customers.Remove(asiakas);
                context.SaveChanges();
                return "DELETE";
            }
            return "NOT FOUND";
        }
    }
        
    }
