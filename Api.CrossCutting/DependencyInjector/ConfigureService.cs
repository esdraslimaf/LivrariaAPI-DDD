using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services;
using Api.Service;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjector
{
    public static class ConfigureService
    {
        public static void ConfiguracaoDependenciaService(IServiceCollection serviceCollection){
        serviceCollection.AddTransient<IAuthorService, AuthorService>(); 
        serviceCollection.AddTransient<IBookService, BookService>(); 
        serviceCollection.AddTransient<IEmployeeService, EmployeeService>(); 
    }
}
}
