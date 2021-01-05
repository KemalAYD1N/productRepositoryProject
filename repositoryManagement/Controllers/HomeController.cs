using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using repositoryManagement.Data;
using repositoryManagement.Models;

namespace repositoryManagement.Controllers
{
    //model ile view arasındaki ilişkiyi kontrol eder.
    public class HomeController:Controller
    {
        public IActionResult Index()    //Index sayfası
        {
            //index'e Product sınıfını aktarmak için kullanılır.
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };
            //productViewModel içerisinde Products sınıfı Index'e gönderilir.
            return View(productViewModel);
        }
    
        // public IActionResult About()
        // {
        //     return View();
        // }
        
        // public IActionResult Contact()
        // {
        //     return View("MyView");
        // }
    }
}