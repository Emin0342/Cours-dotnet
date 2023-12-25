
using newWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
namespace webapi;
using AutoMapper;
using BooksAPI.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        var builder = WebApplication.CreateBuilder(args);
         Assembly a = typeof(Program).Assembly;
        Console.WriteLine("Assembly identity={0}", a.FullName);
        // Add services to the container.
        builder.Services.AddDbContext<AppDbContext>();
        builder.Services.AddControllers();
        // pour ne plus avoir l'erreur : Access to fetch at 'http://localhost:5123/api/Book' from origin 'https://localhost:5001' has been blocked by CORS policy: No 'Access-Control-Allow-Origin' header is present on the requested resource. If an opaque response serves your needs, set the request's mode to 'no-cors' to fetch the resource with CORS disabled.
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: MyAllowSpecificOrigins,
                        policy =>
                        {
                            policy.AllowAnyOrigin();
                        });
    });

     
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.UseCors();

        app.MapControllers();

        app.Run();
    }
}



public class MappingProfile : Profile { // on crée une classe MappingProfile qui hérite de Profile
     public MappingProfile() { // on crée un constructeur
         CreateMap<Book, BookUpdateDTO>(); // ici on map les champs de la table Book avec les champs du DTO
     }
 }