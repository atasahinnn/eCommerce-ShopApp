﻿using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
    public interface ICategoryService
    {
        Task<Category> GetByID(int id);
        Category GetByIdWithProducts(int category);
        Task <List<Category>> GetAll();

        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        void DeleteFromCategory(int productId, int categoryId);
    }
}
