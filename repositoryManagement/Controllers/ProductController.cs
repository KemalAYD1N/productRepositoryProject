using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using repositoryManagement.Data;
using repositoryManagement.Models;

namespace repositoryManagement.Controllers
{
    //  model ile view arasındaki ilişkiyi kontrol eder.
    public class ProductController : Controller
    {
        /*public IActionResult Index()
        {
            var product = new Product { Name = "ıphone", Price = 6000, Description = "güzel telefon" };

            ViewData["Category"] = "Telefonlar";
            ViewData["Product"] = product;

            return View();
        }*/

        //  localhost:5000/product/list -> tüm ürünler listelenir.        
        public IActionResult list(int? id, string q)  //  "?" ->parametre değer almaz ise null'dır.
        {

            ViewBag.tStock = ProductRepository.totalStock;
            ViewBag.tRepository = CategoryRepository.totalRepository;

            var products = ProductRepository.Products; //   depodaki ürünler alınır.

            if(id != null)  //  id değeri boş değilse
            {
                // "Where" filtreleme komutu
                products = products.Where(p => p.CategoryId == id).ToList();    // products içerisine id değeri girilen id ye eşit olanlar alınır.
            }
            //  aranan kelime url üzerinden alınır.ürün ismi veya açıklaması kısımlarında var ise ürün getirilir.
            //  q stringi boş değil ise koşula girer
            if(!string.IsNullOrEmpty(q))
            {
                //  sorgulama yapılır. istenirse arama bölgeleri arttırılabilir.
                products = products.Where( i => i.Name.Contains(q) || i.Description.Contains(q) ).ToList(); //  ürün name veya description kısımlarında q stringi var ise ürün getirilir.
            }

            //  ürünler productViewModel ile view'e gönderilir.
            var productViewModel = new ProductViewModel()
            {
                //  ürün listesi alınır.
                Products = products
            };

            return View(productViewModel);
        }
        
        //  localhost:5000/product/details
        //  ürün detayları
        public IActionResult Details(int id)
        {
            var p = ProductRepository.GetProductById(id);
            ViewBag.stockQuantity = ProductRepository.stockQuantity((double)p.productCode);    // id bilgisi üzerinden ürünün stok sayısı alınır.
            //  detaylı görüntülenecek ürün bilgileri detail sayfasına gönderilir.
            return View( ProductRepository.GetProductById(id) );
        }

        //  ürün eklenir.
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");

            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            //  ürün kayıt işleminde hata kontrolü yapılır.
            if(ModelState.IsValid)
            {
                ProductRepository.AddProduct(p);    //  ürün depoya eklenir
            
                return RedirectToAction("list");    //  kayıt işlemi yapıldıktan sonra ürün listeleme sayfası getirilir.
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");

            return View(p);            
        }

        //  ürün güncellenir
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");

            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            ProductRepository.EditProduct(p);

            return RedirectToAction("list");
        }

        //  ürün silinir
        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            ProductRepository.DeleteProduct(ProductId);

            return RedirectToAction("list");
        }

        //  yeni depo oluşturulur
        [HttpGet]
        public IActionResult CreateRepository()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRepository(Category c)
        {
            if(ModelState.IsValid)
            {
                CategoryRepository.AddCategory(c);

                return RedirectToAction("list");
            }    
            
            return View(c);
        }
    }
}