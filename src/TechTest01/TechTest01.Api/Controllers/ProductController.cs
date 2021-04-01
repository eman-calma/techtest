using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TechTest01.Domain.Catalog;
using TechTest01.Services.Catalog;

namespace TechTest01.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("api/products")]
        [HttpGet]
        public ICollection<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        [Route("api/products/{slug}")]
        [HttpGet]
        public Product GetContacts(string slug)
        {
            return _productService.GetBySlug(slug);
        }
    }
}
