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
        /*
        public JsonResult JsonProducts()
        {
            JsonResult result = Json(new Product 
            { 
                Id=8,
                ProductName = "Necklace",
                Quantity = 25,
            });
            return result;
        }
        */
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
