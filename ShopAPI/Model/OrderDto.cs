using System;
using System.Collections.Generic;

namespace ShopAPI.Model
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateDelivery { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public List<ProductDto> Products { get; set; }


    }
}
