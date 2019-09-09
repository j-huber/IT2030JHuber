using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class ProductController : Controller
    {
        // GET /Product
        public string Index()
        {
            return "Product/Index is displayed.Index()";
        }

        // GET /Product/browse
        public string Browse()
        {
            return "Browse displayed.Index()";
        }

        // GET /Product/105
        public string Details(int id)
        {
            string message = "Product.Details, ID = " + id;
            return message;
        }

        // GET /Product/Location?zip=44124
        public string Location(string zip)
        {
            string message = HttpUtility.HtmlEncode("Products.Location, Zip = " + zip);
            return message;
        }
    }
}