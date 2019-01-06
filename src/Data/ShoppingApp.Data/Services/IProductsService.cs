using ShoppingApp.Services.Models.Categories;
using ShoppingApp.Services.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Services.Data
{
   public interface IProductsService
    {
        TViewModel GetProductById<TViewModel>(int id);

        IEnumerable<ProductViewModel> GetAllByCategory(int categoryId);
    }
}
