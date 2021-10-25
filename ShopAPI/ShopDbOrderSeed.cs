using ShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopAPI
{
    public class ShopDbOrderSeed
    {
        private readonly ShopContext _context;

        public ShopDbOrderSeed(ShopContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Database.CanConnect())
            {
                if (!_context.Orders.Any())
                {
                    var baseOrder = GetOrders();
                    _context.AddRange(baseOrder);
                    _context.SaveChanges();
                }
            }
        }

        public List<Order> GetOrders()
        {
            List<Order> initial = new List<Order>()
            {
                 new Order()
                 {
                    DateDelivery = new DateTime(2000, 01, 01),
                    Addresses = new Address
                    {
                        City = "Wrocław",
                        Email = "szymon@gmail.com",
                        Street = "Kwaśna"
                    },
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Róże",
                            Available = true,
                            PriceS = 4.99
                        },

                        new Product
                        {
                            Name = "Tulipany",
                            Available = true,
                            PriceS = 5.99
                        },
                        new Product
                        {
                            Name = "Storczyk",
                            Available = true,
                            PriceS = 3.99
                        },
                        new Product
                        {
                            Name = "Konwalie",
                            Available = true,
                            PriceS = 10.99
                        }
                    }
                 },

                 new Order()
                 {
                    DateDelivery = new DateTime(2000, 05, 10),
                    Addresses = new Address
                    {
                        City = "Strzelin",
                        Email = "konopnicki@gmail.com",
                        Street = "Stalowa"
                    },
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Róże",
                            Available = true,
                            PriceS = 4.99
                        },

                        new Product
                        {
                            Name = "Konwalie",
                            Available = true,
                            PriceS = 10.99
                        }
                    }
                 }
            };

            return initial;
        }
    }
}
