﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechTest01.Domain.Catalog;
using TechTest01.Services.Catalog;

namespace TechTest01.Api.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("api/products")]
        [HttpGet]
        public ICollection<Product> GetContacts()
        {
            return _productService.GetProducts();
        }
    }
}