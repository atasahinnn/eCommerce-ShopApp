using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
    public interface IRepository<TEntity> // ENTITY TİPİ - PRODUCT,CATEGORY,ORDER VS. 
    {
        Task <TEntity> GetByID(int id);
        Task <List<TEntity>> GetAll();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task CreateAsync(TEntity entity);

    }
}
    