using ShoppingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
