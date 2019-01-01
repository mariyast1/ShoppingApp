using ShoppingApp.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Models
{
    public class Category : BaseModel<int>
    {
        public Category()
        {
            this.SubCategories = new HashSet<SubCategory>();
        }

        public string Name { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
