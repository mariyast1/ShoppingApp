using ShoppingApp.Data.Common.Models;
using ShoppingApp.Data.Models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Models
{
    public class Order : BaseModel<int>
    {
        public Order()
        {
            this.Products = new HashSet<Product>();
        }

        public Status Status { get; set; }

        public DateTime DeliveryDate { get; set; }

        public ApplicationUser Recepient { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
