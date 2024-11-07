using AutoMapper;
using si730pc2u20201f846.API.WMS.Application.Internal.DTOs;
using si730pc2u20201f846.API.WMS.Domain.Entities;

namespace si730pc2u20201f846.API.WMS.Application.Internal.Mappings
{
    /// <summary>
    /// Simplified mapping profile for Product entity to ProductDto and vice versa.
    /// </summary>
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<CreateProductCommand, Product>()
                .ForMember(dest => dest.ProductId, opt => opt.Ignore()) 
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());
        }
    }
}
