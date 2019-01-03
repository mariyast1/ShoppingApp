using ShoppingApp.Data.Common.Repositories;
using ShoppingApp.Data.Models;
using ShoppingApp.Services.Mapping;
using ShoppingApp.Services.Models;
using ShoppingApp.Services.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp.Services.Data
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Category> categoriesRepository;

        public CategoriesService(IRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            var categories = this.categoriesRepository.All().OrderBy(x => x.Name)
                .To<CategoryViewModel>().ToList();

            return categories;
        }

        public int GetCategoryId(string name)
        {
            var category = this.categoriesRepository.All().FirstOrDefault(x => x.Name == name);
            return category.Id;
        }
    }
}
