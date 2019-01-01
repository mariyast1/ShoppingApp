using ShoppingApp.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Models
{
   public class SubCategory :BaseModel<int>
    {
        public SubCategory()
        {
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
