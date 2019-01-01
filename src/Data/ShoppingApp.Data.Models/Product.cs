using ShoppingApp.Data.Common.Models;
using ShoppingApp.Data.Models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Models
{
   public class Product : BaseModel<int>
    {
        public decimal Price { get; set; }

        public Size Size { get; set; }

        public char Gender { get; set; }

        public int CategoryId { get; set; }

        public SubCategory SubCategory { get; set; }

        public int SubCategoryId { get; set; }

        public Order Order { get; set; }
    }
}
