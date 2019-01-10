using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Data.Interfaces;
using ShoppingApp.Data.Models;
using ShoppingApp.Data.ViewModels.Products;
using ShoppingApp.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
                currentCategory = "All wines";
            }
            else
            {
                if (string.Equals("White Wine", _category, StringComparison.OrdinalIgnoreCase))
                    products = _productRepository.Products.Where(p => p.Category.Name.Equals("White Wine")).OrderBy(p => p.Name);
                else
                    products = _productRepository.Products.Where(p => p.Category.Name.Equals("Red Wine")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
            }
            else
            {
                products = _productRepository.Products.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Product/List.cshtml", new ProductListViewModel { Products = products, CurrentCategory = "All drinks" });
        }

        public ViewResult Details(int productId)
        {
            var product = _productRepository.Products.FirstOrDefault(d => d.ProductId == productId);
            if (product == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(product);
        }
    }
}
