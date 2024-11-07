using AutoMapper;
using si730pc2u20201f846.API.WMS.Application.Internal.DTOs;
using si730pc2u20201f846.API.WMS.Domain.Entities;

namespace si730pc2u20201f846.API.WMS.Application.Internal.Mappings
{
    /// <summary>
    /// Mapping profile for Category entity to CategoryDto and vice versa.
    /// </summary>
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<CreateCategoryCommand, Category>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()); 
        }
    }
}
