using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    // Controller: In order to make a class request and return response, that is, to make a controller, we need to derive that class from the controller class
    public class HomeController : Controller
    {
        // Controller sınıfları içerisinde istekleri karşılayan metotlara action metot denir.
        public IActionResult Index()
        {
            return View();
        }
    }
}
