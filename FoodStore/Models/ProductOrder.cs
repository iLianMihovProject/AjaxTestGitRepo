﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FoodStore.Models
{
    public partial class ProductOrder
    {
        public string ProductId { get; set; }
        public string OrderId { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
