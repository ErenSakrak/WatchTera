using AutoMapper;
using WatchTera.DTO.DTOs.AboutDtos;
using WatchTera.Entity.Entities;

namespace WatchTera.WebAPI.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();
        }
    }
}
