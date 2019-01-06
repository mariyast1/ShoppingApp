using ShoppingApp.Data.Common.Models;
using ShoppingApp.Data.Models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Models
{
   public class Product : BaseModel<int>
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsPreferredProduct { get; set; }

        public bool InStock { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Image { get; set; }
    }
}
