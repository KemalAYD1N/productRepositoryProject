using System.ComponentModel.DataAnnotations;

namespace repositoryManagement.Models
{
    //depo sınıfı
        public class Category
    {
        public Category(){
            Id ++ ;
            CategoryId = Id;
        }
        public static int Id { get; set; } = 0;
        public int CategoryId { get; set; } //  her depoya özel Id

        [Required]
        public string Name { get; set; }    //  depo adı

        [Required]
        public string Description { get; set; } //  açıklama
    }
}