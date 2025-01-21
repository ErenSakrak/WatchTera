using AutoMapper;
using WatchTera.DTO.DTOs.AddressDtos;
using WatchTera.Entity.Entities;

namespace WatchTera.WebAPI.Mapping
{
    public class AddressMapping : Profile
    {
        public AddressMapping()
        {
            CreateMap<CreateAddressDto, Address>().ReverseMap();
            CreateMap<UpdateAddressDto, Address>().ReverseMap();
        }
    }
}
