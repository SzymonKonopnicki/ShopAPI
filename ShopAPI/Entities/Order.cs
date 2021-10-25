using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateDelivery { get; set; }
        public Address Addresses {  get; set; }
        public List<Product> Products { get; set; }

        //Add attribute like [RequiredAttribute]
        //public decimal TotalPrice {  get; set; }
        //public bool Confirm { get; set; }
        //public string Status {  get; set; }
        //Address
    }
}
