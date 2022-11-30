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
        }

    }
}
