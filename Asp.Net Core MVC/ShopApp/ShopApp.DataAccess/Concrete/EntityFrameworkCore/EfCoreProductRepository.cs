﻿using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopContext context): base(context)
        {

        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }

        public Product GetByIdWithCategories(int id)
        {

            
            return ShopContext.Products
                            .Where(c => c.ProductId == id)
                            .Include(c => c.ProductCategories)
                            .ThenInclude(p => p.Category)
                            .FirstOrDefault();
            
        }      

        public int GetCountByCategory(string category)
        {

            var products = ShopContext.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Include(i => i.ProductCategories)
                                    .ThenInclude(i => i.Category)
                                    .Where(i => i.ProductCategories.Any(a => a.Category.Url == category));
            }

            return products.Count();
            
        }

        public List<Product> GetPopularProducts()
        {           
            return ShopContext.Products.ToList();           
        }

        public Product GetProductDetails(string url)
        {
            
            return ShopContext.Products.Where(p => p.Url == url)
                                    .Include(p => p.ProductCategories)
                                    .ThenInclude(p => p.Category)
                                    .FirstOrDefault();
            
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            
            var products = ShopContext.Products.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                products = products.Include(i => i.ProductCategories)
                                    .ThenInclude(i => i.Category)
                                    .Where(i => i.ProductCategories.Any(a => a.Category.Url == name));
            }

            return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            
        }

        public List<Product> GetSearchResult(string searchString)
        {

            
            var products = ShopContext.Products
                            .Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString))
                            .AsQueryable();

            return products.ToList();

            
        }

        public void Update(Product entity, int[] categoryIds)
        {

            
            var product = ShopContext.Products
                                    .Include(p=> p.ProductCategories)    
                                    .FirstOrDefault(p => p.ProductId == entity.ProductId);

            if (product != null)
            {
                product.Name = entity.Name;
                product.Price = entity.Price;
                product.Description = entity.Description;
                product.ImageUrl = entity.ImageUrl;
                product.Url = entity.Url;
                product.ProductCategories = categoryIds.Select(cId => new ProductCategory()
                {
                    ProductId = entity.ProductId,
                    CategoryId = cId
                }).ToList();

            }
        }
    }
}


