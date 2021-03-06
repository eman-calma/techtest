using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;
using TechTest01.Web.Helpers.Abstracts;

namespace TechTest01.Web.Controllers
{
    public class HomeController : Controller
    {
        private string APIDomain = ConfigurationManager.AppSettings["APIDomain"];
        private IRestApiHelper _restApiHelper;

        public HomeController(IRestApiHelper restApiHelper)
        {
            _restApiHelper = restApiHelper;
        }

        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Product> products = null;

            try
            {
                var getProducts = $"{APIDomain}/api/products";
                   
                products = JsonConvert.DeserializeObject<IEnumerable<Product>>(_restApiHelper.GetRequest(getProducts));
                   
            }
            catch (Exception ex)
            {
                //Implement logger functionality here
            }

            return View(products.OrderBy(r => Guid.NewGuid()).Take(2));
        }


    }
}