using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;

namespace TechTest01.Web.Controllers
{
    public class HomeController : Controller
    {
        private string APIDomain = ConfigurationManager.AppSettings["APIDomain"]; 

        // GET: Home
        public async Task<ActionResult> Index()
        {
            IEnumerable<Product> products = null;

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri();
                try
                {
                    var response = await client.GetAsync($"{APIDomain}/api/products");

                   //Impelment restsharp
                   //Implement Service layer to encapsulate REST request.
                }
                catch (Exception ex)
                {
                    //Implement logger functionality here
                }
            }


            return View(products);
        }


    }
}