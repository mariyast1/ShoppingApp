using ShoppingApp.Data.Interfaces;
using ShoppingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CategoryRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
