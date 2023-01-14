using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetUserInputs.Controllers
{
    public class QueryProduct
    {
        public string A { get; set; }
        public string B { get; set; }
    }
    public class Model 
    { 
        public string txtValue1 { get; set; }
        public string txtValue2 { get; set; }
        public string txtValue3 { get; set; }
        public string txtValue4 { get; set; }
    }

    public class ProductController : Controller
    {
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetProduct(Model model)
        {
            return View();
        }
        public IActionResult TakeProduct(QueryProduct data)
        {
            /*
            var quearyString = Request.QueryString;
            var a = Request.Query["a"].ToString();
            var b = Request.Query["b"].ToString();
            */
            return View();
        }
    }
}
