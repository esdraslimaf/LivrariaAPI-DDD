using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<AuthorModel,AuthorDto>().ReverseMap();
            CreateMap<AuthorModel,AuthorDtoCreate>().ReverseMap();
            CreateMap<AuthorModel,AuthorDtoUpdate>().ReverseMap();
        }
    }
}
