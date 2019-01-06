using ShoppingApp.Data.Models;
using ShoppingApp.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Services.Models.Categories
{
    public class CategoryViewModel : IMapFrom<Category>
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
