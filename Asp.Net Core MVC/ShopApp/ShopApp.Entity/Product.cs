﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity
{
    public class Product
    {
        public int CategoryId;
        
        public int ProductId { get; set; }

        public string Name { get; set; }
        public string Url { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
