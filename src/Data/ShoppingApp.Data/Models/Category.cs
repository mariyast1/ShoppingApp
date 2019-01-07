using ShoppingApp.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Models
{
    public class Category : BaseModel<int>
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
