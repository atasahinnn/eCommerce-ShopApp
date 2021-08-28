using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Entity;

namespace ShopApp.DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {       
        List<Product> GetPopularProducts();
        List<Product> GetSearchResult(string searchString);
        Product GetProductDetails(string url);
        List <Product> GetProductsByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);
        Product GetByIdWithCategories(int id);
        void Update(Product entity, int[] categoryIds);
    }
}
