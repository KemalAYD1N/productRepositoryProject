using repositoryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using repositoryManagement.Data;

namespace repositoryManagement.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // var categories = new List<Category>()
            // {
            //     new Category { Name = "Telefon", Description = "Telefon Kategorisi" },
            //     new Category { Name = "Bilgisayar", Description = "Bilgisayar Kategorisi" },
            //     new Category { Name = "Elektronik", Description = "Elektronik Kategorisi" }
            // };

            if(RouteData.Values["action"].ToString()=="list")
                ViewBag.SelectedCategory = RouteData?.Values["id"];

            return View(CategoryRepository.Categories);
        }        
    }
}