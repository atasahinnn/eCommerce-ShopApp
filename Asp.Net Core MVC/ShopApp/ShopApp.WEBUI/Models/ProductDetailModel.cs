using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List <Category> Categories { get; set; }

    }
}
