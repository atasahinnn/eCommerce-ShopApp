using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopContext context): base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public void DeleteFromCategory(int productId, int categoryId)
        {
            
            var cmd = "delete from ProductCategories where ProductId=@p0 and CategoryId=@p1";
            ShopContext.Database.ExecuteSqlRaw(cmd,productId,categoryId);
            
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            
            return ShopContext.Categories
                            .Where(c => c.CategoryId == categoryId)
                            .Include(c => c.ProductCategories)
                            .ThenInclude(p => p.Product)
                            .FirstOrDefault();
            
        }

        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
