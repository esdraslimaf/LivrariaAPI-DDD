using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjector
{
    public static class ConfigureRepository //Vamos colocar esse método abaixo no program.cs
    {
        public static void ConfiguracaoDependenciaRepositorio(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            
            serviceCollection.AddDbContext<MyContext>(options =>
  {
      options.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=LearnDDDBook;Trusted_Connection=True");
  });
 

        }


    }
    
}

