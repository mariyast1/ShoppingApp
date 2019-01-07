using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Models;
using ShoppingApp.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp.Data.Repositories
{
    public class ProductRepository : IProductRepository
    { 
        private readonly ApplicationDbContext _appDbContext;

        public ProductRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

        public IEnumerable<Product> Products => _appDbContext.Products.Include(c => c.Category);

        public IEnumerable<Product> PreferredProducts => _appDbContext.Products.Where(p => p.IsPreferredProduct).Include(c => c.Category);

        public Product GetProductById(int productId) => _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
}
    }
