using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        Task<Product> GetByID(int id);
        Product GetProductDetails(string url);
        Task<List<Product>> GetAll();
        List<Product> GetSearchResult(string searchString);
        void Create(Product entity);
        Task <Product> CreateAsync(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        Task DeleteAsync(Product entity);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);
        Product GetByIdWithCategories(int id);
        void Update(Product entity, int[] categoryIds);
        Task UpdateAsync(Product entityToUpdate, Product entity);
    }
}
