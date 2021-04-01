using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;
using TechTest01.Web.Helpers.Abstracts;

namespace TechTest01.Web.Controllers
{
    public class ProductsController : Controller
    {
        private string APIDomain = ConfigurationManager.AppSettings["APIDomain"];
        private IRestApiHelper _restApiHelper;

        public ProductsController(IRestApiHelper restApiHelper)
        {
            _restApiHelper = restApiHelper;
        }

        // GET: Product
        public ActionResult Index()
        {
            ICollection<Product> products = null;

            try
            {
                var getProducts = $"{APIDomain}/api/products";

                products = JsonConvert.DeserializeObject<ICollection<Product>>(_restApiHelper.GetRequest(getProducts));

            }
            catch (Exception ex)
            {
                //Implement logger functionality here
            }

            return View(products);
        }

        public ActionResult Product(string id)
        {
            Product product = null;

            try
            {
                var getProduct = $"{APIDomain}/api/products/{id}";
                product = JsonConvert.DeserializeObject<Product>(_restApiHelper.GetRequest(getProduct));
            }
            catch (Exception ex)
            {
                //Implement logger functionality here
            }

            return View(product);
        }
    }
}