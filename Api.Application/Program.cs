using Api.CrossCutting.DependencyInjector;
using Api.CrossCutting.Mappings;
using AutoMapper;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigureRepository.ConfiguracaoDependenciaRepositorio(builder.Services);
ConfigureService.ConfiguracaoDependenciaService(builder.Services);

var config = new AutoMapper.MapperConfiguration(conf=>{
conf.AddProfile(new DtoToModelProfile());
conf.AddProfile(new EntityToDtoProfile());
conf.AddProfile(new ModelToEntityProfile());
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=>{
     c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Aprendizagem API com DDD",
        Description = "Aprofundando em DDD",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Esdras Lima - Linkedin",
            Email = "esdraslimaf@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/esdrasdev/")
        }
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
     app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API com DDD Net 6.0");
        c.RoutePrefix = string.Empty;
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
