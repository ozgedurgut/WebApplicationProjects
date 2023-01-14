using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            Product product = new Product();

            ViewResult result = View(); // ilgili action ismiyle birebir aynı olan viewı tetikler.
            return result;
            // ViewResult result = View("viewdosyasınınadı"); 
            // ya yukarıdaki gibi ya da sadece alttaki satırı kullanarak aynı işlemi yapabiliriz.

            //return View();
            // view fonksiyonu bu actiona ait view(.cshtml) dosyasını tetikleyecektir.
        }
    }
}
