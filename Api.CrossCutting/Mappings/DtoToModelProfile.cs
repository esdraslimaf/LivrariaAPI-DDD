using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Dtos.Books;
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

            CreateMap<BookModel,BookDto>().ReverseMap();
            CreateMap<BookModel,BookDtoCreate>().ReverseMap();
            CreateMap<BookModel,BookDtoUpdate>().ReverseMap();
        }
    }
}
