using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using XitiqueAPI.Models;

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