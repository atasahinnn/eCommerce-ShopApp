using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Display(Name = "Name:", Prompt = "Ürün Adı Giriniz..")]
        [Required(ErrorMessage = "Ürün Adı Zorunlu Bir Alandır.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Ürün Adı 5-50 Karakter Arası Olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ürün Fiyatı Zorunlu Bir Alandır.")]
        [Range(1,100000, ErrorMessage = "Fiyat Alanı 1 ile 100.000 Arasında Olmalıdır.")]
        [Display(Prompt = "Fiyat Giriniz..")]
        public double? Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "URL Zorunlu Bir Alandır.")]
        public string Url { get; set; }
        public List <Category> SelectedCategories { get; set; }
        public List<Category> Categories { get; set; }
    }
}
