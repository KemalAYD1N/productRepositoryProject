using System;
using System.Collections.Generic;
using System.Linq;
using repositoryManagement.Models;

namespace repositoryManagement.Data
{
    //  kategori deposu
    public class CategoryRepository
    {
        public static int totalRepository { get; set; } = 0 ;   //  toplam depo sayısı
        private static List<Category> _categories = new List<Category>();   //  boş kategori listesi oluşturulur

        //  CategoryRepository sınıfının constructor'ı
        static CategoryRepository() //  static sınıfın yapıcı fonksiyonu da static olmalıdır.
        {
            // _categories = new List<Category>    //  dinamik bellek alanı oluşturulur ve başlangıç için kategori bilgileri oluşturulur.
            // {
            //     new Category {CategoryId=1, Name = "Telefon", Description = "Telefon Kategorisi" },
            //     new Category {CategoryId=2, Name = "Bilgisayar", Description = "Bilgisayar Kategorisi" },
            //     new Category {CategoryId=3, Name = "Elektronik", Description = "Elektronik Kategorisi" },
            //     new Category {CategoryId=4, Name = "Kitap", Description = "Kitap Kategorisi" }
            // };

            var c = new Category {Name = "Telefon", Description = "Telefon Kategorisi" };
            AddCategory(c);
            c = new Category {Name = "Bilgisayar", Description = "Bilgisayar Kategorisi" };
            AddCategory(c);
            c = new Category {Name = "Araba", Description = "Araba Kategorisi" };
            AddCategory(c);
            c = new Category {Name = "Kitap", Description = "Kitap Kategorisi" };
            AddCategory(c);
            c = new Category {Name = "Uçak", Description = "Uçak Kategorisi" };
            AddCategory(c);

            // foreach (var item in _categories)
            // {
            //     Console.WriteLine(item.CategoryId);    
            // }
        }

        //  kategoriler gönderilir.
        public static List<Category> Categories
        {
            get{
                return _categories;
            }
        }

        //  kategori eklenir.
        public static void AddCategory(Category category)
        {
            _categories.Add(category);
            totalRepository ++;
        }

        // id ye göre kategori geri döndürülür.
        public static Category GetCategoryById(int id)
        {
            //dışarıdan gönderilen id değerine eşitse ürün gönderilir.
            return _categories.FirstOrDefault(c=>c.CategoryId==id);
        }
    }
}