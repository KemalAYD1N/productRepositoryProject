using System.Collections.Generic;
using repositoryManagement.Models;

//Bu sınıf, controller sınıflarından view katmanına veri aktarımı için kullanılır. 

public class ProductViewModel
{
        //Product model türünde veri aktarımı için ürün listesi oluşturulur.
        public List<Product> Products { get; set; }

}