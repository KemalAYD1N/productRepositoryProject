using System.ComponentModel.DataAnnotations;

namespace repositoryManagement.Models
{
    //ürün sınıfı
    public class Product
    {
        public Product(){
            Id += 1;
            ProductId = Id;
        }

        [Required]
        public double? productCode { get; set; }    // ürün kodu. aynı ürünlerin kodları ortaktır.
        public static int Id { get; set; } = 0;
        public int ProductId { get; set; }  //  her ürüne aytı olarak atanmıştır.

        [Required]
        public string ProductStockName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "en az 1, an fazla 60 karakter giriniz")]
        public string Name { get; set; }    //  ürün adı      
        
        [Required(ErrorMessage="fiyat girmelisiniz")]
        // [Range(1,10000)]
        public double? Price { get; set; }  //  ürün fiyatı

        [Required]
        public string Description { get; set; } //  ürün açıklaması
        
        [Required]
        public string ImageUrl { get; set; }    //  ürün resmi
        
        [Required]
        public int? CategoryId { get; set; }    //  ürünün bulunduğu kategori numarası
        public bool IsApproved { get; set; }

        //public static int stockQuantity { get; set; } = 0;
    }
}