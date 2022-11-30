using AutoMapper;
using DeviceShop.Core;
using DeviceShop.Models;
using DeviceShop.Repos.DTO;



namespace DeviceApi
{
    public class AppAutoMapper : Profile
    {
        public AppAutoMapper()
        {
           CreateMap<DevicesDto, Device>();
           CreateMap<Device, DevicesDto>();

           CreateMap<CategoriesDto, Category>();
           CreateMap<Category, CategoriesDto>();

           CreateMap<CategoryModelsDto, CategoryModel>();
           CreateMap<CategoryModel, CategoryModelsDto>();

           CreateMap<ColoursDto, Colour>();
           CreateMap<Colour, ColoursDto>();
        }

    }
}
