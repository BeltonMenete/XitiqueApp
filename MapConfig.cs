using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using xitiqueAPI.Models;
using xitiqueAPI.Models.DTOs;

namespace xitiqueAPI
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<Client, CreateClientDTO>().ReverseMap();
            CreateMap<Client, UpdateClientDTO>().ReverseMap();
        }
    }
}