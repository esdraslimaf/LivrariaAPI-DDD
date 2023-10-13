using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Dtos.Books;
using Api.Domain.Dtos.Employees;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            //Authors
            CreateMap<AuthorModel,AuthorDto>().ReverseMap();
            CreateMap<AuthorModel,AuthorDtoCreate>().ReverseMap();
            CreateMap<AuthorModel,AuthorDtoUpdate>().ReverseMap();

            //Books
            CreateMap<BookModel,BookDto>().ReverseMap();
            CreateMap<BookModel,BookDtoCreate>().ReverseMap();
            CreateMap<BookModel,BookDtoUpdate>().ReverseMap();

            //Employee
            CreateMap<EmployeeModel,EmployeeDto>().ReverseMap();
            CreateMap<EmployeeModel,EmployeeDtoCreate>().ReverseMap();
            CreateMap<EmployeeModel,EmployeeDtoUpdate>().ReverseMap();
        }
    }
}
