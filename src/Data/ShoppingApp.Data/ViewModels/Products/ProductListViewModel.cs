using ShoppingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.ViewModels.Products
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public string CurrentCategory { get; set; }
    }
}
