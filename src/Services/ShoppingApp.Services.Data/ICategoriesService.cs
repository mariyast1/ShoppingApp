using ShoppingApp.Services.Models;
using ShoppingApp.Services.Models.Categories;
using System;
using System.Collections.Generic;
using System.Text;


namespace ShoppingApp.Services.Data
{
    public interface ICategoriesService
    {
        IEnumerable<CategoryViewModel> GetAll();

        int GetCategoryId(string name);
    }
}
