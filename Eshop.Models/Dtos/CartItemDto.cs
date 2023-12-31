﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Models.Dtos
{
    internal class CartItemDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public string Name { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set;}
        public int Qty { get; set; }
    }
}
