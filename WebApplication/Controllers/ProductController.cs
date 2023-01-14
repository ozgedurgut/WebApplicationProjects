using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.Models.ViewModels;

namespace WebApplication.Controllers
{
    // controllerlar gelen requestları karşılar, actionlar ise bu requestler gereği gerekli operasyonları tetikleyen fonksiyonlardır.
    public class ProductController : Controller
    {
        public IActionResult ListProducts() {
            var products = new List<Product>
            {
                new Product{Id = 1, ProductName = "Product A", Quantity = 10},
                new Product{Id = 2, ProductName = "Product B", Quantity = 15},
                new Product{Id = 3, ProductName = "Product C", Quantity = 20}
            };
           // ViewData["products"] = products;

            string data = JsonSerializer.Serialize(products);
            TempData["products"] = data;

            return RedirectToAction("Index2","Product"); 
        }

        public IActionResult Index2() {
            //var v1 = ViewBag.products;
            //var v2 = ViewData["products"];
            //var v3 = TempData["products"];

            var data = TempData["products"].ToString();
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);
            return View();
        }

        public IActionResult GetProducts() 
        {
            Product product = new Product
            {
                Id = 1,
                ProductName = "Product A",
                Quantity = 18
            };
            User user = new User()
            {
                Id = 1,
                Name = "Ozge",
                Surname = "Durgut"
            };
            /*
            UserProduct userProduct = new UserProduct
            {
                User = user,
                Product = product
            };
            */

            var userProduct = (product, user);

            return View(userProduct);
        }

        /*
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
        */
        public JsonResult JsonProducts()
        {
            JsonResult result = Json(new Product
            {
                Id = 8,
                ProductName = "Necklace",
                Quantity = 25,
            });
            return result;
        }
        /////////////////////////////////////////////
        /*
        public ViewResult GetProducts() {
            ViewResult result = View();
        }
        // GetProducts isimli isimli view dosyasını view olarak döndürür
        */
        /////////////////////////////////////////////
        /*
        public PartialViewResult GetProducts()
        {
            // PartialViewResult : client tabanlı yapılan Ajax isteklerinde kullanıma yatkın
            PartialViewResult result = PartialView();
            return result;
        }*/
        /////////////////////////////////////////////


        ////////////////////////////////////////////
        /*
        public EmptyResult GetProducts()
        {
            //response var ama result yok 
            return new EmptyResult();
        }
        */
        ///////////////////////////////////////////
        /*
        public ContentResult GetProducts()
        {
            // client tabanlı işlemlerde tercih edilir
            // text olarak döndürür
            ContentResult result = Content("your only limit is your mind");
            return result;
        }
        */
        ///////////////////////////////////////////
    }
}
