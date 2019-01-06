using ShoppingApp.Data.Common.Repositories;
using ShoppingApp.Data.Models;
using ShoppingApp.Services.Mapping;
using ShoppingApp.Services.Models.Categories;
using ShoppingApp.Services.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp.Services.Data
{
    public class ProductsService : IProductsService
    {
        private readonly IRepository<Product> productsRepository;
        private readonly IRepository<Category> categoriesRepository;

        public ProductsService(
            IRepository<Product> productsRepository,
            IRepository<Category> categoriesRepository)
        {
            this.productsRepository = productsRepository;
            this.categoriesRepository = categoriesRepository;
        }

        public TViewModel GetProductById<TViewModel>(int id)
        {
            var product = this.productsRepository.All().Where(x => x.Id == id)
                .To<TViewModel>().FirstOrDefault();
            return product;
        }

        public IEnumerable<ProductViewModel> GetAllByCategory(int categoryId)
            => this.productsRepository
                    .All()
                    .Where(j => j.CategoryId == categoryId)
                    .To<ProductViewModel>();
    }
}
