using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<AuthorEntity, AuthorDto>().ReverseMap();
            CreateMap<AuthorEntity, AuthorDtoCreateResult>().ReverseMap();
            CreateMap<AuthorEntity, AuthorDtoUpdateResult>().ReverseMap();
        }
    }
}
