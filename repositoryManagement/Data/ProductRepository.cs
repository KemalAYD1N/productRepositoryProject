using System;
using System.Collections.Generic;
using System.Linq;
using repositoryManagement.Models;

namespace repositoryManagement.Data
{
    public static class ProductRepository
    {
        public static int totalStock { get; set; } = 0 ;    //  depolardaki toplam ürün sayısı
        private static List<Product> _product = new List<Product>();    //  ürünlerin tutulacağı liste
        //ürün eklenir
        static ProductRepository()
        {
           // _product = new List<Product>
            //{
                // new Product {ProductId=1, Name = "Iphone 6", Price = 3000, Description = "telefon", IsApproved = true, ImageUrl="1.png", CategoryId=1},
                // new Product {ProductId=2, Name = "Iphone 7", Price = 4000, Description = "iyi telefon", IsApproved = false, ImageUrl="2.png", CategoryId=1},
                // new Product {ProductId=3, Name = "Iphone 8", Price = 5000, Description = "çok iyi telefon", IsApproved = true, ImageUrl="3.png", CategoryId=1},
                // new Product {ProductId=4, Name = "Iphone 10", Price = 6000, Description = "en iyi telefon", ImageUrl="4.png", CategoryId=1},
                // new Product {ProductId=5, Name = "Lenova 6", Price = 3000, Description = "bilgisayar", IsApproved = true, ImageUrl="1.png", CategoryId=2},
                // new Product {ProductId=6, Name = "Lenova 7", Price = 4000, Description = "iyi bilgisayar", IsApproved = false, ImageUrl="2.png", CategoryId=2},
                // new Product {ProductId=7, Name = "Lenova 8", Price = 5000, Description = "çok iyi bilgisayar", IsApproved = true, ImageUrl="3.png", CategoryId=2},
                // new Product {ProductId=8, Name = "Lenova 10", Price = 6000, Description = "en iyi bilgisayar", ImageUrl="4.png", CategoryId=2}
                
                /*new Product {Name = "Iphone 6", Price = 3000, Description = "telefon", IsApproved = true, ImageUrl = "1.png", CategoryId = 1, productCode = 1},
                new Product {Name = "Iphone 6", Price = 3000, Description = "telefon", IsApproved = true, ImageUrl = "1.png", CategoryId = 1, productCode = 1},
                new Product {Name = "Iphone 7", Price = 4000, Description = "iyi telefon", IsApproved = false, ImageUrl="2.png", CategoryId=1, productCode = 11},
                new Product {Name = "Iphone 8", Price = 5000, Description = "çok iyi telefon", IsApproved = true, ImageUrl="3.png", CategoryId=1, productCode = 111},
                new Product {Name = "Iphone 10", Price = 6000, Description = "en iyi telefon", ImageUrl="4.png", CategoryId=1, productCode = 1111},
                new Product {Name = "Lenova 6", Price = 3000, Description = "bilgisayar", IsApproved = true, ImageUrl="1.png", CategoryId=2, productCode = 11111},
                new Product {Name = "Lenova 7", Price = 4000, Description = "iyi bilgisayar", IsApproved = false, ImageUrl="2.png", CategoryId=2, productCode = 111111},
                new Product {Name = "Lenova 8", Price = 5000, Description = "çok iyi bilgisayar", IsApproved = true, ImageUrl="3.png", CategoryId=2, productCode = 1111111},
                new Product {Name = "Lenova 10", Price = 6000, Description = "en iyi bilgisayar", ImageUrl="4.png", CategoryId=2, productCode = 11111111}*/

                var p = new Product{ProductStockName = "apple", Name = "Iphone 6", Price = 3000, Description = "telefon", IsApproved = true, ImageUrl = "1.png", CategoryId = 1, productCode = 1};
                AddProduct(p);
                p = new Product {ProductStockName = "apple", Name = "Iphone 6", Price = 3000, Description = "telefon", IsApproved = true, ImageUrl = "1.png", CategoryId = 1, productCode = 1};
                AddProduct(p);
                p = new Product {ProductStockName = "apple", Name = "Iphone 7", Price = 4000, Description = "iyi telefon", IsApproved = false, ImageUrl = "2.png", CategoryId = 1, productCode = 11};
                AddProduct(p);
                p = new Product {ProductStockName = "apple", Name = "Iphone 8", Price = 5000, Description = "çok iyi telefon", IsApproved = true, ImageUrl = "3.png", CategoryId = 1, productCode = 111};
                AddProduct(p);
                p = new Product {ProductStockName = "apple", Name = "Iphone 10", Price = 6000, Description = "en iyi telefon", IsApproved = true, ImageUrl = "4.png", CategoryId = 1, productCode = 1111};
                AddProduct(p);
                p = new Product {ProductStockName = "lenova", Name = "Lenova 6", Price = 3000, Description = "bilgisayar", IsApproved = true, ImageUrl = "8.png", CategoryId = 2, productCode = 5};
                AddProduct(p);
                p = new Product {ProductStockName = "lenova", Name = "Lenova 7", Price = 4000, Description = "iyi bilgisayar", IsApproved = false, ImageUrl = "9.png", CategoryId = 2, productCode = 55};
                AddProduct(p);
                p = new Product {ProductStockName = "lenova", Name = "Lenova 8", Price = 5000, Description = "çok iyi bilgisayar", IsApproved = true, ImageUrl = "8.png", CategoryId = 2, productCode = 555};
                AddProduct(p);
                p = new Product {ProductStockName = "lenova", Name = "Lenova 10", Price = 6000, Description = "en iyi bilgisayar", ImageUrl = "9.png", CategoryId = 2, productCode = 5555};
                AddProduct(p);
                p = new Product {ProductStockName = "renault", Name = "Clio", Price = 180000, Description = "araba", IsApproved = true, ImageUrl = "5.png", CategoryId = 3, productCode = 2};
                AddProduct(p);
                p = new Product {ProductStockName = "volkswagen", Name = "Polo", Price = 190000, Description = "iyi araba", IsApproved = false, ImageUrl = "10.png", CategoryId = 3, productCode = 22};
                AddProduct(p);
                p = new Product {ProductStockName = "george", Name = "Hayvan Çiftliği", Price = 20, Description = "çok iyi kitap", IsApproved = true, ImageUrl = "7.png", CategoryId = 4, productCode = 3};
                AddProduct(p);
                p = new Product {ProductStockName = "falcon", Name = "F-16", Price = 15000000, Description = "en iyi uçak", ImageUrl = "6.png", CategoryId = 5, productCode = 4};
                AddProduct(p);
            //};
        }

        //  ürün listesi gönderilir.
        public static List<Product> Products{
            get{
                return _product;
            }
        }

        //  ürün eklenir.
        public static void AddProduct(Product product)
        {
            //Product.stockQuantity += 1;
            ProductRepository.totalStock += 1;
            _product.Add(product);
        }

        // id değerine göre ürün verir.
        public static Product GetProductById(int id)
        {
            //dışarıdan gönderilen id değerine eşitse ürün gönderilir.
            return _product.FirstOrDefault(p => p.ProductId == id);
        }

        //  ürün güncellenir.
        public static void EditProduct(Product product)
        {
            foreach (var p in _product)
            {
                if(p.ProductId == product.ProductId)
                {
                    p.productCode = product.productCode;
                    p.Name = product.Name;
                    p.ProductStockName = product.ProductStockName;
                    p.Price = product.Price;
                    p.ImageUrl = product.ImageUrl;
                    p.Description = product.Description;
                    p.IsApproved = product.IsApproved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

        //  ürün silinir.
        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);

            if(product != null)
            {
                _product.Remove(product);
                ProductRepository.totalStock -= 1;
                //Product.stockQuantity -= 1;
            }
        }
    
        //  getirilen ürün koduna sahip ürün sayısını verir.
        public static int stockQuantity(double productCode){

            int x = 0;

            foreach (var item in _product)
            {
                if(item.productCode == productCode)
                {
                    x++;
                }
            }
        
            return x;
        }
    }
}