using AutoMapper;
using XitiqueAPI.Models;
using XitiqueAPI.Models.DTOs;

namespace XitiqueAPI
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
            CreateMap<Client, CreateClientDTO>().ReverseMap();
            CreateMap<Client, UpdateClientDTO>().ReverseMap();
        }
    }
}