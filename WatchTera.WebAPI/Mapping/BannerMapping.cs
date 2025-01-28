using AutoMapper;
using WatchTera.DTO.DTOs.BannerDtos;
using WatchTera.Entity.Entities;

namespace WatchTera.WebAPI.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<CreateBannerDto,Banner>().ReverseMap();
            CreateMap<UpdateBannerDto,Banner>().ReverseMap();
        }
    }
}
