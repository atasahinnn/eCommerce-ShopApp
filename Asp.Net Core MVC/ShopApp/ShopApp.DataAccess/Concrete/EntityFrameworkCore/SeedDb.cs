using Microsoft.EntityFrameworkCore;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EntityFrameworkCore
{
    public static class SeedDb
    {
        public static void Seed()
        {
            //var context = new ShopContext();

            //if (context.Database.GetPendingMigrations().Count() == 0)
            //{
            //    if (context.Categories.Count() == 0)
            //    {
            //        context.Categories.AddRange(Categories);
            //    }

            //    if (context.Products.Count() == 0)
            //    {
            //        context.Products.AddRange(Products);
            //    }
            //    if (context.ProductCategories.Count() == 0)
            //    {
            //        context.ProductCategories.AddRange(ProductCategories);
            //    }
            //}

            //context.SaveChanges();
        }

        private static Category[] Categories =
        {
            new Category() {Name = "Bilgisayar", Url = "bilgisayar"},
            new Category() {Name = "Telefon", Url = "telefon"},
            new Category() {Name = "Laptop", Url = "laptop"},
            new Category() {Name = "Ekran Kartı", Url = "ekran-karti"},
            new Category() {Name = "İşlemci", Url = "islemci"},
            new Category() {Name = "Otomobil", Url = "otomobil"}
        };

        private static Product[] Products =
        {
            new Product() {Name = "GTX 1660 Ti", Url = "gtx-1660-ti", Price = 4000, Description = "Ekran Kartı", ImageUrl = "1.jpg"},
            new Product() {Name = "Ryzen 5 3600", Url = "ryzen-3600", Price = 2000, Description = "İşlemci", ImageUrl = "2.jpg"},
            new Product() {Name = "Intel i9 9900K", Url = "intel-i9", Price = 2500, Description = "İşlemci", ImageUrl = "3.jpg"},
            new Product() {Name = "Samsung EVO SSD 480GB", Url = "evo-ssd", Price = 750, Description = "Harici Disk", ImageUrl = "4.jpg"},
            new Product() {Name = "ViewSonic VX2458", Url = "vx2458", Price = 1500, Description = "Monitör", ImageUrl = "5.jpg"},
            new Product() {Name = "Xiaomi Mi 6", Url = "xiaomi-mi6", Price = 4000, Description = "Telefon", ImageUrl = "9.jpg"},
            new Product() {Name = "iPhone 10 Max", Url = "iphone-10", Price = 4000, Description = "Telefon", ImageUrl = "7.jpg"},
            new Product() {Name = "Samsung Galaxy S9", Url = "galaxy-s9", Price = 4000, Description = "Telefon", ImageUrl = "9.jpg"}
        };

        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory() {Product = Products[0], Category = Categories[3]},
            new ProductCategory() {Product = Products[1], Category = Categories[4]},
            new ProductCategory() {Product = Products[2], Category = Categories[4]},
            new ProductCategory() {Product = Products[3], Category = Categories[2]},
            new ProductCategory() {Product = Products[4], Category = Categories[3]},
            new ProductCategory() {Product = Products[5], Category = Categories[1]},
            new ProductCategory() {Product = Products[6], Category = Categories[1]},
            new ProductCategory() {Product = Products[7], Category = Categories[1]},

        };

    }
}
