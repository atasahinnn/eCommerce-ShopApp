using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EntityFrameworkCore;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Product entity)
        {
            // İŞ KURALLARI MANAGER ALTINDA UYGULANACAK.
            _unitOfWork.Products.Create(entity);
            _unitOfWork.Save();
        }

        public async Task<Product> CreateAsync(Product entity)
        {
            await _unitOfWork.Products.CreateAsync(entity);
            await _unitOfWork.SaveAsync();

            return entity;
        }

        public void Delete(Product entity)
        {
            // - 
            _unitOfWork.Products.Delete(entity);
        }

        public async Task DeleteAsync(Product entity)
        {
            _unitOfWork.Products.Delete(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task <List<Product>> GetAll()
        {
            return await _unitOfWork.Products.GetAll();
        }

        public async Task <Product> GetByID(int id)
        {
            return await _unitOfWork.Products.GetByID(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _unitOfWork.Products.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return _unitOfWork.Products.GetCountByCategory(category);
        }

        public Product GetProductDetails(string url)
        {
            return _unitOfWork.Products.GetProductDetails(url);
                        
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _unitOfWork.Products.GetProductsByCategory(name,page,pageSize);
        }

        public List<Product> GetSearchResult(string searchString)
        {
            return _unitOfWork.Products.GetSearchResult(searchString);
        }

        public void Update(Product entity)
        {
            _unitOfWork.Products.Update(entity);
        }

        public void Update(Product entity, int[] categoryIds)
        {
            _unitOfWork.Products.Update(entity, categoryIds);
            _unitOfWork.Save();
        }

        public async Task UpdateAsync(Product entityToUpdate, Product entity)
        {
            entityToUpdate.Name = entity.Name;
            entityToUpdate.Price = entity.Price;
            entityToUpdate.Description = entity.Description;

            await _unitOfWork.SaveAsync();
        }
    }
}
