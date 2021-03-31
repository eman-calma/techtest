using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using TechTest01.Domain.Catalog;
using TechTest01.Web.Helpers.Abstracts;

namespace TechTest01.Web.Helpers
{
    public class RestApiHelper : IRestApiHelper
    {
        public dynamic GetRequest(string endpoint)
        {
            try
            {
                var client = new RestClient(endpoint);

                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");

                IRestResponse response = client.Get(request);
                return response.Content;
            }
            catch (Exception ex)
            {
                //Implement Logger
                return null;
            }
        }
    }
}