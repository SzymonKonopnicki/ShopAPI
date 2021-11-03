using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Model
{
    public class OrderCreateDto
    {
        public DateTime DateDelivery { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public List<ProductDto> Products { get; set; }

    }
}
