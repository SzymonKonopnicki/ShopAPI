using System;

namespace ShopAPI.Model
{
    public class UpdataOrderDto
    {
        public DateTime DateDelivery { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

    }
}
