using ShoppingApp.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data.Models
{
    public class Receipt : BaseModel<int>
    {
        public decimal Fee { get; set; }

        public DateTime IssuedOn { get; set; }

        public ApplicationUser Recepient { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
