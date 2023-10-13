using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Dtos.Books;
using Api.Domain.Dtos.Employees;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            //Author
            CreateMap<AuthorEntity, AuthorDto>().ReverseMap();
            CreateMap<AuthorEntity, AuthorDtoCreateResult>().ReverseMap();
            CreateMap<AuthorEntity, AuthorDtoUpdateResult>().ReverseMap();

            //Book
            CreateMap<BookEntity, BookDto>().ReverseMap();
            CreateMap<BookEntity, BookDtoCreateResult>().ReverseMap();
            CreateMap<BookEntity, BookDtoUpdateResult>().ReverseMap();

            //Employee
            //CreateMap<EmployeeEntity, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeEntity, EmployeeDtoCreateResult>().ReverseMap();
           // CreateMap<EmployeeEntity, EmployeeDtoUpdateResult>().ReverseMap();


        }
    }
}
