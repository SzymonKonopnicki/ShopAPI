using AutoMapper;
using ShopAPI.Entities;
using ShopAPI.Model;

namespace ShopAPI
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(x => x.City, y => y.MapFrom(z => z.Addresses.City))
                .ForMember(x => x.Street, y => y.MapFrom(z => z.Addresses.Street))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Addresses.Email));

            CreateMap<Product, ProductDto>();
        }
    }
}
