using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTest01.Web.Helpers.Abstracts
{
    public interface IRestApiHelper
    {
        dynamic GetRequest(string endpoint);
    }
}
