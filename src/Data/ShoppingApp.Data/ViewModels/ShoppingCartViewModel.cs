using System;
using System.Collections.Generic;
using System.Text;
using ShoppingApp.Data.Models;

namespace ShoppingApp.Data.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }

        public decimal ShoppingCartTotal { get; set; }
    }
}
