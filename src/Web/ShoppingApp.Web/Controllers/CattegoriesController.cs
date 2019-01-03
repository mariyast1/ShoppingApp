using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Web.Controllers
{
    public class CattegoriesController : BaseController
    {
        private readonly IProductsService productsService;
        private readonly ICategoriesService categoriesService;

        public CattegoriesController(
            IProductsService productsService,
            ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
            this.productsService = productsService;
        }

        public IActionResult Men()
        {
            var categories = categoriesService
                .GetAll()
                .ToList();

            return this.View(categories);
        }

        public IActionResult Women()
        {

            return this.View();
        }
    }
}
