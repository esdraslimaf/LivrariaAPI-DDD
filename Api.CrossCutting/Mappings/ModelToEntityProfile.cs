using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile:Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<AuthorModel, AuthorEntity>().ReverseMap();
            CreateMap<BookModel, BookEntity>().ReverseMap();
            CreateMap<EmployeeModel, EmployeeEntity>().ReverseMap();
        }
    }
}
