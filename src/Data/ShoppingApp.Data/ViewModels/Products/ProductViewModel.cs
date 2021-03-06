﻿using ShoppingApp.Data.Models;
using ShoppingApp.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Services.Models.Products
{
    public class ProductViewModel : IMapFrom<Category>
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
