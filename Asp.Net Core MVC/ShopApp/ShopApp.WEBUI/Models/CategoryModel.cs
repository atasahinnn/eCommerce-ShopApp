using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Kategori Alanı 5-50 Arasında Olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Kategori Link Alanı Zorunludur.")]
        public string Url { get; set; }
        public List <Product> Products { get; set; }
    }
}
